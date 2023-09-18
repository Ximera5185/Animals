using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        public Animal(string name, string roar)
        {
            Name = name;
            Roar = roar;
        }
        public string Name { private set; get; }
        public string Roar { private set; get; }

      virtual public void PlaySound()
        {
            Console.WriteLine($"Имя {Name} Звук {Roar}");
        }
    }
}
