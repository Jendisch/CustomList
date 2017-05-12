using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {

            

        }
    }
}
//public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
//{
//    CustomList<T> newList = new CustomList<T>();
//    bool add = true;
//    for (int i = 0; i < list1._size; i++)
//    {
//        for (int j = 0; j < list2._size; j++)
//        {
//            if (list1[i].Equals(list2[j]))
//            {
//                add = false;
//                break;
//            }
//        }
//        if (add)
//        {
//            newList.Add(list1[i]);
//        }
//        add = true;
//    }
//    return newList;
//}