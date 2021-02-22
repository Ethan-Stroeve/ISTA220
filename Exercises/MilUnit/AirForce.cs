using System;
using System.Collections.Generic;
using System.Text;

namespace MilUnit
{
    class AirForce : Military
    {
        public override void Speciality()
        {
            Console.WriteLine("The Airforce's speciality is control of airspace");
        }

        public override void unitType()
        {
            Console.WriteLine("Some Airforce's units are fighter jets, spy planes, helicopters\n");
        }
        public override void mission()
        {
            Console.WriteLine("The airforce role will first be to gain air superiority, then rain fire from above");
        }

        public override void actions()
        {
            Console.WriteLine("The airfore superior technology and planning have gained air dominance and began targeting ground targets ");
        }

    }

}
