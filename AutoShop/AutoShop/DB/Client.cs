using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class Client
    {
        public int ID { get; set; }

        private string FIO, Email, Phone, Address;

        public string fIO { get { return FIO; } set { FIO = value; } }
     
        public string email { get { return Email; } set { Email = value; } }
        public string phone { get { return Phone;  } set { Phone = value; } }
        public string address { get { return Address; } set { Address = value; } }

        public Client() { }

        public Client(string FIO, string Email, string Phone, string Address)
        {
            this.FIO = FIO;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
        }
    }
}
