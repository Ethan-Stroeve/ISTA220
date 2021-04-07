using System;

namespace Ex11Vector
{
    class Program : Vectorcalc
    {
        static void Main(string[] args)
        {
            RandomVector2d();
        }
    }
}

public class Vectorcalc
{
    public static double lowest { get; set; } = 100000;
    public static int lowX { get; set; }
    public static int lowY { get; set; }
    public static void RandomVector2d()
    {
        Random rnd = new Random();
        for (int i = 0; i < 100; i++)
        {
            int x = rnd.Next(100);
            int y = rnd.Next(100);
            double dist = TwoPointDistance(x, y);
            if (dist < lowest)
            {
                lowest = dist;
                lowX = x;
                lowY = y;
            }
        }
        Console.WriteLine($"Shortest distance is {lowest} the points are {lowX} and {lowY}");  
    }
    public static double TwoPointDistance(int x, int y)
    {
        double dist = Math.Sqrt((Math.Pow(x - x, 2)) + (Math.Pow(y - y, 2)));
        return dist;
    }
}
