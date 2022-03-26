using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x is null || y is null)
            {
                return 0;
            }

            //Compare the name lengths.....
            int result = x.Name.Length.CompareTo(y.Name.Length);

            //...if they are equal
            if (result == 0)
            {
                //...then compare by the names
                return x.Name.CompareTo(y.Name);
            }
            else //The names are not equal
            {
                //...the should otherwise compared by the lengths.
                return result;
            }
        }
    }
}
