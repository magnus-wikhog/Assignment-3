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
            return animals.Count < index ? animals[index] : null;
        }


        /*
         * Returns the animal with the given ID in the list, or null if it doesn't exist.
         */
        public Animal GetAnimalWithId(string id) {
            return animals.Find((animal) => animal.ID.Equals(id)); 
        }


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

    }



}
