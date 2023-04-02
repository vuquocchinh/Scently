using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scently.Models;

namespace Scently.Controllers
{
    public class UserController : Controller
    {
        ScentlyDataContext data = new ScentlyDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (string.IsNullOrEmpty(user.TaiKhoan) || string.IsNullOrEmpty(user.MatKhau))
            {
                ModelState.AddModelError("", "Vui lòng điền đầy đủ thông tin tài khoản và mật khẩu");
                return View();
            }

            var loginUser = data.TaiKhoans.FirstOrDefault(x => x.taiKhoan1 == user.TaiKhoan && x.matKhau == user.MatKhau);

            if (loginUser != null)
            {
                // Đăng nhập thành công, thực hiện lưu session và chuyển hướng đến trang chủ
                Session["taiKhoan"] = loginUser.taiKhoan1;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Đăng nhập không thành công, trả về thông báo lỗi
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                return View();
            }
        }

        // Logout
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        // GET: Register
        public ActionResult Register()
        {
            return View(new TaiKhoan());
        }

        // POST: Register
        [HttpPost]
        public ActionResult Register(TaiKhoan user)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra tài khoản đã tồn tại chưa
                var existingUser = data.TaiKhoans.FirstOrDefault(x => x.taiKhoan1 == user.taiKhoan1);
                if (existingUser != null)
                {
                    ViewBag.Error = "Tài khoản đã tồn tại";
                    return View();
                }

                // Thêm mới tài khoản
                data.TaiKhoans.InsertOnSubmit(user);
                data.SubmitChanges();

                // Chuyển hướng đến trang chủ
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Dữ liệu không hợp lệ, trả về thông báo lỗi
                ViewBag.Error = "Dữ liệu không hợp lệ";
                return View();
            }
        }

    }
}
