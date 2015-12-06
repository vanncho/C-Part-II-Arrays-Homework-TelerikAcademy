using System;
class allocateArray
{
    static void Main()
    {
        //Problem 1. Allocate array
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Position:{0} -> number:{1}", i, numbers[i]);
        }
    }
}
