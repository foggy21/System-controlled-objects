using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlledObjects
{
    public class Pool<T> where T: IControlledObject
    {
        private Stack<T> cache;

        public Pool()
        {
            cache = new Stack<T>();
        }

        public T GetObject()
        {
            if (cache.Count > 0)
            {
                return cache.Pop();
            }
            else
            {
                return default(T);
            }
        }

        public void PushObject(T obj)
        {
            cache.Push(obj);
        }
    }
}
