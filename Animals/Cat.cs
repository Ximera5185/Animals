using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animals
    {
        public string Name = "";
        public string Roar = "";
        public Cat(string name, string roar)
        {
            Name = name;
            Roar = roar;
        }
    }
}
