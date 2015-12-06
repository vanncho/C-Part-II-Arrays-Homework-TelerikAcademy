using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Maximal_K_sum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            //Problem 6. Maximal K sum
            //Write a program that reads two integer numbers N and K and an array of N elements from the console.
            //Find in the array those K elements that have maximal sum.

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];


            int min = 0;
            int temp = 0;
            int currSum = 0;
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Enter number of elements to sum: ");
            int k = int.Parse(Console.ReadLine());

            if (k > arr.Length)
            {
                Console.WriteLine("ERROR! Number of elements to sum must be equal to length of the array!");
            }
            else
            {
                //Sorting the array
                for (int i = 0; i < arr.Length; i++)
                {
                    min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[min])
                        {
                            min = j;
                        }
                    }
                    //swap the values
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;

                }

                //calculating the max sum of K elements
                for (int i = 0; i <= arr.Length - k; i++)
                {
                    for (int j = arr.Length - k; j < arr.Length; j++)
                    {
                        currSum += arr[j];
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                    }
                    currSum = 0;
                }

                //print sorted array
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                //print max K sum
                Console.WriteLine("The max K sum is: {0}", maxSum);
            }
        }
    }
}
