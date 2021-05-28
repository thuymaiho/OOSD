using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethods02
{
     class Chicken : Meals
    {
        public Chicken(int Calories, int Protein)
        {
            this.Name = "Chicken";
            this.Calories = Calories;
            this.Protein = Protein;
        }
        public int getCalories()
        {
            return this.Calories;
        }
        public int getProtein()
        {
            return this.Protein;
        }


    }
}
