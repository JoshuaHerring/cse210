using System;

namespace Test
{

    public class Program
    {
        public void determineWinner()
        {
            
        }
        public static void Main(string[] args)
        {


            string a = "1";
            string b = "2";
            string c = "3";
            string d = "4";
            string e = "5";
            string f = "6";
            string g = "7";
            string h = "8";
            string i = "9";



            for (int z = 0; z < 10; z++)
            {

                    // altering the board

                    if (z != 9)
                    {

                if (z%2 == 0)
                {
                    Console.WriteLine($"{a} | {b} | {c}\n--+---+--\n{d} | {e} | {f}\n--+---+--\n{g} | {h} | {i}\n");
                    Console.WriteLine(" Your up o");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        a = "o";
                    }
                    else if (choice == "2")
                    {
                        b = "o";
                    }
                    else if (choice == "3")
                    {
                        c = "o";
                    }

                    else if (choice == "4")
                    {
                        d = "o";
                    }
                    else if (choice == "5")
                    {
                        e = "o";
                    }
                    else if (choice == "6")
                    {
                        f = "o";
                    }
                    else if (choice == "7")
                    {
                        g = "o";
                    }
                    else if (choice == "8")
                    {
                        h = "o";
                    }
                    else if (choice == "9")
                    {
                        i = "o";
                    }
                }

                else
                {
                    Console.WriteLine($"{a} | {b} | {c}\n--+---+--\n{d} | {e} | {f}\n--+---+--\n{g} | {h} | {i}\n");
                    Console.WriteLine(" Your up x");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        a = "x";
                    }
                    else if (choice == "2")
                    {
                        b = "x";
                    }
                    else if (choice == "3")
                    {
                        c = "x";
                    }

                    else if (choice == "4")
                    {
                        d = "x";
                    }
                    else if (choice == "5")
                    {
                        e = "x";
                    }
                    else if (choice == "6")
                    {
                        f = "x";
                    }
                    else if (choice == "7")
                    {
                        g = "x";
                    }
                    else if (choice == "8")
                    {
                        h = "x";
                    }
                    else if (choice == "9")
                    {
                        i = "x";
                    }
                }
                    }

                // Determine the winner

                if (a == "o" && b == "o" && c == "o" || d == "o" && e == "o" && f == "o" || g == "o" && h == "o" && i == "o" || a == "o" && d == "o" && g == "o" || b == "o" && e == "o" && h == "o" || c == "o" && f == "o" && i == "o" || a == "o" && e == "o" && i == "o" || c == "o" && e == "o" && g == "o")
                {
                    Console.WriteLine($"{a} | {b} | {c}\n--+---+--\n{d} | {e} | {f}\n--+---+--\n{g} | {h} | {i}");
                    Console.WriteLine("o is the Winner");
                    break;
                }

                else if (a == "x" && b == "x" && c == "x" || d == "x" && e == "x" && f == "x" || g == "x" && h == "x" && i == "x" || a == "x" && d == "x" && g == "x" || b == "x" && e == "x" && h == "x" || c == "x" && f == "x" && i == "x" || a == "x" && e == "x" && i == "x" || c == "x" && e == "x" && g == "x")
                {
                    Console.WriteLine($"{a} | {b} | {c}\n--+---+--\n{d} | {e} | {f}\n--+---+--\n{g} | {h} | {i}");
                    Console.WriteLine("x is the Winner");
                    break;
                }

                if (z == 9)
                {
                    Console.WriteLine($"{a} | {b} | {c}\n--+---+--\n{d} | {e} | {f}\n--+---+--\n{g} | {h} | {i}");
                    Console.WriteLine("It is a draw");
                    break;
                }

            }



        }
    }
}


