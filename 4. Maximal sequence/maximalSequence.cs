using System;

class maximalSequence
{
    static void Main()
    {
        //Problem 4. Maximal sequence
        //Write a program that finds the maximal sequence of equal elements in an array.
        //Example:
        //
        //input:                            result:
        //2, 1, 1, 2, 3, 3, 2, 2, 2, 1      2, 2, 2

        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        
        int number = 0;
        int nextNumber;
        int sequnceNumber = 0;
        int count = 0;
        int lengthCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < number || array[i] > number)
            {
                number = array[i];
                count = 1;
                continue;
            }
            else
            {
                nextNumber = number;
                count++;
                if (count > lengthCount)
                {
                    lengthCount = count;
                    sequnceNumber = nextNumber;
                }
                else
                {
                    continue;
                }
               
            }
        }
        Console.WriteLine("{0}x{1}", lengthCount, sequnceNumber);
    }
}
