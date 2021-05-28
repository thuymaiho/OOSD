using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethods02.factory
{
    class BeefFactory: MealsFactory
    {
        private int _Calories;
        private int _Protein;

        public BeefFactory(int Calories, int Protein)
        {
            _Calories = Calories;
            _Protein = Protein;
        }

        public override Meals GetMeals()
        {
            return new Beef(_Calories, _Protein);
        }
    }
}
