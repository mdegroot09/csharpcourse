using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else 
            {
                Console.WriteLine($"Invalid value of {grade}. Grade must be between 0 and 100.");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            
            var i = 0;
            do 
            {
                result.Low = Math.Min(grades[i], result.Low);
                result.High = Math.Max(grades[i], result.High);
                result.Average += grades[i];
                i++;
            } while(i < grades.Count);
            result.Average /= grades.Count;
            
            return result;
        }

        private List<double> grades;
        public string Name;
    }
}