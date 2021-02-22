#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int teri = 0;
            Console.WriteLine(teri);
            Pass.Value(teri);
            Console.WriteLine(teri);
            teri = Pass.setteri();
            Console.WriteLine(teri); ;
            Console.ReadKey();

            Console.WriteLine("--------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Pass.Value2(ref i);
            Console.WriteLine(i);

            Console.ReadLine();

            Console.WriteLine("---------");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            
            Console.WriteLine(wi.IdontKnow);
            Pass.Reference2(wi);
            Console.WriteLine(wi.IdontKnow);
            
            Console.WriteLine(wi.isTrue);
            Pass.Reference3(wi);
            Console.WriteLine(wi.isTrue);
            Console.ReadKey();

         
        }

 

        static void Main(string[] args)
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
