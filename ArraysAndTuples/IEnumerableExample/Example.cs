using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace IEnumerableExample
{
    public class Example:IEnumerable<string>
    {
        List<string> _elements;

        public Example(string[] array)
        {
            this._elements =  new List<string>(array);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("HERE");
            return this._elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine(  "THERE");
            return this._elements.GetEnumerator();
        }
    }

    public class HelloCollection
    {
        public IEnumerator GetEnumerator()
        {
            return  new Enumerator(0);
        }

        public class Enumerator : IEnumerator<string>, IEnumerator, IDisposable
        {
            private int state;
            private string current;

            public Enumerator(int state)
            {
                this.state = state;
            }

            bool IEnumerator.MoveNext()
            {
                switch (state)
                {
                    case 0:
                        current = "Hello";
                        state = 1;
                        return true;
                    case 1:
                        current = "World";
                        state = 2;
                        return true;
                    case 2:
                        break;
                }
                return false;
            }

            void IEnumerator.Reset()
            {
                throw  new NotSupportedException();
            }

            string IEnumerator<string>.Current => current;

            object IEnumerator.Current => current;

            void IDisposable.Dispose()
            {
            }
        }
    }
}