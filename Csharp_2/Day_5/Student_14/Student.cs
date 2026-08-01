using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Student_14
{
     class Student
    {
        /*
         * **Student**
         - Properties: `Name`, `Mark`, `FullMark`
         - Functions: 
         - `GetPercentage()` → calculates result percentage
         - `GetGrade()` → returns grade based on percentage
         */

        //Fields
        public string _name;
        public double _mark;
        public double _fullMark;

        //Constructor
        public Student(string name , double mark , double fullmark)
        {
            _name = name;
            _mark = mark;
            _fullMark = fullmark;

        }

        //Functions
        public double GetPercentage()
        {
            return (_mark / _fullMark) * 100;
        }
        public string GetGrade()
        {
            double percentage = GetPercentage();

            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
