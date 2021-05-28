using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethods02
{
    class Pork : Meals
    {
        public Pork(int Calories, int Protein)
        {
            this.Name = "Pork";
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
