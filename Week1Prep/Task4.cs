using System;
namespace Week1Prep;

class Task4
{

    public void TaskFour()
    {
        Console.WriteLine("bit, nibble, B, KiB, MiB, GiB, TiB, PiB, EiB, ZiB, YiB, KB, MB, GB, TB, PB, EB, ZB, YB are available for conversion.");
        Console.WriteLine("Please give the starting unit and the result unit, separating with a space: ");
        string[] inputs = Console.ReadLine()!.Split();

        string startingUnit = inputs[0], resultUnit = inputs[1];

        Console.WriteLine("Please input the number: ");
        double number = double.Parse(Console.ReadLine()!);

        Console.WriteLine(number.ToString() + " " + startingUnit + " = " + UnitConversion(number, startingUnit, resultUnit) + " " + resultUnit);
    }

    private static double UnitConversion(double number, string startingUnit, string resultUnit)
    {
        Dictionary<string, double> unitValue = new Dictionary<string, double>();

        char[] unitPrefix = { 'K', 'M', 'G', 'T', 'P', 'E', 'Z', 'Y' };
        int lengthUnitPrefix = 8;

        unitValue.Add("bit", 1);
        unitValue.Add("nibble", 4);
        unitValue.Add("B", 8);

        for (int i = 0; i < lengthUnitPrefix; ++i)
        {
            string unitBase2 = unitPrefix[i].ToString() + "iB";
            double numberBase2 = Math.Pow(2, 10 * (i + 1)) * 8;

            string unitBase10 = unitPrefix[i].ToString() + "B";
            double numberBase10 = Math.Pow(10, 3 * (i + 1)) * 8;

            unitValue.Add(unitBase2, numberBase2);
            unitValue.Add(unitBase10, numberBase10);
        }

        return number * (unitValue[startingUnit] / unitValue[resultUnit]);
    }
}

