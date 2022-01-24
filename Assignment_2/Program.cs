using System;

namespace Assignment_2
{



    //Accept a number from the user and display whether the given number is an odd number or even number.

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number to check odd or even.");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            { Console.WriteLine("Number is Even."); }
            else
            { Console.WriteLine("Number is Odd."); }
        }
    }
}
