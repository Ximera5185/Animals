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

        public void PlaySound()
        {
            base.PlaySound(Name, Roar);

            Console.WriteLine($" {NumberOfBonesBuried} ");
        }
    }
}
