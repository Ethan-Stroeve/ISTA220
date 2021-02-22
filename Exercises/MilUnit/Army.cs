using System;
using System.Collections.Generic;
using System.Text;

namespace MilUnit
{
    class Army : Military
    {
        public override void Speciality()
        {
            Console.WriteLine("The Army's speciality is Airborne and ground warfare");
        }

        public override void unitType()
        {
            Console.WriteLine("Some army units are the infantryman, Rangers and special forces\n");
        }
        public override void mission()
        {
            Console.WriteLine("The Army's role will be to stage a ground assualt from a nearby allies base while simultanously conducting airborne and special operations to disrupts the enemy");
        }

        public override void actions()
        {
            Console.WriteLine("The army using mechanized and mobile infantry have breached the enemy nation state through tough ground warfare");
        }
    }
}
