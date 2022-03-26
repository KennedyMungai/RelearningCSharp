using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Chapter06
{
    public class Person : object, IComparable<Person>
    {
        //A delegate field
        public EventHandler? Shout;
        //Data field
        public int AngerLevel;
        public string Name;

        public int CompareTo(Person? other)
        {
            if (Name is null)
            {
                return 0;
            }

            return Name.CompareTo(other?.Name);
        }

        public void Poke()
        {
            AngerLevel++;

            if (AngerLevel >= 3)
            {
                //If something is listening...
                if (Shout != null)
                {
                    //... and then call the delegate
                    Shout(this, EventArgs.Empty);   
                }
            }
        }

        
    }
}
