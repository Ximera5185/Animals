using System;

namespace Animals
{
    internal class Animal
    {
        public Animal(string name, string roar)
        {
            Name = name;
            Roar = roar;
        }

        public string Name { private set; get; }
        public string Roar { private set; get; }

      virtual public void PlaySound(string name,string roar)
        {
            Console.WriteLine($"Имя {name} Звук {roar}");
        }
    }
}
