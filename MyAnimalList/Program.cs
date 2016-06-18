using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||-- Starting animal program -- ||");

            MyAnimalList MyAnimals = new MyAnimalList();
            MyAnimals.AnimalRemoved += new MyAnimals_AnimalRemoved(ListChanged);

            MyAnimals.Add(new Animal(AnimalType.Amphibian, "Frog"));
            MyAnimals.Add(new Animal(AnimalType.Bird, "Eagle"));
            MyAnimals.Add(new Animal(AnimalType.Fish, "Bass"));

            MyAnimals += new Animal(AnimalType.Invertebrate, "Worm");
            MyAnimals += new Animal(AnimalType.Mammal, "Lion");
            MyAnimals += new Animal(AnimalType.Reptile, "Snake");

            MyAnimals.Add("dog");

            MyAnimals.Remove(5);
            MyAnimals.RemoveAt(3);
            MyAnimals.RemoveRange(1, 2);
            MyAnimals.Remove(5);

            foreach (Animal animal in MyAnimals)
            {
                MessageBox.Show("You still have a " + animal.AnimalName + " (" + animal.AnimalType + ")", "CS559 - Assignment 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // This will be called whenever the list changes.
        private static void ListChanged(object sender, AnimalListEventArgs e)
        {
            MessageBox.Show(e.Animal.AnimalName +" was removed from the list.", e.Animal.AnimalType+" Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
