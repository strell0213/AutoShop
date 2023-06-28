using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class Order
    {
        public int ID { get; set; }

        public int IDClient { get; set; }
        public int IDProvider { get; set; }
        public int Products { get; set; }
        private string DateStart, DateEnd, Discription;
        public string dateStart { get { return DateStart; } set { DateStart = value; } }
        public string dateEnd { get { return DateEnd; } set { DateEnd = value; } }
        public int StatusID { get; set; }
        public int FinallyPrice { get; set; }
        public string discription { get { return Discription; } set { Discription = value; } }
        public Order() { }

        public Order(int IDClient, int IDProvider, int Product, string DateStart, string DateEnd, int StatusID, int FinallyPrice, string Discription)
        {
            this.IDClient= IDClient;
            this.IDProvider= IDProvider;
            this.Products = Product;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.StatusID = StatusID;
            this.FinallyPrice= FinallyPrice;
            this.Discription = Discription;
        }
    }
}
