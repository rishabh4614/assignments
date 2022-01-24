using System;

namespace Assignment_7
{

    /*Write a program in C# to accept ten marks and display the following
		
    a.Total
    b.Average
    c.Minimum marks
    d.Maximum marks
    e.Display marks in ascending order
    f.Display marks in descending order
*/


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of element in array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter elements in array: ");
            
            for (int i = 0; i < length; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0, avg = 0;
            for (int j = 0; j < length; ++j)
            {
                sum = sum + array[j];
            }
            avg = sum / length;
            Console.WriteLine("Sum of array is: " + sum);
            
            Console.WriteLine("Average of array is: " + avg);


            int min = 0;
            for (int k = 0; k < length; ++k)
            {
                if (min < array[k])
                {
                    min = array[k];
                }
            }
            Console.WriteLine("Maximum marks in the array is: " + min);


            int max = array[0];
            for (int k = 0; k < length; ++k)
            {
                if (max > array[k])
                {
                    max = array[k];
                }
            }
            Console.WriteLine("Minimum marks in the array is: " + max);

            Array.Sort(array);
            Console.Write("Array in ascending order is: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Array.Reverse(array);
            Console.Write("Array in decending order is: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }


    }
}
