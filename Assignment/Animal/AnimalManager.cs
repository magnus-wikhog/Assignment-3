using System;
using System.Collections.Generic;
using Assignment.Animals;
using Assignment.ListManager;

namespace Assignment{

    /* 
     * This class manages our animals. It lets us add animals and retrieve them.
     */
    public class AnimalManager : ListManager<Animal> {



        /// <summary>
        /// Factory method which creates a concrete animal based on the given parameters.
        /// </summary>
        /// <param name="speciesName">The name of the species</param>
        /// <param name="attributes">Attributes specific to the species</param>
        /// <returns></returns>
        public Animal CreateAnimal(string speciesName, Dictionary<string, Object> attributes) {
            string id = string.Format("{0:P}-{1:000}", speciesName, Count);

            Animal animal = null;
            switch (speciesName) {
                case "Cat":  animal = new Cat(id, (int)attributes["mammalTeethCount"], (double)attributes["catClawLength"]); break;
                case "Dog":  animal = new Dog(id, (int)attributes["mammalTeethCount"], (double)attributes["dogTailLength"]); break;
                case "Swan": animal = new Swan(id, (double)attributes["birdWingSpan"], (string)attributes["swanColor"]); break;
                case "Crow": animal = new Crow(id, (double)attributes["birdWingSpan"], (double)attributes["crowWeight"]); break;
            }

            return animal;
        }




    }


    /*
     * Compares animal ages (ascending)
     */
    public class AgeComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.age - y.age;
        }
    }


    /*
     * Compares animal names (ascending)
     */
    public class NameComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Name.CompareTo(y.Name);
        }
    }


    /*
     * Compares animal ID's (ascending)
     */
    public class IdComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.ID.CompareTo(y.ID);
        }
    }


    /*
     * Compares animal genders (ascending)
     */
    public class GenderComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Gender.CompareTo(y.Gender);
        }
    }


    /*
     * Compares animal species (ascending)
     */
    public class SpeciesComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecies().CompareTo(y.GetSpecies());
        }
    }
    


    /*
     * Compares animal characteristics (ascending)
     */
    public class SpecialCharacteristicsComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecialCharacteristics().CompareTo(y.GetSpecialCharacteristics());
        }
    }

}
