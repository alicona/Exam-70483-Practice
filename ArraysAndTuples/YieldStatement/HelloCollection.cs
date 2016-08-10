using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldStatement
{
    public class HelloCollection
    {
        public IEnumerator<string> GetEnumerator() {
            yield return "Hello";
            yield return "World";
        }
    }
}
