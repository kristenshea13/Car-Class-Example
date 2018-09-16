using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Class_Example
{
    class Car
    {
        private string color;

        public Car(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public string Describe()
        {
            return $"This car is {Color}. \n The model of this car: {Model}";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string model;
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
