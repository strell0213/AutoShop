using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class Provider
    {
        public int ID { get; set; }

        private string FIO, Login, Password, Email;

        public string fIO { get { return FIO; } set { FIO = value; } }
        public string login { get { return Login; } set { Login = value; } }
        public string password { get { return Password; } set { Password = value; } }
        public string email { get { return Email; } set { Email = value; } }

        public int IDManufacturer { get; set; }
        public Provider() { }

        public Provider(string FIO, string Login, string Password, string Email, int IDManufacturer)
        {
            this.FIO = FIO;
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.IDManufacturer = IDManufacturer;
        }
    }
}
