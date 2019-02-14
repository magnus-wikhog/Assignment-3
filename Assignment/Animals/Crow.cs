using System.Collections.Generic;

namespace Assignment.Animals
{
    public class Crow : Bird{
        public double weightKg;

        public Crow(string id, double wingSpanCm, double weightKg) : base(id, wingSpanCm) {
            this.weightKg = weightKg;
        }


        public override EaterType GetEaterType() => EaterType.Omnivore;

        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" will eat all sorts of things.",
            "Crows will usually find food on their own."
        });

        public override string GetSpecies() => "Crow";



        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It weighs " + weightKg + " kg. " + base.GetSpecialCharacteristics();
        }

    }
}
