using System;

public class Horse
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public Horse()
    {
        Horse kevin = new Horse("kevin", "Apples");
        kevin.Speak("1", "2");
        kevin.Eat("3");
        Console.ReadKey();

        Horse Phil = new Horse("Phil", "kale");
        kevin.Speak("1", "2");
        kevin.Eat("3");
        Console.ReadKey();

        Horse dave = new Horse("dave", "hay");
        kevin.Speak("1", "2");
        kevin.Eat("3");
        Console.ReadKey();

        Horse doug = new Horse("doug", "ice cream");
        kevin.Speak("1", "2");
        kevin.Eat("3");
        Console.ReadKey();
    }
    public Horse(string name,string food)
    {
        Name = name;
        Food = food;
    }
    public void Speak(string Parm, string rm)
    {
        Console.WriteLine($"I am a Horde my name is {Name} and i go neh");
    }
    public void Eat(string parm)
    {
        Console.WriteLine($"I like to eat {Food}");
    }
}
