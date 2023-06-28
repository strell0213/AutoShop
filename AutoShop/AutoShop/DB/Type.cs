using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop.DB
{
    internal class Type
    {
        public int ID { get; set; }

        private string TypeName;

        public string typeName { get { return TypeName; } set { TypeName = value; } }

        public Type() { }

        public Type(string TypeName)
        {
            this.TypeName = TypeName;
        }
    }
}
