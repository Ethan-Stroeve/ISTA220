using System;
using System.Collections.Generic;
using System.Text;

namespace MilUnit
{
    class Marines : Military
    {
        public override void Speciality()
        {
            Console.WriteLine("The Marines's speciality is amphibious assualts");
        }

        public override void unitType()
        {
            Console.WriteLine("Some Marine units are the Infantryman, Recon and Marsoc\n");
        }

        public override void mission()
        {
            Console.WriteLine("The Marine's role will be to assault the enemy nations island controlled terriotry to provide staging ground for the main amphibious assault on the main terriory");
        }

        public override void actions()
        {
            Console.WriteLine("The marines using help from the navy have succefully captured all enemy islands, staged and carried out the amphibious assualt and are pushing inland towards enemy objectives");
        }
    }
}
