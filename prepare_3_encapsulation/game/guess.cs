using System;
namespace Test;

///<summary>
///handles the gueeses and output
///</summary>
public class guess
{
    ///<summary>
    ///asks for a guess and then recieves the guess as a string
    ///<para> returns that guess as an int </para>
    ///</summary>
    public static int callResponse()
    {
        Console.Write("Enter a location [1-1000]:");
        string response = Console.ReadLine();
        int numberGuess = int.Parse(response);
        return numberGuess;
    }
}