using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndTuples
{
    class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person other) {
            if (other == null) return 1;

            int result = string.Compare(this.LastName, other.LastName);
            if (result== 0)
            {
                result = string.Compare(this.FirstName, other.FirstName);
            }
            return result;
        }
    }
}
