using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class ShoppingCart
    {
        public int ID { get; set; }

        private string Products;

        public string products { get { return Products; } set { Products = value; } }

        public ShoppingCart() { }

        public ShoppingCart(string Products)
        {
            this.Products = Products;
        }

    }
}
