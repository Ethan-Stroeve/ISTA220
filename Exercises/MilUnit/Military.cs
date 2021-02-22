using System;
using System.Collections.Generic;
using System.Text;

namespace MilUnit
{
    class Military
    {
        public void budget(string branch,string price)
        {
            Console.WriteLine($"The Budget for {branch} is {price}");
        }

        public virtual void Speciality()
        {
            Console.WriteLine("The military is responsible for fighting a nations war and defending it's borders");
        }

        public virtual void unitType()
        {
            Console.WriteLine("The Military is made of many different units all with differnt names\n");
        }

        public virtual void mission()
        {
            Console.WriteLine("After highten tensions with a military state boiled over to violent actions, the military has been tasked with defeating the enemy nation and seizing its terriotry");
        }

        public virtual void actions()
        {
            Console.WriteLine("The enemy nation state has been defeated");
        }
    }
}
