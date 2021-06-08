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
                
                try 
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                } 
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally{
                    Console.WriteLine("**");
                }
                Console.WriteLine("Enter another grade or 'q' to quit:");
            };
            Console.WriteLine("All grades have been entered.");
            
            var stats = book.GetStatistics();
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}