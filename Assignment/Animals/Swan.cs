namespace Assignment.Animals
{
    public class Swan : Bird{
        public string color;

        public Swan(double wingSpanCm, string color) : base(wingSpanCm) {
            this.color = color;
        }

        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It is a " + color + " swan. " + base.GetSpecialCharacteristics();
        }

    }
}
