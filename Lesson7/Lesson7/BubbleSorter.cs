using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class BubbleSorter <T> : Sorter<T> where T : IComparable
    {
        public BubbleSorter (T[]myArray) : base (myArray)
        {}

        public override void Sort()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j].CompareTo(myArray[j + 1]) > 0)
                    {
                        Swap(ref myArray[j], ref myArray[j + 1]);
                    }
                }
            }
        }
    }
}
