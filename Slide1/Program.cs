using System;

namespace Slide1
{

    class Program
    {
        static int sequential_search(int[] list, int find)
        //also called linear search
        //Simplest, but least efficient
        //Examines each element SEQUENTIALLY, from the first index to the last
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == find)
                {
                    return i;
                }
            }
            return -1;
        }
        static int binary_search(int[] list, int find)
        //standard search algorithm for a SORTED sequence
        //*requires the order of elements 
        //divide the sequence in two and FOCUSES on the half which could contain the element
        {
            int low = 0;
            int high = list.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (find < list[middle])
                {
                    return high = middle - 1;
                }
                else if (find > list[middle])
                {
                    return low = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        static int binary_search_re(int[] list, int low, int high, int find)
        //RECURSIVE
        {

            if (low > high)
            {
                return -1;
            }
            int middle = (low + high) / 2;
            if (list[middle] > find)
            {
                return binary_search_re(list, low, middle - 1, find);
            }
            else if (list[middle] < find)
            {
                return binary_search_re(list, middle + 1, high, find);
            }
            else
            {
                return middle;
            }
        }



        static void Main(string[] args)
        {
            int[] listone = { 1, 4, 7, 8, 9, 12, 15, 16, 20, 21, 25 };
            int[] listtwo = { 2, 4, 7, 9, 10, 22, 27, 50, 77, 88, 100, 123, 155, 188 };

            System.Console.WriteLine("found on index: " + sequential_search(listone, 9));
            System.Console.WriteLine("found on index: " + binary_search_re(listtwo, 0, listtwo.Length - 1, 155));
            System.Console.WriteLine("found on index: " + binary_search(listtwo, 27));
        }
    }

}
