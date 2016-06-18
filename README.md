# ExtendedArrayList
You are going to create your own class which is derived from an ArrayList collection.  
Your class will be called MyAnimalList and it can only contain classes of type Animal.

```c#
MyAnimalList MyAnimals = new MyAnimalList();
```
The ```Animal``` class is defined as follows:

```
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
    
 public enum AnimalType
    {
        Amphibian,
        Bird,
        Fish,
        Invertebrate,
        Mammal,
        Reptile
    }
```
Creating a list of Animal objects:
Add the following Animal objects to ```MyAnimals``` using the ```Add()``` method:

```
MyAnimals.Add(new Animal(AnimalType.Amphibian, "Frog"));
MyAnimals.Add(new Animal(AnimalType.Bird, "Eagle"));
MyAnimals.Add(new Animal(AnimalType.Fish, "Bass"));
```
Add the following Animal objects to MyAnimals using the overridden + operator:
```
MyAnimals += new Animal(AnimalType.Invertebrate, "Worm");
MyAnimals += new Animal(AnimalType.Mammal, "Lion");
MyAnimals += new Animal(AnimalType.Reptile, "Snake");
```

If you try and ```Add()``` any object other than an ```Animal```:

```MyAnimals.Add("Dog")``` You catch the exception and display the error:

Further you can read the attached word document.


