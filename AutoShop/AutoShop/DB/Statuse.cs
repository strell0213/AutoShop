using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class Statuse
    {
        public int ID { get; set; }

        private string StatusName;

        public string statusName { get { return StatusName; } set { StatusName = value; } }

        public Statuse() { }

        public Statuse(string StatusName)
        {
            this.StatusName = StatusName;
        }
    }
}
