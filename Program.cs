using System;

namespace FizzBuzzApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the FizzBuzz program!");

            Console.WriteLine();

            Console.WriteLine("Enter the last number at which you want the program to finish printing the numbers.....");

            string userInput = Console.ReadLine();

            Console.WriteLine();            

            int limit = 0;

            string message = string.Empty;

            if (int.TryParse(userInput, out limit))
            {
                Console.WriteLine(String.Format("Limit entered is : {0}", limit));

                Console.WriteLine();

                for (int i = 1; i <= limit; i++)
                {

                    if (i % 15 == 0)
                        message = "FizzBuzz {0}";
                    else if (i % 3 == 0)
                        message = "Fizz \t {0}";
                    else if (i % 5 == 0)
                        message = "Buzz \t {0}";
                    else message = "{0} \t {1}";

                    Console.WriteLine(String.Format(message, i.ToString(), i.ToString()));

                }//End of for loop

            }//End of big if block
                      

            Console.WriteLine();

            Console.WriteLine("Press any key to end...");

            Console.ReadKey();
        }//End of main program.
    }
}
