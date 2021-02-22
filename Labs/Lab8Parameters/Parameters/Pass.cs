using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(int param)
        {
            param = 42;
            Console.WriteLine($"    in value param {param}");
        }
        public static void Value2(ref int param2)
        {
            param2 = 42;
            Console.WriteLine($"    in value2 param2 {param2}");
        }
        internal static int setteri()
        {
            return 99;
        }
        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
        public static void Reference2(WrappedInt param)
        {
            Console.WriteLine("Hello world");
        }
        public static void Reference3(WrappedInt param)
        {
            param.isTrue = true;
        }
    }
}
