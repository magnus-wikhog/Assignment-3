namespace Assignment.Animals
{
    public class Bird : Animal {

        public double wingSpanCm;


        public Bird(double wingSpanCm) {
            this.wingSpanCm = wingSpanCm;
        }



        /* 
         * Returns a string representation of this category's special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It's wingspan is " + wingSpanCm + " cm. ";
        }
    }
}
