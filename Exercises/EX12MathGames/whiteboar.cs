using System;
using System.Collections.Generic;
using System.Text;

namespace EX12MathGames
{
    class whiteboar
    {
        public static int leftsideleft { get; set; }
        public static int leftsideright { get; set; }
        public static int rightsideleft { get; set; }
        public static int rightsideright { get; set; }
        public static void doflippyaddything(string a)
        {
            string ex = ">><><<>";
            int index = 0;

            foreach(var i in ex)
            {
                if(i == '<' || index < (double)ex.Length / 2 )
                {
                    leftsideright += 1;
                }
                if (i == '<' || index > (double)ex.Length / 2)
                {
                    rightsideright += 1;
                }
                if (i == '>' || index > (double)ex.Length / 2)
                {
                    rightsideleft += 1;
                }
                if (i == '>' || index < (double)ex.Length / 2)
                {
                    leftsideleft += 1;
                }
                index++;
            }
            if (leftsideleft < rightsideleft)
            {
                int addleftonleft = rightsideleft - leftsideleft;
                for (int i = 0; i < addleftonleft + 1; i++)
                {
                    //ex[0] += ">";
                    ex = ex.Insert(0, "<");
                }
            }
            //if (leftsideleft > rightsideleft)
            //{
            //    int addleftonright = leftsideleft - rightsideleft;
            //    for (int i = 0; i < addleftonright + 1; i++)
            //    {
            //        //ex[0] += ">";
            //        ex = ex.Insert(ex.Length, "<");
            //    }
            //}
            if (leftsideright > rightsideright)
            {
                int addrightonleft = leftsideright - rightsideright;
                for (int i = 0; i < addrightonleft -1; i++)
                {
                    //ex[ex.Length -1] += "<";
                    ex = ex.Insert(ex.Length, ">");
                }
            }
            //if (leftsideright < rightsideright)
            //{
            //    int addrightonright = rightsideright - leftsideright;
            //    for (int i = 0; i < addrightonright + 1; i++)
            //    {
            //        //ex[ex.Length - 1] += "<";
            //        ex = ex.Insert(ex.Length, ">");
            //    }
            //}
            Console.WriteLine(ex);
        }
    }
}
