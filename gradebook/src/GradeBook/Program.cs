using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Mike's Grade Book");

            Console.WriteLine("Enter a grade or 'q' to quit:");
            while (true)
            {
                var input = Console.ReadLine(); 
                if (input == "q")
                {
                    break;
                }
                
                Console.WriteLine("Enter another grade or 'q' to quit:");
                var grade = double.Parse(input);
                book.AddGrade(grade);
            };
            Console.WriteLine("All grades have been entered.");
            
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
        }
    }
}