//using System;

//namespace DelLab
//{
//    //1. declare a delegate type
//    delegate void MyDel();

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Del20200329a");
//            //2. instantiate a delegate object
//            //either of the two lines below, a or b
//            //var md = new MyDel(someMethod); //a
//            MyDel md = someMethod; //b
//            //3. call the delegate
//            md();
//        }

//        static void someMethod()
//        {
//            Console.WriteLine("This is the body of the method named \"someMethod()\"");
//        }
//    }
//}

//using System;

//namespace DelLab02
//{
//    class Program
//    {
//        delegate int IntDel(int a, int b);

//        static int Add(int a, int b) => a + b;
//        static int Sub(int a, int b) => a - b;
//        static int Prod(int a, int b) => a * b;
//        static int Mod(int a, int b) => a % b;
//        static int Pow(int a, int b) => (int)Math.Pow(a, b);

//        private static (int a, int b) GetInput()
//        {
//            Console.WriteLine("Enter an integer for the left hand side");
//            int a, b;
//            int.TryParse(Console.ReadLine(), out a);
//            Console.WriteLine("Enter an integer for the right hand side");
//            int.TryParse(Console.ReadLine(), out b);
//            return (a, b);
//        }

//        static void Main(string[] args)
//        {

//            Console.WriteLine("Hello Del20200327c!");
//            (int a, int b) = GetInput();

//            Console.WriteLine("=======using a method call=========");
//            int result = Add(a, b);
//            Console.WriteLine(result);
//            result = Sub(a, b);
//            Console.WriteLine(result);
//            result = Prod(a, b);
//            Console.WriteLine(result);
//            result = Mod(a, b);
//            Console.WriteLine(result);
//            result = Pow(a, b);
//            Console.WriteLine(result);

//            Console.WriteLine("=======using a delegate=========");
//            IntDel idel = new IntDel(Add);
//            Console.WriteLine(idel(a, b));
//            idel = Sub;
//            Console.WriteLine(idel(a, b));
//            idel = Prod;
//            Console.WriteLine(idel(a, b));
//            idel = Mod;
//            Console.WriteLine(idel(a, b));
//            idel = Pow;
//            Console.WriteLine(idel(a, b));
//        }
//    }
//}
//using System;

//namespace DelLab03
//{
//    class Program
//    {
//        public delegate void PrintPresDel(President p);
//        public delegate string GetPresDel();

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Delegate Lab 03");
//            President first = new President
//            {
//                FirstName = "George",
//                LastName = "Washington",
//                State = "Virginia",
//                Party = "none",
//                Year = 1788
//            };
//            Console.WriteLine("========= three different ways =========");
//            first.PrintFirstName(first);
//            Console.WriteLine(first.GetFirstName());
//            Console.WriteLine(first.FirstName);
//            Console.WriteLine(first.FirstName.GetType());

//            Console.WriteLine("=========non delegate demostration =========");
//            Console.WriteLine(first.FirstName);
//            Console.WriteLine(first.LastName);
//            Console.WriteLine(first.State);
//            Console.WriteLine(first.Party);
//            Console.WriteLine(first.Year);
//            Console.WriteLine(first.ToString());

//            Console.WriteLine("=========first delegate demostration =========");
//            GetPresDel myFirstDel = new GetPresDel(first.GetFirstName);
//            Console.WriteLine(myFirstDel());
//            myFirstDel = first.GetLastName;
//            Console.WriteLine(myFirstDel());
//            myFirstDel = first.GetState;
//            Console.WriteLine(myFirstDel());
//            myFirstDel = first.GetParty;
//            Console.WriteLine(myFirstDel());
//            myFirstDel = first.GetYear;
//            Console.WriteLine(myFirstDel());
//            myFirstDel = first.ToString;
//            Console.WriteLine(myFirstDel());

//            Console.WriteLine("=========second delegate demostration =========");
//            PrintPresDel mySecondDel = new PrintPresDel(first.PrintFirstName);
//            mySecondDel(first);
//            mySecondDel = new PrintPresDel(first.PrintLastName);
//            mySecondDel(first);
//            mySecondDel = new PrintPresDel(first.PrintState);
//            mySecondDel(first);
//            mySecondDel = new PrintPresDel(first.PrintParty);
//            mySecondDel(first);
//            mySecondDel = new PrintPresDel(first.PrintYear);
//            mySecondDel(first);
//            mySecondDel = new PrintPresDel(first.PrintString);
//            mySecondDel(first);
//        }
//    }
//    public class President
//    {

//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string State { get; set; }
//        public string Party { get; set; }
//        public int Year { get; set; }

//        public override string ToString()
//        {
//            return $"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.";
//        }

//        //Get takes no arguments ahd returns a string
//        public string GetFirstName() => FirstName;
//        public string GetLastName() => LastName;
//        public string GetState() => State;
//        public string GetParty() => Party;
//        public string GetYear() => Year.ToString();

//        //print takes a President argument and returns void
//        public void PrintFirstName(President p) => Console.WriteLine(p.FirstName);
//        public void PrintLastName(President p) => Console.WriteLine(p.LastName);
//        public void PrintState(President p) => Console.WriteLine(p.State);
//        public void PrintParty(President p) => Console.WriteLine(p.Party);
//        public void PrintYear(President p) => Console.WriteLine(p.Year.ToString());

