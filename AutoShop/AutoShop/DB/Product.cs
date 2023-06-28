using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    public class Product
    {
        public int ID { get; set; }

        private string NameProduct, Quantity;

        public string nameProduct { get { return NameProduct; } set { NameProduct = value; } }

        
        public int IDManufacturer { get; set; }
        public string quantity { get { return Quantity; } set { Quantity = value; } }
        public int TypeID { get; set; }
       
        public int Price { get; set; }

        public Product() { }

        public Product(string NameProduct, int IDManufacturer, string Quantity, int TypeID, int Price )
        { 
            this.NameProduct= NameProduct;
            this.IDManufacturer= IDManufacturer;
            this.Quantity=Quantity;
            this.TypeID= TypeID;
            this.Price = Price;
        }
    }
}
