using System;

namespace Assignment_6
{

   /*  	Write a  Program to assign integer to an array and then print the following
            a.Average value of Array elements
            b.Minimum and Maximum value in an array*/



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements in array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine("Enter element in array: ");
            for( int i = 0; i < length; ++i)
            {
                 array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0, avg = 0;
            for (int j = 0; j < length; ++j)
            {
                sum = sum + array[j];
            }
            avg = sum / length;

            Console.WriteLine("Average of elements is : " + avg);

            int min = 0;
            for( int k = 0; k < length; ++k)
            {
                if(min < array[k])
                {
                    min = array[k];
                }
            }
            Console.WriteLine("Maximum value in the array is: " + min);


            int max = array[0];
            for (int k = 0; k < length; ++k)
            {
                if (max > array[k])
                {
                    max = array[k];
                }
            }
            Console.WriteLine("Minimum value in the array is: " + max);

        }
    }
}
