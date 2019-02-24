using Assignment.ListManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Recipe {

    public class Recipe {
        ListManager<string> mIngredients;

        public string Name;
        public ListManager<string> Ingredients { get => mIngredients; }


        public Recipe() {
            mIngredients = new ListManager<string>();
        }




        override
        public string ToString() {
            return Name + ", " + Ingredients.ToStringList().Aggregate( (a, b) => a+", "+b );
        }
    }
}
