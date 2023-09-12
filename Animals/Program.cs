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
            Animals Cat = new Animals();

            Cat.PlayAnimalSound();

            Console.ReadKey();
        }
    }
}
