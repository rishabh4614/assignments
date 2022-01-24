using System;

namespace Assignment_3
{


    //Create a program, which accepts 3 numbers as input from the user and prints the largest and smallest of 3 numbers.
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter three number to find maximum and minimum: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            max(num1,num2,num3);
            min(num1,num2,num3);

        }





        static void max(int a, int b, int c)
        {
            if(a>b && a>c)
            {
                Console.WriteLine("Maximum number is: " + a);
            }else if(b>c && b>a)
            { Console.WriteLine("Maximum number is: " + b); }
            else if(c>a && c>b)
            { Console.WriteLine("Maximum number is: " + c); }
        }

        static void min(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine("Minimum number is: " + a);
            }
            else if (b < c && b < a)
            { Console.WriteLine("Minimum number is: " + b); }
            else if (c < a && c < b)
            { Console.WriteLine("Minimum number is: " + c); }
        }
    }
}
