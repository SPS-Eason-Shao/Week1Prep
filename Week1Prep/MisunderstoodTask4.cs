using System;

namespace Week1Prep;

class MisunderstoodTask4
{
    public static void TaskFour()
    {
        Console.WriteLine("Please indicate the base you are starting with, and the base you are ending with (do not exceet base 36): ");

        string[] inputs = Console.ReadLine()!.Split();

        int startingBase = int.Parse(inputs[0]), endingBase = int.Parse(inputs[1]);


        Console.WriteLine("Please give the starting number, with letters (a-z or A-Z) for digits not less than 10: ");

        string? input = Console.ReadLine();


        Console.WriteLine("The result will be: " + UnitConversion(input!, startingBase, endingBase));
    }

    private static string UnitConversion(string numberString, int startingBase, int endingBase) // Main Function
    {
        // 1. Convert number string to number digit array.

        int[] numberDigitArray = StringToDigitArray(numberString);

        // 2. Convert digit array to denary. (To avoid complicated division and modulo)

        ulong numberDenary = DigitArrayToInt(numberDigitArray, startingBase);

        // 3. Do recustion to convert to a number digit array.

        int[] convertedDigitArray = ConversionCore(numberDenary, endingBase);

        // 4. Convert number digit array to string.

        string convertedString = DigitArrayToString(convertedDigitArray);

        // 5. Return result.

        return convertedString;

    }

    private static int[] StringToDigitArray(string number) // String to Digit Array
    {
        int length = number.Length;

        int[] resultArray = new int[length];

        for (int i = 0; i < length; ++i)
        {
            char currentDigitChar = number[i];

            if ('0' <= currentDigitChar && currentDigitChar <= '9')
            {
                resultArray[i] = currentDigitChar - '0';
            }

            if ('A' <= currentDigitChar && currentDigitChar <= 'Z')
            {
                resultArray[i] = currentDigitChar - 'A' + 10;
            }

            if ('a' <= currentDigitChar && currentDigitChar <= 'z')
            {
                resultArray[i] = currentDigitChar - 'a' + 10;
            }
        }

        return resultArray;
    }

    private static ulong DigitArrayToInt(int[] digitArray, int numberBase) // Digit Array to Denary
    {
        int length = digitArray.Length;

        ulong result = 0;

        for (int i = 0; i < length; ++i)
        {
            result += (ulong)(digitArray[i] * Math.Pow(numberBase, length - i - 1));
        }

        return result;
    }

    private static int[] ConversionCore(ulong number, int numberBase) // Denary to Given Base
    {
        Stack<int> result = new Stack<int>();

        while (number != 0)
        {
            result.Push((int)(number % (ulong)numberBase));

            number /= (ulong)numberBase;
        }

        return result.ToArray();
    }

    private static string DigitArrayToString(int[] number) // Digit Array to String
    {
        int length = number.Length;

        char[] resultArray = new char[length];

        for (int i = 0; i < length; ++i)
        {
            int currentDigitInt = number[i];

            if (0 <= currentDigitInt && currentDigitInt <= 9)
            {
                resultArray[i] = (char)('0' + currentDigitInt);
            }

            if (10 <= currentDigitInt && currentDigitInt <= 35)
            {
                resultArray[i] = (char)('a' + (currentDigitInt - 10));
            }
        }

        return new string(resultArray);
    }
}

