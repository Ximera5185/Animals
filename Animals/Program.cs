using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Cat cat = new Cat("Кошка", "Мяяяяу");
            Dog dog = new Dog("Собака","Гав-Гав");

            cat.PlayAnimalSound(cat.Name, cat.Roar);

            dog.PlayAnimalSound(dog.Name, dog.Roar);

            Console.ReadKey();
        }
    }
}
