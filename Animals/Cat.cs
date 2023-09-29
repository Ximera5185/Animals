using System;

namespace Animals
{
    internal class Cat : Animal
    {
        private bool _isPurr { get; set; }

        public Cat(string name, string roar, bool isPurr) : base(name, roar)
        {
            this._isPurr = isPurr;
        }

        override public void PlaySound(string name, string roar)
        {
            if (_isPurr)
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
