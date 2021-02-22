using System;

namespace EX6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            ///Part 1 sum
            Console.WriteLine($"Sum");
            Console.WriteLine($"{arraySum(A) }");
            Console.WriteLine($"{arraySum(B) }");
            Console.WriteLine($"{arraySum(C) }");

            ///////Part 2 Reverse
            Console.WriteLine($"Reverse");
            Console.WriteLine(string.Join(", ", arrayReverse(A)));
            Console.WriteLine(string.Join(", ", arrayReverse(B)));
            Console.WriteLine(string.Join(", ", arrayReverse(C)));

            ////////Part 3 rotate
            Console.WriteLine($"Rotate");
            Console.WriteLine(string.Join(", ", arrayRotate(0, 2, A)));
            Console.WriteLine(string.Join(", ", arrayRotate(1, 2, B)));
            Console.WriteLine(string.Join(", ", arrayRotate(0, 4, C)));

            /////Part 4 sort
            Console.WriteLine($"Sort");
            Console.WriteLine(string.Join(", ", arraySort(A)));
            Console.WriteLine(string.Join(", ", arraySort(B)));
            Console.WriteLine(string.Join(", ", arraySort(C)));


            ////Methods
            ///
            static int arraySum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;

            }

            static int[] arrayReverse(int[] arr)
            {
                int[] temp = new int[arr.Length];
                int j = 0;
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    temp[j] = arr[i];
                    j++;
                }
                return temp;

            }

            static int[] arrayRotate(int dir, int dist, int[] arr)
            {
                int[] shifted = new int[arr.Length];
                int length = arr.Length;
                if (dir == 1)
                {
                    for (int i = 0; i < length; i++)
                    {
                        int newIndex = i + dist;
                        newIndex = newIndex % length;
                        shifted[newIndex] = arr[i];
                    }
                 
                }

                else if (dir == 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        int newIndex = i - dist ;
                        newIndex = newIndex % length;

                        if (newIndex < 0)
                        {
                           newIndex = newIndex + length;
                        }
                        
                        shifted[newIndex] = arr[i];
                    }
                }

                    return shifted;
            }

            static int[] arraySort(int[] arr)
            {
                int n = arr.Length - 1;
                for (int i = 0; i < n; i++)
                {

                    for (int j = n; j > i; j--)
                    {
                        if (((IComparable)arr[j - 1]).CompareTo(arr[j]) > 0)
                        {
                            object temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                        }
                    }
                }
                return arr;
            }

        }
    }
}
