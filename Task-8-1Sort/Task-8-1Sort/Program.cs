using System;

namespace Task_8_1Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 6, 4, 2, 9, 5,7,12,1 };
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int tmp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = tmp;

                    }
                }
            }
            foreach (int b in a)
                Console.WriteLine(b);
        }
    }
}
