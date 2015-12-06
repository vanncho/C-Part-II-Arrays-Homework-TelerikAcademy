using System;
class maximalIncreasingSequence
{
    static void Main()
    {
        //Problem 5. Maximal increasing sequence
        //Write a program that finds the maximal increasing sequence in an array.
        //
        //Example:
        //input	                        result
        //3, 2, 3, 4, 2, 2, 4	        2, 3, 4

        int[] array = { 3, 2, 3, 4, 2, 4;
        int currentCount = 1;
        int maxCount = 0;
        int startIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i != 0)
            {
                if (array[i] > array[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                startIndex = i + 1 - maxCount;
            }
        }

        for (int i = startIndex; i < startIndex + maxCount; i++)
        {
            Console.WriteLine(array[i]);
        }



        ////
        //int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        //int currentSequence = 1;
        //int maxSequence = 1;
        //int maxSequenceStartIndex = 0;
        //for (int i = 1; i < array.Length; i++)
        //{
        //    if (array[i] > array[i - 1])
        //    {
        //        currentSequence++;
        //    }
        //    else
        //    {
        //        if (currentSequence > maxSequence)
        //        {
        //            maxSequence = currentSequence;
        //            maxSequenceStartIndex = i - maxSequence;
        //        }
        //        currentSequence = 1;
        //    }
        //}
        //
        //int[] longestSequence = new int[maxSequence];
        //for (int i = 0; i < longestSequence.Length; i++)
        //{
        //    longestSequence[i] = array[maxSequenceStartIndex + i];
        //}
        //
        //
        //Console.WriteLine("The longest sequence of increasing elements in [{0}] consists of {1} elements - [{2}].", String.Join(", ", array), maxSequence, String.Join(", ", longestSequence));


        ////
        //int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        //
        //int startSequence = 0;
        //int currentCount = 1;
        //int maxCount = 0;
        //
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (i != 0)
        //    {
        //        if (array[i] > array[i - 1])
        //        {
        //            currentCount++;
        //        }
        //        else
        //        {
        //            currentCount = 1;
        //        }
        //        if (currentCount > maxCount)
        //        {
        //            maxCount = currentCount;
        //            startSequence = i + 1 - maxCount;
        //        }
        //    }
        //}
        //Console.Write("Maximal sequence of equal elemenst is: ");
        //for (int i = startSequence; i < startSequence + maxCount; i++)
        //{
        //    Console.Write(" {0} ", array[i]);
        //}
        //Console.WriteLine();
    }
}
