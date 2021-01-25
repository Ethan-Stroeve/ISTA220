using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            String name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }   //ends Main Method
    }   //ends class Program
}   //ends namespace block