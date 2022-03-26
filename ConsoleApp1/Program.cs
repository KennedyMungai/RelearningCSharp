using System;

using static System.Console;

namespace Chapter02;

class Chapter02
{
    public static void Main(string[] vs)
    {
        Write("Enter an amount: ");
        string? amount = ReadLine();

        try
        {
            decimal? amountValue = decimal.Parse(amount);
        }
        catch (FormatException) when (amount.Contains("$"))
        {
            WriteLine("Amounts cannot use the dollar sign.");
        }
        catch 
        {
            WriteLine("Amounts must only contain digits!");
        }
    }
}