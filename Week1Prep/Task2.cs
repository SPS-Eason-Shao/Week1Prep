using System;

namespace Week1Prep;

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("The approximation of pi is: " + PiApproximation());
    }

    private static double PiApproximation() // Bond 2, Page 16
    {
        double pi = 3;
        bool add = true;

        const int acc = 10000; // could be amended for more accuracy

        for (int i = 1; i <= acc; ++i)
        {
            if (add)
            {
                pi += (double)4 / ((2 * i) * (2 * i + 1) * (2 * i + 2));
            }
            else
            {
                pi -= (double)4 / ((2 * i) * (2 * i + 1) * (2 * i + 2));
            }

            add = !add;
        }

        return pi;

        // return Math.PI;
    }
}

