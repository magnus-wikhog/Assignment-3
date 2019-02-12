namespace Assignment.Animals
{

    /*
     * This is the abstract base class for all animal species, and contains common
     * properties for all species.
     */
    public abstract class Animal{

        // Properties common to all animals
        public string name;
        public string gender;
        public int age;

        public Animal(){
        }

        /*
         * This method will be overriden by subclasses and used to get a string representation
         * of the special characteristics for an animal category and an animal species.
         */
        public virtual string GetSpecialCharacteristics() {
            return "";
        }
    }
}
