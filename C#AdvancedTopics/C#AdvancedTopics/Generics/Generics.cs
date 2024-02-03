using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedTopics.Generics
{
    public class Generics<T>
    {
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
        }

        public T this[int index]
        {
            get { throw new Exception(); }
        }
    }
}
