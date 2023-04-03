using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scently.Models;

namespace Scently.Models
{
    
    public class CartItem
    {
        public SanPham _sp { get; set; }
        public int _quantity { get; set; }

    }
    
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(SanPham sp, int quantity = 1)
        {
            var item = items.FirstOrDefault(s => s._sp.idSP == sp.idSP);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    _sp = sp,
                    _quantity = quantity
                });
            }else
            {
                item._quantity += quantity;
            }    
        }
        public void Update_Quantity_Shopping(int id, int quantity)
        {
            var item = items.Find(s => s._sp.idSP == id);
            if ( item != null )
            {
                item._quantity = quantity;
            }
        }
        public double ToTal()
        {
            var total = items.Sum(s => s._sp.giaSP*s._quantity);
            return (double)total;
        }
        public void Remove_Item(int id)
        {
            items.RemoveAll(s => s._sp.idSP==id);
        }
    }
}