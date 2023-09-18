using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, string roar, bool IsCatPurr) : base(name, roar)
        {
            _IsCatPurr = IsCatPurr;
        }
        private bool _IsCatPurr { get; set; }

        private  string _Purr = "";
 
        public override void PlaySound()
        {
            if (_IsCatPurr)
            {
                _Purr = "Мурчит";
            }
            else
            {
                _Purr = "Не мурчит";
            }

            Console.WriteLine($"Имя {Name} Звук {Roar} {_Purr}");
        }
    }
}
