using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class InsertionSorter <T> : Sorter <T> where T : IComparable
    {
        public InsertionSorter(T[] myArray) : base(myArray)
        { }

        public override void Sort()
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                    {
                    if (myArray[j-1].CompareTo(myArray[j]) > 0)
                    {
                        Swap(ref myArray[j], ref myArray[j-1]);
                    }
                    j--;
                }
            }
        }
    }
}
