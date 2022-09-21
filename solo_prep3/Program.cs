using System;

namespace Test
{

    public class Program
    {

        public static void Main(string[] args)
        {
            

                        Random randomGenerator = new Random();
            int goldenNumber = randomGenerator.Next(1, 9999);
            int guess = 0;

            while (guess != goldenNumber)

            {
                Console.Write("Guess a number any number?");
                string stringNUmber = Console.ReadLine();
                guess = int.Parse(stringNUmber);

                if (guess < goldenNumber)
                {
                    Console.WriteLine("Too low try again.\n");
                }

                else if (guess > goldenNumber)
                {
                    Console.WriteLine("Too higher better luck next time.\n");
                }

                else
                {
                    Console.WriteLine("Bingo you got it champ!");
                }

            }



        }
    }
}