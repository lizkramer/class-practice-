using System;

namespace Class_Jan_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string standardGreeting = "Hello, " + name + "!";
          
            if(name == "Amar")
            {
                Console.WriteLine(standardGreeting + " I like your shoes.");
            }

            else if(name == "Brandy")
            {
                Console.WriteLine(standardGreeting + " You seem like a cool person.");
            }
            else
            {
                Console.WriteLine(standardGreeting);
            }

            Console.ReadLine();
 
        }
    }
}
