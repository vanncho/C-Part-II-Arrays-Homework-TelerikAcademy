using System;
class FrequentNumber
{
    static void Main()
    {
        //Problem 9. Frequent number
        //Write a program that finds the most frequent number in an array.
        //Example:
        //input	                                        result
        //4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3         4 (5 times)

        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

        int number = 0;
        int currCount = 1;
        int maxCount = int.MinValue;

        Array.Sort(arr);

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currCount++;
            }
            else
            {
                currCount = 1;
            }
            if (currCount > maxCount)
            {
                maxCount = currCount;
                number = arr[i];
            }
        }
        Console.WriteLine("{0} ({1} times)", number, maxCount);
    }
}
