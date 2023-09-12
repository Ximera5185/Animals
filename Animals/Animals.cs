using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animals
    {
        string Name { get; set; }

        string Roar { get; set; }

        public void PlayAnimalSound() 
        {
            Console.WriteLine($"Звук {Name} {Roar}");
        }
    }
}
