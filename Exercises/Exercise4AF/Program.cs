using System;
using System.Media;

namespace Exercise4AF
{
    class farmanimal
    {

        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Welcome to my animal farm press any key to cycle through the animals");
                Console.ReadKey();

                //////// starts Liger
                Liger start = new Liger();

                //////// starts Ape
                Ape Init = new Ape();

                /////// starts Pig
                Pig Init1 = new Pig();

                /////// starts Horse
                Horse Init2 = new Horse();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Made try again");
                Main(args);
            }
            
            

        }
    }
   
}
