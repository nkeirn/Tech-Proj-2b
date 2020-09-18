using System;

namespace Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get from ISM 4300. Enter a grade from 1-100!");

            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                decimal grade = decimal.Parse(input);
                int grades = 0;
                if (grades > 90)
                {
                    Console.WriteLine("Your grade is an A");
                }
                else if ((grades > 80) && (grades < 90))
                {
                    Console.WriteLine("Your grade is a B");
                }
                else if ((grades > 70) && (grades < 80))
                {
                    Console.WriteLine("Your grade is a C");
                }
                else if ((grades > 60) && (grades < 70))
                {
                    Console.WriteLine("Your grade is a D");
                }
                else if (grades <60)
                {
                    Console.WriteLine("Your grade is an F");
                }
                else
                {
                    Console.WriteLine("This is not a valid answer");
                
                }
            }
            catch
            {
                Console.WriteLine("Please enter a grade between 1 and 100");
            }
        }
    }
}
