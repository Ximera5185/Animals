using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, string roar, bool IsCatsPurr) : base(name, roar)
        {
        }

        public bool IsCatsPurr { get; set; }

      public  string Purr = "";

        
        public override void PlaySound()
        {
            if (IsCatsPurr == true)
            {
                Purr = "Мурчит";
            }
            else
            {
                Purr = "Не мурчит";
            }

            Console.WriteLine($"Имя {Name} Звук {Roar} {Purr}");
        }
    }
}
