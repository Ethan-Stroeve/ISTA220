using System;

public class Pig
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public Pig()
    {
        Pig Piggy = new Pig("Piggy", "Banana");
        Piggy.Speak("1", "2");
        Piggy.Eat("3");
        Console.ReadKey();

        Pig Piglet = new Pig("Piggy", "Banana");
        Piglet.Speak("1", "2");
        Piglet.Eat("3");
        Console.ReadKey();

        Pig hank = new Pig("hank", "Banana");
        hank.Speak("1", "2");
        hank.Eat("3");
        Console.ReadKey();

        Pig roger = new Pig("Piggy", "Banana");
        roger.Speak("1", "2");
        roger.Eat("3");
        Console.ReadKey();
    }
    public Pig(string name, string food)
    {
        Name = name;
        Food = food;

    }
    public void Speak(string Parm, string rm)
    {
        Console.WriteLine($"I am a Pig my name is {Name} and i go Oink");
    }
    public void Eat(string parm)
    {
        Console.WriteLine($"I like to eat {Food}");
    }
}
