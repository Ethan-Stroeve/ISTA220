using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab21Linq_queries
{
    class Answer
    {
        internal void Quiz01(int[] intArray)
        {
            foreach (var item in intArray)
                Console.Write($" {item}");
            Console.WriteLine("\n-------");
            var myEvens = intArray.Where(i => i % 2 == 0);
            foreach (var item in myEvens)
                Console.Write(item);
        }

        internal void Quiz02(int[] intArray)
        {
            foreach (var item in intArray)
                Console.Write($" {item}");
            Console.WriteLine("\n-------");
            var mypos = intArray.Where(i => i > 0);
            foreach (var item in mypos)
                Console.Write(item);
        }

        internal void Quiz03(int[] intArray)
        {
            foreach (var item in intArray)
                Console.Write($" {item}");
            Console.WriteLine("\n-------");
            var square = intArray.Select(i => i * i);
            foreach (var item in square)
                Console.Write(item);
        }

        internal void Quiz04(int[] intArray)
        {
            foreach (var item in intArray)
                Console.Write($" {item}");
            Console.WriteLine("\n-------");
            var count = intArray.GroupBy(i => i);
            foreach (var item in count)
                Console.Write($"{item.Key} has {item.Count()}");

        }
    }
}
