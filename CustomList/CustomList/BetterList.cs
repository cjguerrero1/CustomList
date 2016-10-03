using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class BetterList<T>: IEnumerable
    {
     
        private int defaultCapacity = 5;
        private T[] hiddenArray;
        private int arraySize;
        static readonly T[] emptyArray = new T[0];

        public BetterList()
        {
            hiddenArray = emptyArray;
        }

        public BetterList(int capacity)
        {
            if (capacity == 0)
            {
                hiddenArray = emptyArray;
            }
            else
            {
                hiddenArray = new T[capacity];
            }
        }

        public int Count()
        {
            int count = 0;
            foreach(T item in hiddenArray)
            {
                count++;
            }
            return count;
        }

        public void Add(T item)
        {
            if(arraySize == Count())
            {
                GrowArray(arraySize + 1);
            }
            hiddenArray[arraySize++] = item;
        }

        public void Remove(T item)
        {

        }

        public static BetterList<T> operator +(BetterList<T>, BetterList<T>)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

            public void AddLists()
            {

            }

        public void GrowArray(int minimumCapacity)
        {
            if (Count() < minimumCapacity)
            {
                int newCapacity;
                if (Count() == 0)
                {
                    newCapacity = defaultCapacity;
                }
                else
                {
                    newCapacity = Count() * 2;
                }
                arraySize = newCapacity;
            }
        }




        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

