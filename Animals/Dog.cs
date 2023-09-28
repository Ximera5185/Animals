using System;

namespace Animals
{
    internal class Dog : Animal
    {
        private int _numberOfBonesBuried { get; set; }

        public Dog(string name, string roar, int numberOfBonesBuried) : base(name, roar)
        {
            _numberOfBonesBuried = numberOfBonesBuried;
        }

        public override void PlaySound(string name, string roar)
        {
            base.PlaySound(name, roar);

            Console.WriteLine($"Колличество косточек {_numberOfBonesBuried} ");
        }
    }
}
