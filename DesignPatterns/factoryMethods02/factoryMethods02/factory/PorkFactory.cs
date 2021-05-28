using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethods02.factory
{
    class PorkFactory : MealsFactory
    {
        private int _Calories;
        private int _Protein;

        public PorkFactory(int Calories, int Protein)
        {
            _Calories = Calories;
            _Protein = Protein;
        }

        public override Meals GetMeals()
        {
            return new Pork(_Calories, _Protein);
        }
    }
}
