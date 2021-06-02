using System.Collections.Generic;

namespace GradeBook
{
    class Book 
    {
        public void AddGrade(double score)
        {
            scores.Add(score);
        }

        List<double> scores;
    }
}