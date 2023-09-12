using System;

namespace Week1Prep;

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("Please input the number to sum to (an integer): ");

        int input = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Please input the method you prefer: 1 for formula and 2 for iteration: ");

        int choice = int.Parse(Console.ReadLine()!);

        Console.WriteLine("The sum will be: " + Sum(input, choice));
    }

    private static ulong Sum(int n, int choice)
    {
        if (choice == 1)
        {
            return SumFormula(n);
        }

        if (choice == 2)
        {
            return SumIteration(n);
        }

        return 0;
    }

    private static ulong SumFormula(int n)
    {
        return (ulong)n * ((ulong)n + 1) / 2;
    }

    private static ulong SumIteration(int n)
    {
        ulong sum = 0;

        for (int i = 1; i <= n; ++i)
        {
            sum += (ulong)i;
        }

        // Out of curiousity, will a 'Good Enough Compiler' compile this into a formula?

        return sum;
    }

}

