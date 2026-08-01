using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Patient_15
{
    internal class Patient
    {/*
      * **Patient**
        - Properties: `Name`, `Height`, `Weight`
        - Functions:
        - `GetBMI()` → calculates Body Mass Index
         - `GetBodyStatus()` → returns weight classification

      */
        //Fields
        public string _name;
        public double _height;
        public double _weight;
        //Constructor

        //Functions
        public double GetBMI()
        {
            return _weight / (_height * _height);
        }
        public string GetBodyStatus()
        {
            double bmi = GetBMI();

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
    }
}
