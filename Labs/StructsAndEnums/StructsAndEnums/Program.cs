#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Chapter 9 Lab");
            Month first = Month.January;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            first++;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            first += 10;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            first++;
            Console.WriteLine(first);
            Console.WriteLine((int)first);

            Month last = Month.Ethan;
            Console.WriteLine(last);
            last += 1;
            Console.WriteLine(last);

            Console.WriteLine("-------------------");
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2019, Month.December, 28);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
