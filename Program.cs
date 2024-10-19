using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{   // Main is where the user will input and see the results
    public static void Main(string[] args)
    {
        string? UserInput = Console.ReadLine();
        Console.WriteLine($"You entered: {UserInput}");
        string reversedInput = Reverse(UserInput);
        Console.WriteLine($"Reverse string: {reversedInput}");
        
    }

    // This method is the logic 
    public static string Reverse(string Input)
    {
        // converts string to character array 
        char[] charArray = Input.ToCharArray();

        // declaring an empty string 
        string reversedString = String.Empty;

        // iterate through each character right to left
        for (int i = charArray.Length - 1; i > -1; i--)
        {
            reversedString += charArray[i];
        }
        return reversedString;
    }
}