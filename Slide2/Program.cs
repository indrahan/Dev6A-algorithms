using System;

namespace Slide2
{
    class Program
    {
        static void printArray(int[] a)
        {
            foreach (int i in a)
            {
                System.Console.WriteLine(i.ToString() + " ");
            }
        }
        static int[] insertion_sort(int[] a)
        //from slide
        //doesntwork
        {
            for (int j = 0; j < a.Length; j++)
            {
                int key = a[j];
                int i = j - 1;
                while (i > 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i = i - 1;
                }
                a[i + 1] = key;
            }
            return a;
        }
        static int[] InsertionSort(int[] inputArray)
        //works
        //w3resource
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        static void Main(string[] args)
        {
            
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] unsortedlist = { 3, 8, 1, 6, 9, 2 };


            int[] sortedlist = InsertionSort(unsortedlist);

            printArray(sortedlist);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine("time: " + elapsedMs+"s");
        }
    }
}
