using System;

namespace IFCONDITION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an username");
            String username = Console.ReadLine();
            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();
            if (username == "PARMESHWAR BADAD" && password == "ITTEFAQ1")
            {
                Console.WriteLine("Login Sucessfully...");

            }
            else
            {
                Console.WriteLine("Incorrect username or password...");

            }

        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 80)
            {
                Console.WriteLine("Gread: A-1");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Gread: A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Gread: B");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Gread: C");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Gread: D");
            }
            else
            {
                Console.WriteLine("Student is Fail...");
            }
        }
    }
}
