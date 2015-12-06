using System;
class Program
{
    static void Main()
    {
        //Problem 11. Binary search
        //Write a program that finds the index of given element in a sorted array of integers 
        //by using the Binary search algorithm.

        int[] arr = { 23, 42, 4, 55, 16, 8, 15 };

        int start = 0;
        int end = arr.Length;
        int middle = (start + end) / 2;

        Array.Sort(arr);

        int n = 3;
        int pivot = arr[n];

        while (true)
        {
            while (arr[n] < arr[middle])
            {
                end = middle;
                middle = (start + end) / 2;
                if (arr[n] == arr[middle])
                {
                    Console.WriteLine(arr[middle]);
                    break;
                }
            }

            while (arr[n] > arr[middle])
            {
                start = middle;
                middle = (start + end) / 2;
                if (arr[n] == arr[middle])
                {
                    Console.WriteLine(arr[middle]);
                    break;
                }
            }

            if (arr[n] == arr[middle])
            {
                Console.WriteLine(arr[middle]);
                break;
            }
        }
    }
}
