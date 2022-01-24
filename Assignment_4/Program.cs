using System;

namespace Assignment_4
{


    /*Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),calculates the average and prints result as passed or failed
    If avg< 50 then failed else passed.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------Average Calculator Program---------------------------");
            Console.WriteLine("Enter you marks for the following subjects.");
            Console.Write("C# ");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("HTML ");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("SQL ");
            int marks3 = Convert.ToInt32(Console.ReadLine());

            int avg = (marks1 + marks2 + marks3) / 3;

            if(avg >= 50)
            {
                Console.WriteLine("You passed the test.");
            }else
            {
                Console.WriteLine("You failed the test.");
            }
                

        }
    }
}
