using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    abstract public class Buffer <T> : IBuffer <T>
    {
        public T[] myArray = null;
        public int i = 0;

        public Buffer(int Size)
        {
            myArray = new T [Size];
        }

        public bool isEmpty()
        {
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isFull()
        {
            {
                if (i == myArray.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        abstract public T Peek();

        public void Print()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
