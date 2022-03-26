using System.Collections;
using System.Collections.Generic;

using static System.Console; 

namespace Chapter08;

public class RegularExpressions
{
    public static void Main(string[] args)
    {
        Write("Enter a valid web address: ");

        string? url = ReadLine();

        if (string.IsNullOrWhiteSpace(url))
        {
            url = "https://stackoverflow.com/search?q=securestring";
        }

        Uri uri = new Uri(url);

        WriteLine($"")
    }
}