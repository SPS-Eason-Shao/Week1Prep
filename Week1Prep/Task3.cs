using System;

namespace Week1Prep;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("Please input a positive number in denary: ");

        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Please indicate the algorithm to use: 1 for manual stack simulation, 2 recursion: ");

        int choice = int.Parse(Console.ReadLine()!);

        Console.WriteLine("The number in binary is: " + Denary2Binary(n, choice));
    }

    private static string Denary2Binary(int number, int choice)
    {
        if (choice == 1)
        {
            return Denary2BinaryStack(number);
        }

        if (choice == 2)
        {
            return Denary2BinaryRecursion(number);
        }

        return "";
    }

    private static string Denary2BinaryStack(int denary)
    {
        Stack<char> result = new Stack<char>();

        while (denary != 0)
        {
            result.Push((denary % 2).ToString()[0]);

            denary /= 2;
        }

        string returnValue = "";

        foreach (char c in result)
        {
            returnValue += c.ToString();
        }

        return returnValue;
    }

    private static string Denary2BinaryRecursion(int denary)
    {
        if (denary == 1)
        {
            return "1";
        }

        return Denary2BinaryRecursion(denary / 2) + (denary % 2).ToString();
    }
}

