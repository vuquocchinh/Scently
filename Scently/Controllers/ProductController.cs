using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Scently.Models;
using PagedList;


namespace Scently.Controllers
{
    public class ProductController : Controller
    {
        ScentlyDataContext data = new ScentlyDataContext();

        // GET: Product
        public ActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNum = page ?? 1;

            var Sanpham = from sp in data.SanPhams
                          orderby sp.idSP
                          select sp;
            return View(Sanpham.ToPagedList(pageNum, pageSize));
        }

        //Page List MVC


        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = data.SanPhams.FirstOrDefault(p => p.idSP == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        // Get: Quan ly Product
        public ActionResult QLProducts(int? page)
        {

            var Sanpham = from sp in data.SanPhams
                          orderby sp.idSP
                          select sp;
            return View(Sanpham);

        }


        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(SanPham product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    data.SanPhams.InsertOnSubmit(product);
                    data.SubmitChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Error while creating product.");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = data.SanPhams.FirstOrDefault(p => p.idSP == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SanPham product)
        {
            try
            {
                var existingProduct = data.SanPhams.FirstOrDefault(p => p.idSP == id);
                if (existingProduct == null)
                {
                    return HttpNotFound();
                }

                if (ModelState.IsValid)
                {
                    existingProduct.tenSP = product.tenSP;
                    existingProduct.giaSP = product.giaSP;
                    existingProduct.soLuongSP = product.soLuongSP;
                    existingProduct.hinhAnhSP = product.hinhAnhSP;
                    existingProduct.thongTinSP = product.thongTinSP;
                    existingProduct.ngayCapNhat = product.ngayCapNhat;
                    existingProduct.idDM = product.idDM;
                    existingProduct.sale = product.sale;
                    existingProduct.status = product.status;

                    data.SubmitChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Error while updating product.");
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = data.SanPhams.FirstOrDefault(p => p.idSP == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SanPham product)
        {
            try
            {
                var existingProduct = data.SanPhams.FirstOrDefault(p => p.idSP == id);
                if (existingProduct == null)
                {
                    return HttpNotFound();
                }
                data.SanPhams.DeleteOnSubmit(existingProduct);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Error while deleting product.");
            }
            return View(product);
        }
    }
}