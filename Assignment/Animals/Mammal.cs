namespace Assignment.Animals
{
    public abstract class Mammal : Animal {

        public int teethCount;


        public Mammal(int teethCount) {
            this.teethCount = teethCount;
        }


        /* 
         * Returns a string representation of this category's special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It has " + teethCount + " teeth. ";
        }
    }
}
