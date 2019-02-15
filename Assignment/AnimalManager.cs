using System;
using System.Collections.Generic;
using Assignment.Animals;

namespace Assignment
{


    /* 
     * This class manages our animals. It lets us add animals and retrieve them.
     */
    public class AnimalManager {
        private List<Animal> animals;

        public AnimalManager() {
            animals = new List<Animal>();
        }

        /*
         * Adds the given animal to the list, and returns an AnimalNode which can be
         * used to display the newly inserted animal in a NodeView.
         */        
        public void AddAnimal(Animal animal){
            animals.Add(animal);
        }

        /*
         * Returns the animal at the given index in the list, or null if it doesn't exist.
         */
        public Animal GetAnimalAt(int index) {
            return index < animals.Count ? animals[index] : null;
        }


        /*
         * Returns the animal with the given ID in the list, or null if it doesn't exist.
         */
        public Animal GetAnimalWithId(string id) {
            return animals.Find((animal) => animal.ID.Equals(id)); 
        }


        /*
         * Factory method which creates a concrete animal based on the given parameters.
         */
        public Animal CreateAnimal(string speciesName, Dictionary<string, Object> attributes) {
            string id = string.Format("{0:P}-{1:000}", speciesName, animals.Count);

            Animal animal = null;
            switch (speciesName) {
                case "Cat":  animal = new Cat(id, (int)attributes["mammalTeethCount"], (double)attributes["catClawLength"]); break;
                case "Dog":  animal = new Dog(id, (int)attributes["mammalTeethCount"], (double)attributes["dogTailLength"]); break;
                case "Swan": animal = new Swan(id, (double)attributes["birdWingSpan"], (string)attributes["swanColor"]); break;
                case "Crow": animal = new Crow(id, (double)attributes["birdWingSpan"], (double)attributes["crowWeight"]); break;
            }

            return animal;
        }


        /*
         * Returns the entire animal list.
         */
        public List<Animal> GetAnimals() {
            return animals;
        }


        /*
         * Sorts the list using the supplied IComparer
         */
        public void Sort(IComparer<Animal> comparer) {
            animals.Sort(comparer);
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
