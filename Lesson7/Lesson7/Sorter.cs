using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    abstract public class Sorter <T> : ISorter<T>
    {
        public T[] myArray;

        public Sorter(T[] myArray)
        {
            this.myArray = myArray;
        }

        public abstract void Sort();

        public void Print()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        public void Swap(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }
    }
}
