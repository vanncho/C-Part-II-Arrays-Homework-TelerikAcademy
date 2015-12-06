using System;

class compareCharArrays
{
    static void Main()
    {
        //Problem 3. Compare char arrays
        //Write a program that compares two char arrays lexicographically (letter by letter).

        char[] firstArray = { 'a', 'b', 'c', 'f'};
        char[] secondArray = { 'a', 'b', 'd' };
        
        bool areEqual;
        
        if (firstArray.Length != secondArray.Length)
        {
            areEqual = false;
            Console.WriteLine("The arrays are equal: " + areEqual);
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    areEqual = true;
                    Console.WriteLine("{0} chars are equal: {1}", i, areEqual);
                }
                else
                {
                    areEqual = false;
                    Console.WriteLine("{0} chars are equal: {1}", i, areEqual);
                }
            }
        }
    }
}
