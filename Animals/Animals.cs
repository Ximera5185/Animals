using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animals
    {
        public Animals(string name, string roar)
        {
            Name = name;
            Roar = roar;
        }
        public string Name { private set; get; }
        public string Roar { private set; get; }

        public void PlayAnimalSound(string name, string roar)
        {
            Console.WriteLine($"Имя {name} Звук {roar}");
        }
    }
}
