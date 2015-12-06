using System;

class compareArrays
{
    static void Main()
    {
        //Problem 2. Compare arrays
        //Write a program that reads two integer arrays from the console and compares them element by element.

        Console.Write("Enter the sequence of the first array:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the sequence of the second array:");
        int m = int.Parse(Console.ReadLine());
        
        int[] arrayOne = new int[n];
        int[] arrayTwo = new int[m];
        
        for (int i = 0; i < arrayOne.Length; i++)
        {
            Console.Write("Enter {0} number for first array:", i);
            arrayOne[i] = int.Parse(Console.ReadLine()); 
        }
        
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            Console.Write("Enter {0} number for second array:", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        
        bool areEqual = arrayOne.SequenceEqual(arrayTwo);
        
        
        
        if (n == m)
        {
            Console.WriteLine("The arrays are equal: {0}", areEqual);
        }
        else
        {
            Console.WriteLine("The arrays are not equal!");
        }
    }
}
