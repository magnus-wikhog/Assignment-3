namespace Assignment.Animals
{
    public class Dog : Mammal{
        public double tailLengthCm;

        public Dog(int teethCount, double tailLengthCm) : base(teethCount){
            this.tailLengthCm = tailLengthCm;
        }

        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It's tail is " + tailLengthCm+ " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
