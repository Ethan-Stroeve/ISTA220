using System;

namespace EX10NumConversion
{
    class Program : Convert
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer to convert: ");
            string tryinput = Console.ReadLine();
            Int32.TryParse(tryinput, out int input);
            Console.Write("Please choose a base to convert from [2] [8] [10] [16]: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"[Number: {input}] [Base: {baseNum}]");
            Console.WriteLine("----------------------");

            int result;
            string hexResult;

            if (baseNum == 2)
            {
                result = BinToDec(input);
                Console.WriteLine($"Decimal conversion is {result}");
                result = BinToOct(input);
                Console.WriteLine($"Octal conversion is {result}");
                hexResult = BinToHex(input);
                Console.WriteLine($"Hex conversion is {hexResult}");
            }
            else if (baseNum == 8)
            {
                result = OctToBin(input);
                Console.WriteLine($"Binary conversion is {result}");
                result = OctToDec(input);
                Console.WriteLine($"Decimal conversion is {result}");
                hexResult = OctToHex(input);
                Console.WriteLine($"Hex conversion is {hexResult}");
            }
            else if (baseNum == 10)
            {
                result = DecToBin(input);
                Console.WriteLine($"Binary conversion is {result}");
                result = DecToOct(input);
                Console.WriteLine($"Octal conversion is {result}");
                hexResult = DecToHex(input);
                Console.WriteLine($"Hex conversion is {hexResult}");
            }
            else if (baseNum == 16)
            {
                result = HexToBin(tryinput);
                Console.WriteLine($"Binary conversion is {result}");
                result = HexToOct(tryinput);
                Console.WriteLine($"Octal conversion is {result}");
                result = HexToDec(tryinput);
                Console.WriteLine($"Decimal conversion is {result}");
            }
            else
            {
                Console.WriteLine("Error in base to convert from");
            }
        }
    }

    class Convert
    {
        static int Answer { get; set; }
        static int A;
        static int B;

        /// From Binary Conversion ///
        public static int BinToOct(int input)
        {
            
            int input2 = BinToDec(input);
            Answer = DecToOct(input2);
            return Answer;
        }

        public static int BinToDec(int input)
        {
            double power = 0;
            Answer = 0;

            while (input > 0)
            {
                A = input % 10;
                B = (int)(A * Math.Pow(2, power));
                Answer += B;
                power++;
                input = input / 10;
            }
            return Answer;
        }

        public static string BinToHex(int input)
        {
            int input2 = BinToDec(input);
            string Answer1 = DecToHex(input2);
            return Answer1;
        }

        /// From Octal Conversion ///
        public static int OctToBin(int input)
        {
            int factor = 1;
            int Answer1 = 0;

            while (input > 0)
            {
                int a2 = input % 10;
                int b1 = DecToBin((int)a2);
                Answer1 += b1 * factor;
                factor *= 1000;
                input = input / 10;
            }
            return (int)Answer1;
        }

        public static int OctToDec(int input)
        {
            int _base = 1;

            while (input > 0)
            {
                A = input % 10;
                input = input / 10;
                Answer = A * _base;
                _base = _base * 8;
            }
            return (int)Answer;
        }

        public static string OctToHex(int input)
        {
            int input2 = OctToDec(input);
            string Answer1 = DecToHex(input2);
            return Answer1;
        }

        /// From Decimal Conversion ///
        public static int DecToBin(int input)
        {
            int factor = 1;

            while (input > 0)
            {
                A = input % 2;
                input = input / 2;
                Answer += A * factor;
                factor *= 10;
            }
            return (int)Answer;
        }

        public static int DecToOct(int input)
        {
            int factor = 1;
            Answer = 0;

            while (input > 0)
            {
                A = input % 8;
                input = input / 8;
                Answer += A * factor;
                factor *= 10;
            }
            return (int)Answer;
        }


        public static string DecToHex(int input)
        {
            char[] hexNum = new char[100];
            int i = 0;

            while (input > 0)
            {
                A = input % 16;
                if (A < 10)
                {
                    hexNum[i] = (char)(A + 48);
                    i++;
                }
                else if (A >= 10)
                {
                    hexNum[i] = (char)(A + 55);
                    i++;
                }
                input = input / 16;
            }
            Array.Reverse(hexNum);
            string str = new string(hexNum);
            return str;
        }

        /// From Hex Conversion ///

        public static int HexToBin(string input)
        {
            int input2 = HexToDec(input);
            Answer = DecToBin(input2);
            return Answer;
        }


        public static int HexToOct(string input)
        {
            int input2 = HexToDec(input);
            Answer = DecToOct(input2);
            return Answer;
        }


        public static int HexToDec(string input)
        {
            int len = input.Length;
            int base1 = 1;

            int dec_val = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    dec_val += (input[i] - 48) * base1;
                    base1 = base1 * 16;
                }

                else if (input[i] >= 'A' && input[i] <= 'F')
                {
                    dec_val += (input[i] - 55) * base1;
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }
    }
}