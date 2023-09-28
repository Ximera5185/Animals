using System;

namespace Animals
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Animal [] Zoo = new Animal [3]
            {
              new Cat("Кошка", "Мяяяяу",true),
              new Dog("Собака", "Гав-Гав",15),
              new Frog("Лягушка", "Ква - Ква")
            };

            foreach (Animal animal in Zoo)
            {
                animal.PlaySound(animal.Name,animal.Roar);
            }
            
            Console.ReadKey();
        }
    }
}
