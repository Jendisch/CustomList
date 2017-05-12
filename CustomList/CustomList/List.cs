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
        T[] innerArray;
        bool trueOrFalse;

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

        public List()
        {
            length = 0;
            innerArray = new T[length];
        }

        public int CountList()
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


        //Mandatory Methods


        public int Count
        {
            get
            {
                return length;
            }
            private set { }
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
            trueOrFalse = FindIfListToBeRemovedHasOnlyOneItemInIt(trueOrFalse, newInnerArray, innerArray, item);
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

        public override string ToString()
        {
            StringBuilder builtString = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                builtString.Append(innerArray[i]);

                if (i != length - 1)
                {
                    builtString.Append(". ");
                }
            }
            return builtString.ToString();
        }

        public static List<T> operator + (List<T> list1, List<T> list2)
        {
            List<T> operatorList = new List<T>();
            for (int i = 0; i < list1.length; i++)
            {
                operatorList.Add(list1[i]);
            }
            for (int i = 0; i < list2.length; i++)
            {
                operatorList.Add(list2[i]);
            }
            return operatorList;
        }

        public static List<T> operator - (List<T> list1, List<T> list2)
        {
            List<T> operatorList = new List<T>();
            bool addToList = true;
            for (int i = 0; i < list1.length; i++)
            {
                for (int j = 0; j < list2.length; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        addToList = false;
                        break;
                    }
                }
                if (addToList == true)
                {
                    operatorList.Add(list1[i]);
                }
                addToList = true;
            }
            return operatorList;
        }

        public List<T> Zip(List<T> otherList)
        {
            int smallest = (length <= otherList.length) ? length : otherList.length;
            List <T> zipList = new List<T>();
            for (int i = 0; i < smallest; i++)
            {
                zipList.Add(innerArray[i]);
                zipList.Add(otherList[i]);
            }
            return zipList;
        }


        //Bonus Sort Methods


        public void SortAscending()
        {
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < length; j++)
                {

                }
            }
        }

        public int CompareLength(T list1, T list2)
        {
            string item1 = Convert.ToString(list1);
            string item2 = Convert.ToString(list2);
            int result = item1.Length.CompareTo(item2.Length);
            return result;
        }



        //Other Methods needed

        public void SetNewListAfterRemovedItemFound(int i, T[] newInnerArray)
        {
            for (int j = i; j < length; j++)
            {
                newInnerArray[j] = innerArray[j + 1];
            }
        }

        public bool FindIfListToBeRemovedHasOnlyOneItemInIt(bool trueOrFalse, T[] newInnerArray, T[] innerArray, T item)
        {
            trueOrFalse = FindIfListWithLengthOfOneHasItemWeAreLookingFor(item);
            if (length == 1 && trueOrFalse == true)
            {
                length--;
                newInnerArray = innerArray;
                return trueOrFalse;
            }
            return trueOrFalse;
        }

        public bool FindIfListWithLengthOfOneHasItemWeAreLookingFor(T item)
        {
            if (innerArray[0].Equals(item))
            {
                return true;
            }
            else
            {
                return false;
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
