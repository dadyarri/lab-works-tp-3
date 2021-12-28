using System;

namespace lw9_1
{
    class Program
    {
        static void Main()
        {
            for (long count = 100; count <= 1000000; count *= 10)
            {
                int[] arr = _generateRandomArray(count);

                int[] copy1 = _copyArray(arr);

                DateTime t1= DateTime.Now;
                Sort.SequentialQuickSort(copy1);
                _printInfo("sequential", count, DateTime.Now - t1);

                int[] copy2 = _copyArray(arr);
                
                DateTime t2 = DateTime.Now;
                Sort.ParallelQuickSort(copy2);
                _printInfo("parallel", count, DateTime.Now - t2);
            }
            Console.WriteLine("finish");
            Console.ReadLine();
        }

        private static int[] _generateRandomArray(long length)
        {
            int[] arr = new int[length];
            Random rand = new();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            return arr;
        }

        private static int[] _copyArray(int[] arr)
        {
            int[] copy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }

            return copy;
        }

        private static void _printInfo(string type, long count, TimeSpan st)
        {
            Console.WriteLine($"sorting with {type} quick sort, elems: {count}, time elapsed: {st}");
        }
    }
}