//        public void PrintString(President p) =>
//            Console.WriteLine($"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.");
//    }
//}
//using System;

//namespace EventsLabStarter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("At a lonely outpost in far off mountains...\n");

//            Attacker a = new Attacker();
//            a.Attack("snipers");

//            Defender d = new Defender();
//            d.ReturnFire("rifle fire");

//            a.Attack("full auto rifle fire");
//            d.ReturnFire("squad automatic weapon");

//            string attackType = "heavy machine guns";
//            a.Attack(attackType);
//            d.CallForHelp(attackType);

//            attackType = "moms bringing reinforcements in trucks";
//            a.Attack(attackType);
//            d.CallForHelp(attackType);

//            attackType = "armored vehicles";
//            a.Attack(attackType);
//            d.CallForHelp(attackType);

//            attackType = "SCUD missles";
//            a.Attack(attackType);
//            d.CallForHelp(attackType);
//        }
//    }

//    class Attacker
//    {
//        public void Attack(string s)
//        {
//            Console.WriteLine($"A. Enemy attacks with {s}");
//        }
//    }

//    public class Defender
//    {
//        public void ReturnFire(string s)
//        {
//            Console.WriteLine($"D. Defender responds with {s}\n");
//        }

//        public void CallForHelp(string weapon)
//        {
//            Console.WriteLine($"D. Help, we are under attack by {weapon}");

//            if (weapon == "heavy machine guns")
//                Responder.MaDeuce(weapon);
//            if (weapon == "moms bringing reinforcements in trucks")
//                Responder.Predator(weapon);
//            if (weapon == "armored vehicles")
//                Responder.WartHog(weapon);
//            if (weapon == "SCUD missles")
//                Responder.BUFF(weapon);
//        }
//    }

//    public class Responder
//    {
//        public static void MaDeuce(string w)
//        {
//            Console.WriteLine($"Ma Deuce: 50 Cal opens up and smokes the Sons of Witches shooting {w}. Rat..tat...tat...\n");
//        }
//        public static void Predator(string w)
//        {
//            Console.WriteLine($"Predator: We just hellfired those mother trucking {w}. kaBOOM\n");
//        }
//        public static void WartHog(string w)
//        {
//            Console.WriteLine($"Wart Hog: We just shot the shift out of the {w} with our Gatling Gun. Zzzzzzip\n");
//        }
//        public static void BUFF(string w)
//        {
//            Console.WriteLine($"BUFF: The Big Ugly Fat Fuggers just obliterated the {w}. SHOCK AND AWE!!!\n");
//        }
//    }
//}
using System;

namespace EventsLabComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("At a lonely outpost in far off mountains...\n");

            Attacker a = new Attacker();
            a.Attack("snipers");

            Defender d = new Defender();
            d.ReturnFire("rifle fire");

            a.Attack("full auto rifle fire");
            d.ReturnFire("squad automatic weapon");

            //7. subscribe to UnderAttackEvent
            d.UnderAttackEvent += Responder.HelpDefender;
            string attackType = "heavy machine guns";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "moms bringing reinforcements in trucks";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "armored vehicles";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "SCUD missles";
            a.Attack(attackType);
            d.CallForHelp(attackType);
        }
    }

    class Attacker
    {
        public void Attack(string s)
        {
            Console.WriteLine($"A. Enemy attacks with {s}");
        }
    }

    public class Defender
    {
        //1. declare event handler
        public event EventHandler<string> UnderAttackEvent;

        //2. create get help method
        private void RaiseGetHelp(string weapon)
        {
            UnderAttackEvent?.Invoke(this, weapon);
        }

        public void CallForHelp(string weapon)
        {
            Console.WriteLine($"D. Help, we are under attack by {weapon}");
            //3. create call help method
            RaiseGetHelp(weapon);
            //    if (v == "heavy machine guns")
            //        Responder.MaDeuce();
            //    if (v == "moms bringing reinforcements in trucks")
            //        Responder.Predator();
            //    if (v == "armored vehicles")
            //        Responder.WartHog();
            //    if (v == "SCUD missles")
            //        Responder.BUFF();
        }

        public void ReturnFire(string s)
        {
            Console.WriteLine($"D. Defender responds with {s}\n");
        }
    }

    public static class Responder
    {
        //5. add helper method 
        public static void HelpDefender(object sender, string weapon)
        {
            if (weapon == "heavy machine guns")
                MaDeuce(weapon);
            else if (weapon == "moms bringing reinforcements in trucks")
                Predator(weapon);
            else if (weapon == "armored vehicles")
                WartHog(weapon);
            else if (weapon == "SCUD missles")
                BUFF(weapon);
        }
        //6. change public methods to private
        private static void MaDeuce(string w)
        {
            Console.WriteLine($"Ma Deuce: 50 Cal opens up and smokes the Sons of Witches shooting {w}. Rat..tat...tat...\n");
        }
        private static void Predator(string w)
        {
            Console.WriteLine($"Predator: We just hellfired those mother trucking {w}. kaBOOM\n");
        }
        private static void WartHog(string w)
        {
            Console.WriteLine($"Wart Hog: We just shot the shift out of the {w} with our Gatling Gun. Zzzzzzip\n");
        }
        private static void BUFF(string w)
        {
            Console.WriteLine($"BUFF: The Big Ugly Fat Fuggers just obliterated the {w}. SHOCK AND AWE!\n");
        }
    }
}