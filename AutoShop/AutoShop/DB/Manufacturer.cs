using ServiceStack.DataAnnotations;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    public class Manufacturer
    {
        public int ID { get; set; }

        private string MFName, Address;

        public string mFName { get { return MFName; } set { MFName = value; } }
        public string address { get { return Address; } set { Address = value; } }
        public Manufacturer() { }

        public Manufacturer(string MFName, string Address)
        {
            this.MFName = MFName;
            this.Address = Address;
        }
    }
}
