using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class_Inheritance_Practice
{
    internal class Animal
    {
        public int id;
        public string name;
       // public Animal(string text)
       // {
            Console.WriteLine("sssss");
       // }
        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
