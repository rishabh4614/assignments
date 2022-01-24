using System;

namespace Assignment_1
{

    /*Write a program in C# to accept the name of the user and greet the user as:
	“Hi! username
    Welcome to the world of C#”*/


    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter your Name: ");
            string str = Console.ReadLine();
            Console.WriteLine("Hi ! " + str);
            Console.WriteLine("Welcome to the world of C#");
        }
    }
}
