using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalList
{
   public class AnimalListEventArgs:EventArgs
    {
       private readonly Animal animal;

       public AnimalListEventArgs(Animal animal)
       {
            this.animal = animal;
       }

       public Animal Animal
        {
            get { return this.animal; }
        }
    }
}
