using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animals
    {
        public string Name = "";
        public string Roar = "";

        public void PlayAnimalSound(string name,string roar) 
        {
            Console.WriteLine($"Имя {name} Звук {roar}");
        }
    }
}
