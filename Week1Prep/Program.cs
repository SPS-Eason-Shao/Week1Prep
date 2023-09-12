using System;

namespace Week1Prep;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Task 1: Sum of Natural Numbers from 1 to n

        Task1.TaskOne();

        Console.ReadLine();

        // Task 2: Approximating Pi

        Task2.TaskTwo();

        Console.ReadLine();

        // Task 3: Successive Division Algorithm

        Task3.TaskThree();

        Console.ReadLine();

        // Misunderstood Task 4: I mis-read it as a base conversion system so I wrote a program to convert between numbers base 2 - 36. Kept the code there.

        MisunderstoodTask4.TaskFour();

        Console.ReadLine();

        // Task 4: Unit Conversion System

        var Task4 = new Task4();

        Task4.TaskFour();

        Console.ReadLine();

    }

}