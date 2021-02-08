using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        public static object Public { get; private set; }

        static void Main(string[] args)
        {
            Formulas1();
            Formulas2();
            Formulas4();
        }
        public static void Formulas1()
        {
            try
            {
               //Radius and Circumference
               Console.WriteLine("Part 1");
               Console.WriteLine("Enter an integer for the radius");
               int radius = int.Parse(Console.ReadLine());
                if (radius > 0)
                {
                  double circumference = (2 * Math.PI * radius);
                  Console.WriteLine($"The Circumference is {circumference}");
                  double area = (Math.PI * Math.Pow(radius, 2));
                  Console.WriteLine($"the area is {area}");
                  Console.WriteLine("Part 2");
                  double volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3) / 2;
                  Console.WriteLine($"The volume is {volume}");
                }
                else 
                {  
                  throw new IndexOutOfRangeException();
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Format");
                Formulas1();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Must be positive number");
                Formulas1();
            }
            
        }
       public static void Formulas4()
       {
           try
           {
             // Quadratic Formula
             Console.WriteLine("Part 4");
             Console.WriteLine("Enter 3 numbers for the quadratic formula");
             float I1 = float.Parse(Console.ReadLine());
             float I2 = float.Parse(Console.ReadLine());
             float I3 = float.Parse(Console.ReadLine());
             float denom = 2 * I1;
             var x1 = (I2 * -1) + Math.Sqrt(Math.Pow(I2, 2) - (4 * I1 * I3));
             var x2 = (I2 * -1) - Math.Sqrt(Math.Pow(I2, 2) - (4 * I1 * I3));
             Console.WriteLine($"The positive solution is {x1 / denom}");
             Console.WriteLine($"The negative solution is {x2 / denom}");
           }
           catch (FormatException)
           {
             Formulas4();
           }
     

       }


        public static void Formulas2()
        {
            try
            {
                //Heron's Formula
                Console.WriteLine("Part 3");
                Console.WriteLine("Enter 3 numbers for Heron's Formula");
                float I1H = float.Parse(Console.ReadLine());
                if (I1H > 0)
                {
                    float I2H = float.Parse(Console.ReadLine());
                    if (I2H > 0)
                    {
                     float I3H = float.Parse(Console.ReadLine());
                        if (I3H > 0)
                        {
                            double p = (I1H + I2H + I3H);
                            double p1 = p / 2;
                            double Tarea = Math.Sqrt(p1 * (p1 - I1H) * (p1 - I2H) * (p1 - I3H));
                            Console.WriteLine($"The area is {Tarea}");
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Must enter valid number");
                Formulas2();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Must be positive number");
                Formulas2();
            }
            finally
            {
                Console.WriteLine("okay");
            }

        }
    }
}
