using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        private List<CartItem> _items = new List<CartItem>();
       

        public List<CartItem> Items { 
            get { return _items; }
        }

        public void Add(Product sp , int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == sp.Id);
            if (item == null)
            {
                _items.Add(new CartItem { Product = sp, Quantity=qty });
            }
            else
            {
                item.Quantity += 1;
            }
        }
        public void Update(int id, int quantity)
        {

        }
        public void Remove(int id)
        {

        }

    }
}
