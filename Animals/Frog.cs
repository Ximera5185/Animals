using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Frog: Animal
    {
        public Frog(string name, string roar) :base (name,roar) 
        {
            
        }

        public void PlaySound()
        {
            base.PlaySound(Name, Roar);
        }
    }
}
