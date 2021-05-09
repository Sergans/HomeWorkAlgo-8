using System;
using System.Collections.Generic;
namespace Task_8_1Sort
{
    class Program
    {
        static int[] BubleAr(int []a)
        {
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
            return a;
        }
        static List <int> BubleLs(List<int>a)
        {
            for (int j = 0; j < a.Count; j++)
            {
                for (int i = 0; i < a.Count - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int tmp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = tmp;

                    }
                }
            }
            return a;
        }
        static int[] BucketSort(int[]a)
        {
            List<int>[] bucket = new List<int>[a.Length];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();

            }
            int minValue = a[0];
            int maxValue = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minValue)
                    minValue = a[i];
                else if (a[i] > maxValue)
                    maxValue = a[i];
            }
            double numRange = maxValue - minValue;
            for (int i = 0; i < a.Length; ++i)
            {

                int bucketIndex = (int)Math.Floor((a[i] - minValue) / numRange * (bucket.Length - 1));


                bucket[bucketIndex].Add(a[i]);
            }
            for (int i = 0; i < bucket.Length; i++)
                BubleLs(bucket[i]);


            int idx = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                for (int j = 0; j < bucket[i].Count; j++)
                    a[idx++] = bucket[i][j];
            }
            return a;
        }

        static void Main(string[] args)
        {

            int[] a = { 1, 3, 6, 4, 2, 9, 5,7,12,1 };
            

            foreach (int b in BucketSort(a))
            {
                Console.WriteLine(b);
            }
        }
    }
}
