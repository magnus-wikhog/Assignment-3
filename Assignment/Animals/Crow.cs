namespace Assignment.Animals
{
    public class Crow : Bird{
        public double weightKg;

        public Crow(double wingSpanCm, double weightKg) : base(wingSpanCm) {
            this.weightKg = weightKg;
        }

        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It weighs " + weightKg + " kg. " + base.GetSpecialCharacteristics();
        }

    }
}
