using System;

namespace Animals
{
    internal class Cat : Animal
    {
        private bool _IsPurr { get; set; }

        public Cat(string name, string roar, bool IsPurr) : base(name, roar)
        {
            this._IsPurr = IsPurr;
        }

        override public void PlaySound(string name, string roar)
        {
            if (_IsPurr)
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
