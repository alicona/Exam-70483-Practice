using System;
using System.Collections.Generic;

namespace UnderstandingWeakReference
{
    public class Cache
    {
        //Dictionary to contain the Cache
        static Dictionary<int, WeakReference> _cache;

        //Track number of times an object is regenerated.
        int regenCount = 0;

        public Cache(int count)
        {
            _cache = new Dictionary<int, WeakReference>();

            // Add objects with a short weak reference to the cache.
            for (int i = 0; i < count; i++)
            {
                _cache.Add(i,new WeakReference(new Data(i),false));
            }
        }

        public int Count
        {
            get { return _cache.Count; }
        }

        public int RegenerationCount
        {

            get { return regenCount; }
        }

        public Data this[int index]
        {
            get
            {
                Data d = _cache[index].Target as Data;
                if (d == null)
                {
                    //If the object was reclaimed, generate a new one
                    Console.WriteLine("Regenerate object at {0}: Yes", index);
                    d = new Data(index);
                    _cache[index].Target = d;
                    regenCount++;
                }
                else
                {
                    //object obtained with weak reference
                    Console.WriteLine( "Regenerate object at {0}: No", index);
                }

                return d;
            }
        }

    }
}