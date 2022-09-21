using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{

    public class Program
    {

        public static void Main(string[] args)
        {


            List<int> numbers = new List<int>();

            Console.Write("Enter numbers to add to a list. Enter 0 to Finish.");

            int number = -1;

            while (number != 0)
            {
                string entry = Console.ReadLine();
                    number = int.Parse(entry);
                if (number != 0)
                {
                    numbers.Add(number);
                }
            }


            int sum = numbers.Sum();
            int length = numbers.Count;
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine($"The average is {sum/length}");

            Console.WriteLine($"The largest number is {numbers.Max()}");







        }
    }
}