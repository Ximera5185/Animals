using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string roar, int numberOfBonesBuried) : base(name, roar)
        {
            NumberOfBonesBuried = numberOfBonesBuried;
        }

        private  int NumberOfBonesBuried;

        public override void PlaySound(string name, string roar)
        {
            base.PlaySound(name, roar);

            Console.WriteLine($"Колличество косточек {NumberOfBonesBuried} ");
        }
    }
}
