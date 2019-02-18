using System.Collections.Generic;

namespace Assignment.Animals
{
    public class Cat : Mammal {
        public double clawLengthCm;

        public Cat(string id, int teethCount, double clawLengthCm) : base(id, teethCount) {
            this.clawLengthCm = clawLengthCm;
        }


        public override EaterType GetEaterType() => EaterType.Carnivore;

        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" sleeps 23 hours per day.",
            "When he is awake, he eats cat food."
        });

        public override string GetSpecies() => "Cat";


        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It's claws are " + clawLengthCm + " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
