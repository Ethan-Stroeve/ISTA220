using System;

public class Ape
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public Ape()
    {
        Ape Rambo = new Ape("Rambo", "AHH", "Apple", "Ape");
        Rambo.Speak(Rambo.Type, Rambo.Name);
        Rambo.Eat(Rambo.Name);
        Console.ReadKey();

        Ape Coars = new Ape("Coars", "AHH", "Beer", "Ape");
        Coars.Speak(Coars.Type, Rambo.Name);
        Coars.Eat("test");
        Console.ReadKey();

        Ape Stella = new Ape("Stella", "AHH", "Pig", "Ape");
        Stella.Speak("1", "2");
        Stella.Eat("3");
        Console.ReadKey();

        Ape Rick = new Ape("Rick", "AHH", "Banana", "Ape");
        Rick.Speak("1", "2");
        Rick.Eat("3");
        Console.ReadKey();
    }
    public Ape(string name, string sound, string food, string type)
    {
        Name = name;
        Sound = sound;
        Food = food;
        Type = type;
    }
    public void Speak(string Parm, string rm)
    {
        Console.WriteLine($"I am a {Type} my name is {Name} and i go {Sound}");
    }
    public void Eat(string parm)
    {
        Console.WriteLine($"I like to eat {Food}");
    }
}
