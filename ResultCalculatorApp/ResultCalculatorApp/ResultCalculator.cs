using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultCalculatorApp
{
    class ResultCalculator
    {
        public double CalculateAverage(double markOfSubject1,double markOfSubject2)
        {
            return (markOfSubject1+markOfSubject2)/2;
        }
        public double CalculateAverage(double markOfSubject1, double markOfSubject2, double markOfSubject3)
        {
            return (CalculateAverage(markOfSubject1, markOfSubject2)*2)/3;
        }

        public string GetLetterGrade(double averageMark)
        {
            if (averageMark >= 80)
                return "A+";
            if (averageMark >= 70)
                return "B+";
            if (averageMark >= 60)
                return "C+";
            if (averageMark >= 50)
                return "D+";
            return "F";
        }
    }
}
