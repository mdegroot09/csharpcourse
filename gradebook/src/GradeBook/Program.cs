using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {1.1, 2.22, 3.3};
            List<double> grades = new List<double>();
            grades.Add(56.1);
            grades[0]

            var sum = 0.0;
            foreach(double num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}