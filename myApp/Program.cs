using System;   // Predefined namespace
                // Way to distinguish classes

namespace helloWorld    // user defined namespace
{
    class Program       
    {
        // execution starts here
                    // Commandline arguments
        static void Main(string[] args) // static means don't have to call main method explicitly
        {
            Console.WriteLine("Hello World! " + DateTime.Now);
            string name;
            Console.WriteLine("Please Enter your Name: ");
            name = Console.ReadLine(); // takes user's input in string form

            Console.WriteLine("Welcome " + name); // String concatenation: memory intensive
            Console.WriteLine($"Welcome {name}"); // String interpolation 
        }
    }
}