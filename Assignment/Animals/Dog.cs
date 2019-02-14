using System.Collections.Generic;

namespace Assignment.Animals
{
    public class Dog : Mammal{
        public double tailLengthCm;

        public Dog(string id, int teethCount, double tailLengthCm) : base(id, teethCount){
            this.tailLengthCm = tailLengthCm;
        }


        public override EaterType GetEaterType() => EaterType.Omnivore;

        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" eats dog food.",
            "He needs to be taken for a walk at least twice a day.",
            "Don't forget doggy bags..."
        });

        public override string GetSpecies() => "Dog";



        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It's tail is " + tailLengthCm+ " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
