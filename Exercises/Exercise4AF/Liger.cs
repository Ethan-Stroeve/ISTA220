using System;
 class Liger
 {
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public Liger()
    {
        Liger jon = new Liger("jon", "Roar", "people", "Liger");
        jon.Speak(jon.Type, jon.Name);
        jon.Eat(jon.Name);
        Console.ReadKey();

        Liger Tim = new Liger("Tim", "meow", "Water", "Liger");
        Tim.Speak(Tim.Type, Tim.Name);
        Tim.Eat(Tim.Name);
        Console.ReadKey();

        Liger Randy = new Liger("Randy", "roar", "carrots", "Liger");
        Randy.Speak(Randy.Type, Randy.Name);
        Randy.Eat(Randy.Name);
        Console.ReadKey();

        Liger Cartman = new Liger("Cartman", "Roar", "KFC", "Liger");
        Cartman.Speak(Cartman.Type, Cartman.Name);
        Cartman.Eat(Cartman.Name);
        Console.ReadKey();
    }
    public Liger(string name, string sound, string food, string type)
    {
        Name = name;
        Sound = sound;
        Food = food;
        Type = type;

    }
    public void Speak(string Parm, string rm)
    {
        Console.WriteLine($"I am a {Type} my name is {Name} and I go {Sound}");
    }
    public void Eat(string parm)
    {
        Console.WriteLine($"I like to eat {Food}");
    }
 }

