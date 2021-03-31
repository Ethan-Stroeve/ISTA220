using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab19BinaryTree;

namespace EnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);

            foreach (int item in tree1)
            {
                Console.WriteLine($"{item}");
            }

            Tree<int> Ethan = new Tree<int>(' ');
            tree1.Insert('E');
            tree1.Insert('t');
            tree1.Insert('h');
            tree1.Insert('a');
            tree1.Insert('n');


            foreach (int item in Ethan)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
