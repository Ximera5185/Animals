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
            Animal [] Zoo = new Animal [3]
            {
              new Cat("Кошка", "Мяяяяу",false),
              new Dog("Собака", "Гав-Гав",15),
              new Frog("Лягушка", "Ква - Ква")
            };

            foreach (Animal animal in Zoo)
            {
                animal.PlaySound();
            }
            
            Console.ReadKey();
        }
    }
}
