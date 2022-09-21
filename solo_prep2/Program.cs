using System;

namespace Test
{

    public class Program
    {
        
        public static void Main(string[] args)
        {




            // A >= 90

// B >= 80

// C >= 70

// D >= 60

// F < 60

// Ask the user for their grade percentage, then write a series of if-elif-else statements
//  to print out the appropriate letter grade. (At this point, you'll have a separate print
//   statement for each grade letter in the appropriate block.)

Console.WriteLine("What is you grade percentage?");
string grade_percent = Console.ReadLine();
string letterGrade ="";

int grade_num = int.Parse(grade_percent);

if (grade_num >= 90)
{
    letterGrade = "A";
}

else if (grade_num >= 80)
{
    letterGrade = "B";
}

else if (grade_num >= 70)
{
    letterGrade = "C";
}
else if (grade_num >= 60)
{
    letterGrade = "D";
}

else
{
    letterGrade = "F";
}

if (grade_num < 70)
{
    Console.WriteLine("You did not make it better luck next time.");
}
else
{
    Console.WriteLine("Congrats you passed the class");
}
Console.WriteLine($"Your grade is {letterGrade}");




        }
    }
}
