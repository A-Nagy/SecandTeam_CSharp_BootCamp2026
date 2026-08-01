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
         string _name;
         double _mark;
         double _fullMark;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        public double FullMark
        {
            get { return _fullMark; }
            set { _fullMark = value; }
        }


        //Constructor
        public Student(string name , double mark , double fullmark)
        {
            Name = name;
            Mark = mark;
            FullMark = fullmark;

        }

        //Functions
        public double GetPercentage()
        {
            return (Mark / FullMark) * 100;
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
