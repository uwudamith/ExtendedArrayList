using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalList
{

    // A delegate type for hooking up change notifications.
    //public delegate void MyAnimals_AnimalRemoved(MyAnimalList collection, Animal item);
    public delegate void MyAnimals_AnimalRemoved(object sender, AnimalListEventArgs e);

    /// <summary>
    /// MyAnimalList class only accept Animal types
    /// </summary>
    public class MyAnimalList : ArrayList
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event MyAnimals_AnimalRemoved AnimalRemoved;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(object sender, AnimalListEventArgs e) 
         {
             if (AnimalRemoved != null)
                 AnimalRemoved(this, e);
         }

         // Override some of the methods that can change the list;
         // invoke event after each
         public void Remove(int value)
         {
             MyAnimalList list = this;
             if (value > list.Count)
             {
                 MessageBox.Show(value+" is not a valid index", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             AnimalListEventArgs args = new AnimalListEventArgs((Animal)list[value]);
             OnChanged(this, args);
             base.Remove(value);
         }

         // Override some of the methods that can change the list;
         // invoke event after each
         public override void RemoveRange(int from,int to)
         {
             ArrayList list = this.GetRange(from, to);
             foreach(var animal in list)
             {
                 OnChanged(this, new AnimalListEventArgs((Animal)list[list.IndexOf(animal)]));
             }
             base.RemoveRange(from,to);
         }

         // Override some of the methods that can change the list;
         // invoke event after each
         public override void RemoveAt(int value)
         {
             MyAnimalList list = this;
             OnChanged(this, new AnimalListEventArgs((Animal)list[value]));
             base.RemoveAt(value);
         }

        /// <summary>
        /// Override + operator 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static MyAnimalList operator +(MyAnimalList list,Animal animal)
        {
            list.Add(animal);
            return list;
        }

        public new void Add(object value)
        {
            Type t = value.GetType();
            if (t.Equals(typeof(Animal)))
            {
                 base.Add((Animal)value);
            }
            else
            {
                MessageBox.Show("Only Animal type objects can be added to the MyAnimalList collection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
