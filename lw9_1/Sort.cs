using System;
using System.Threading.Tasks;

namespace lw9_1
{
    public class Sort
    {
        private static readonly int Threshold = 150;

        public static void SequentialQuickSort(int[] array)
        {
            SequentialQuickSort(array, 0, array.Length);
        }

        static void SequentialQuickSort(int[] array, int from, int to)
        {
            if (to - from <= Threshold)
            {
                InsertionSort(array, from, to);
            }
            else
            {
                int pivot = from + (to - from) / 2;
                pivot = _partition(array, from, to, pivot);
                SequentialQuickSort(array, from, pivot);
                SequentialQuickSort(array, pivot + 1, to);
            }
        }

        public static void ParallelQuickSort(int[] array)
        {
            ParallelQuickSort(array, 0, array.Length,
                (int) Math.Log(Environment.ProcessorCount, 2) + 4);
        }

        static void ParallelQuickSort(int[] array, int from, int to, int depthRemaining)
        {
            if (to - from <= Threshold)
            {
                InsertionSort(array, from, to);
            }
            else
            {
                int pivot = from + (to - from) / 2;
                pivot = _partition(array, from, to, pivot);
                if (depthRemaining > 0)
                {
                    Parallel.Invoke(
                        () => ParallelQuickSort(array, from, pivot, depthRemaining - 1),
                        () => ParallelQuickSort(array, pivot + 1, to, depthRemaining - 1));
                }
                else
                {
                    ParallelQuickSort(array, from, pivot, 0);
                    ParallelQuickSort(array, pivot + 1, to, 0);
                }
            }
        }

        public static void InsertionSort(int[] array, int from, int to)
        {
            for (int i = from + 1; i < to; i++)
            {
                var a = array[i];
                int j = i - 1;

                while (j >= from && array[j].CompareTo(a) == -1)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = a;
            }
        }

        private static void _swap(int[] array, int i, int j)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        private static int _partition(int[] array, int from, int to, int pivot)
        {
            int arrayPivot = array[pivot];
            _swap(array, pivot, to - 1);
            int newPivot = from;
            for (int i = from; i < to - 1; i++)
            {
                if (array[i].CompareTo(arrayPivot) != -1)
                {
                    _swap(array, newPivot, i);
                    newPivot++;
                }
            }

            _swap(array, newPivot, to - 1);
            return newPivot;
        }
    }
}
