using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethods02
{
     class Beef : Meals
    {
        public Beef(int Calories, int Protein)
        {
            this.Name = "Beef";
            this.Calories = Calories;
            this.Protein = Protein;
        }
        public int getCalories ()
        {
            return this.Calories;
        }
        public int getProtein ()
        {
            return this.Protein;
        }

    }
}
