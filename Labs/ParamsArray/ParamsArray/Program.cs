using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
          // Console.WriteLine(util.Sum(null));
          // Console.WriteLine(util.Sum());
            Console.WriteLine(util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(util.Sum(50));
            Console.WriteLine(util.Sum(25, 100));
            Console.WriteLine(util.Sum(56, 89, 45));
            Console.WriteLine(util.Sum(44, 78, 87, 98));
            Console.WriteLine(util.Sum(34, 45, 78, 90, 12));
            Console.WriteLine(util.Sum(1, 2, 33, 4, 5, 6));
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
