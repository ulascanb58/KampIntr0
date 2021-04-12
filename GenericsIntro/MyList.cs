using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>
    {
        T[] items;

        public MyList()
        {
            items= new T[0];
        }
        
        public void Add(T item)
        {
            T[] tempArray;
            tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] Items
        {
            get { return items; }
        }

        public int Length
        {
            get { return items.Length; }
        }

    }
}
