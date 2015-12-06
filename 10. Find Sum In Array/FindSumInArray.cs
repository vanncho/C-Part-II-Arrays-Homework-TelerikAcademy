using System;
class FindSumInArray
{
    static void Main()
    {
        //Problem 10. Find sum in array
        //Write a program that finds in given array of integers a sequence of given sum S (if present).
        //Example:
        //array	                    S	    result
        //4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5

        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        
        int s = 11;
        int sum = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0} ",arr[k]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
    }
}
