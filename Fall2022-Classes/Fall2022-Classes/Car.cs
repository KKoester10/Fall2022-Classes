using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Classes
{
    public class Car
    {
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } 
        public string Color { get; set; }
        public int Speed { get; set; }
        public bool IsPaidFor { get; set; }
        //'prop' short hand to creat a property 
        // public int MyProperty { get; set; }

        // access modifiers: Public, Private, interal
        // how we can access classes, properties, methods, ect. in our application 

        // constructors 
        public Car()
        {
            Make = "Lexus";
            Model = "rx 350";
            Color = "white";
            Year = 2018;
            Speed = 0;
            IsPaidFor = false;
        }
        // method overloading
        public Car(string make, string model, string color, int year, int speed, bool isPaidFor)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Speed = speed;
            IsPaidFor = isPaidFor;
        }

        // Methods



    }
}
