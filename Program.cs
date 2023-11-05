using System;

class Program
{
    static void Main()
    { 
        int N = int.Parse(Console.ReadLine());

        double totalSum = 0;

        for (int i = 1; i <= N; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            totalSum += grade;
        }

        double average = totalSum / N;

        Console.WriteLine($"{average:F2}");
    }
}
