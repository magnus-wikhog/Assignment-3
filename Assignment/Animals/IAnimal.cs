using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Animals{

    public enum EaterType { Herbivore, Carnivore, Omnivore };


    interface IAnimal{
        string ID { get; }
        string Name { get; set; }
        string Gender { get; set; }

        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
    }

}
