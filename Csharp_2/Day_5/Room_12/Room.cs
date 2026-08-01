using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Room_12
{
     class Room
    {
        /*
      * **Room**
      - Properties: `Length`, `Width`, `Height`
      - Function: `GetVolume()` → calculates room volume
         
         */
        //Fields:
        //Fields are Variables that are declared directly in a class.
        //Fields can be of any type .
        //Fields are used to store data for the class.
        public double _length;
        public double _width;
        public double _height;

        //Constructors:
        // Constructors are special methods that are used to
        // initialize objects of a class.
        // Constructors have the same name as the class
        // and do not have a return type.
        public Room(double length, double width , double height) 
        {
            //if (length <= 0 || width <= 0 || height <= 0)
            //{
            //    throw new ArgumentException("Length, Width, and Height must be positive values.");
            //}
            //else 
            //{
                _length = length;
                _width  = width;
                _height = height;
            //}
               
        }
 
        //Functions
        public double GetVolume()
        {
            return _length * _width ;
        }

    }
}
