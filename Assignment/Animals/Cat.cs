namespace Assignment.Animals
{
    public class Cat : Mammal{
        public double clawLengthCm;

        public Cat(int teethCount, double clawLengthCm) : base(teethCount){
            this.clawLengthCm = clawLengthCm;
        }

        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It's claws are " + clawLengthCm + " cm long. " + base.GetSpecialCharacteristics();
        }
    }
}
