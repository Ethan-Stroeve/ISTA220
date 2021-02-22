using System;

namespace MilUnit
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 06 Inheritance");

            Military mil = new Military();
            mil.budget("Military", "610 billion");
            mil.Speciality();
            mil.unitType();

            Army army = new Army();
            army.budget("Army", "31 percent");
            army.Speciality();
            army.unitType();

            AirForce airforce = new AirForce();
            airforce.budget("Airforce", "22 percent");
            airforce.Speciality();
            airforce.unitType();

            Marines marine = new Marines();
            marine.budget("Marines", "4 percent");
            marine.Speciality();
            marine.unitType();

            mil.mission();
            army.mission();
            airforce.mission();
            marine.mission();

            Console.WriteLine();

            airforce.actions();
            marine.actions();
            army.actions();
            mil.actions();
                

        }
    }
}
