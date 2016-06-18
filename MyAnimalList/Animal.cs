using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalList
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public AnimalType AnimalType { get; set; }

        public Animal(AnimalType animalType, string animalName)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
        }

    }
}
