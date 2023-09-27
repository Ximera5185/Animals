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

        override public void PlaySound(string name, string roar)
        {

            if (_IsCatPurr)
            {
                Console.WriteLine("Мурчит");
            }
            else
            {
                Console.WriteLine("Не мурчит");
            }

            base.PlaySound(name, roar);
        }
    }
}
