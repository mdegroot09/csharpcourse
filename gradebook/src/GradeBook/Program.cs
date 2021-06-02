using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new List<double>() {7.4, 9.2, 8.3, 7.5, 9.6};
            scores.Add(56.1);

            var sum = 0.0;
            foreach(double grade in scores)
            {
                sum += grade;
            }
            var avg = sum / scores.Count;
            Console.WriteLine($"The average grade is {avg:N1}");

        }
    }
}