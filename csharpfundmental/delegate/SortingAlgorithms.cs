using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate

{
    public delegate bool DelgateCompare<T>(T x, T y);

    internal static class SortingAlgorithms
    {


        public static void BubbleSort<T>(T[] array,DelgateCompare<T> referance)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (referance.Invoke(array[j], array[j + 1]))
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

            }
        }
        /*
        public static void BubbleSortAce(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (SortingConditional.CompareAce(array[j], array[j + 1]))
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

            }
        }
        public static void BubbleSortDce(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (SortingConditional.CompareDce(array[j] , array[j + 1]))
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

            }
        }
        public static void BubbleSortAce(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

            }
        }
        public static void BubbleSortDce(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }

            }
        }


        */
        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
