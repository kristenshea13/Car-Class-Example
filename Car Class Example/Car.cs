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
            get { return color.ToUpper(); }
            set { color = value; }
        }
        //public string Color
        //{
        //    get
        //    {
        //        return color.ToUpper();
        //    }
        //    set
        //    {
        //        if (value == "Red")
        //            color = value;
        //        else
        //            color = "This car can only be red!";
        //    }
        //}

        private string model;
        
        public string Model
        {
            get { return model.ToUpper(); }
            set { model = value; }
        }

    }
}
