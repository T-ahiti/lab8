// Name: Zannatul Tasnim Tahiti
// Student Number: 0850073
// Lab 8
// Program Description: This program uses four user-defined methods: one
//    to input an array of numbers, one to compute the average the array, one
//    to find the largest number in the array, and one to find the smallest
//    number in the array.

using System;

public static class Lab8
{
    public static void Main()
    {
        int[] compStats = new int[25];
        int n = 0, large, small;
        double avg;

        Console.Clear();
        // Input values into the array
        InpArray(compStats, ref n);

        // Find the average of the elements in the array
        avg = FindAverage(compStats, n);

        // Find the largest element in the array
        large = FindLarge(compStats, n);

        // Find the smallest element in the array
        small = FindSmall(compStats, n);

        // Print out the results
        Console.WriteLine("\nThe Average of the array is {0:F2}", avg);
        Console.WriteLine("The Largest element in the array is {0}", large);
        Console.WriteLine("The Smallest element in the array is {0}", small);
    }

    public static void InpArray(int[] arrValues, ref int num)
    {
        // input the number of data values to put in the array
        do
        {
            Console.Write("Enter the number of elements (<= 25) => ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 0 || num > 25);

        // loop to enter the values
        for (int i = 0; i < num; ++i)
        {
            Console.Write("Enter the Element {0} => ", i);
            arrValues[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static double FindAverage(int[] arrVals, int num)
    {
        int sum = 0;
        for (int i = 0; i < num; ++i)
        {
            sum += arrVals[i];
        }
        return (double)sum / num;
    }

    public static int FindLarge(int[] arrVals, int num)
    {
        int largest = arrVals[0];
        for (int i = 1; i < num; ++i)
        {
            if (arrVals[i] > largest)
            {
                largest = arrVals[i];
            }
        }
        return largest;
    }

    public static int FindSmall(int[] arrVals, int num)
    {
        int smallest = arrVals[0];
        for (int i = 1; i < num; ++i)
        {
            if (arrVals[i] < smallest)
            {
                smallest = arrVals[i];
            }
        }
        return smallest;
    }
}
