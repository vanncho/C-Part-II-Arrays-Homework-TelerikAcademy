using System;
class Program
{
    static void Main()
    {
        //Problem 8. Maximal sum
        //Write a program that finds the sequence of maximal sum in given array.
        //Example:
        //input	                                        result
        //2, 3, -6, -1, 2, -1, 6, 4, -8, 8	            2, -1, 6, 4
        //Can you do it with only one loop (with single scan through the elements of the array)?

        //int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //
        //int currSum = arr[0];
        //int maxSum = arr[0];
        //
        //int start = 0;
        //int startTemp = 0;
        //int end = 0;
        //
        //for (int i = 1; i < arr.Length; i++)
        //{
        //    currSum += arr[i];
        //    if (currSum < arr[i])
        //    {
        //        currSum = arr[i];
        //        startTemp = i;
        //    }
        //    if (currSum > maxSum)
        //    {
        //        maxSum = currSum;
        //        start = startTemp;
        //        end = i;
        //    }
        //}
        //
        //Console.Write("The sequence with maximal sum is: ");
        //for (int i = start; i <= end; i++)
        //{
        //    Console.Write("{0} ", arr[i]);
        //}
        //Console.WriteLine();


        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int currSum = arr[0];
        int maxSum = arr[0];

        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            currSum += arr[i];
            if (currSum < arr[i])
            {
                currSum = arr[i];
                startTemp = i;
            }
            if (currSum > maxSum)
            {
                maxSum = currSum;
                start = startTemp;
                end = i;
            }
        }

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
