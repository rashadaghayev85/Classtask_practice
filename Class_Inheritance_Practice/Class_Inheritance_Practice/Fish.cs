using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Practice
{
    internal class Fish:Animal
    {
        public string color;
        public Fish():base("just animal")
        {
            Console.WriteLine("fish constructor");
        }
    }
}
