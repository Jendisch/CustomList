using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class List<T> : IEnumerable
    {

        int length;
        public T[] innerArray;
        bool trueOrFalse;

        public List()
        {
            length = 0;
            innerArray = new T[length];
        }

        public int Count
        {
            get
            {
                return length;
            }
            private set { }
        }

        public int Capacity()
        {
            int count = 0;
            for (int i = 0; i < innerArray.Length; i++)
            {
                count++;
            }
            return count;
        }

        public T this[int i]
        {
            get
            {
                return innerArray[CheckTheIndex(i)];
            }

            set
            {
                innerArray[CheckTheIndex(i)] = value;
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < innerArray.Length; i++)
            {
                yield return innerArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public void Add(T item)
        {
            T[] newInnerArray = new T[length + 1];

            for (int i = 0; i < length; i++)
            {
                newInnerArray[i] = innerArray[i];
            }
            newInnerArray[length] = item;

            innerArray = newInnerArray;
            length++;
        }

        public bool Remove(T item)
        {
            T[] newInnerArray = new T[length - 1];
            trueOrFalse = false;
            for (int i = 0; i < length - 1; i++)
            {
                trueOrFalse = FindEqualItem(item, i);
                if (trueOrFalse == true)
                {
                    length--;
                    SetNewListAfterRemovedItemFound(i, newInnerArray);
                    newInnerArray[i] = innerArray[i + 1];
                    break;
                }
                else
                {
                    newInnerArray[i] = innerArray[i];
                }
            }
            innerArray = newInnerArray;
            return trueOrFalse;
        }

        public void SetNewListAfterRemovedItemFound(int i, T[]newInnerArray)
        {
            for (int j = i; j < length; j++)
            {
                newInnerArray[j] = innerArray[j + 1];
            }
        }

        public bool FindEqualItem(T item, int i)
        {

            if (innerArray[i].Equals(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CheckTheIndex(int i)
        {
            if (i >= 0 && i < length)
            {
                return i;
            }
            else
            {
                throw new ArgumentOutOfRangeException("i");
            }
        }



}
}
