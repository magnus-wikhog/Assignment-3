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
        public string AddAnimal(Animal animal){
            animals.Add(animal);
            string id = string.Format("{0:P}-{1:000}", animal.GetType().Name, animals.Count);
            return id;
        }

        /*
         * Returns the animal at the given index in the list, or null if it doesn't exist.
         */
        public Animal GetAnimalAt(int index) {
            return animals.Count < index ? animals[index] : null;
        }

    }



}
