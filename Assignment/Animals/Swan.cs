using System.Collections.Generic;

namespace Assignment.Animals
{
    public class Swan : Bird{
        public string color;

        public Swan(string id, double wingSpanCm, string color) : base(id, wingSpanCm) {
            this.color = color;
        }


        public override EaterType GetEaterType() => EaterType.Herbivore;

        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" likes to eat seaweeds.",
            "Will also eat bread crumbs from time to time."
        });

        public override string GetSpecies() => "Swan";



        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It is a " + color + " swan. " + base.GetSpecialCharacteristics();
        }

    }
}
