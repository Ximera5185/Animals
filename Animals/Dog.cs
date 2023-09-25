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

        private readonly int NumberOfBonesBuried;
        public override void PlaySound()
        {
            Console.WriteLine($"Имя {Name} Звук {Roar}количество закопанных косточек {NumberOfBonesBuried}");
        }
    }
}
