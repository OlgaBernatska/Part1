using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        public MyQueue(int Size) : base(Size)
        { }

        public void Enqueue(T a)
        {
            if (!isFull())
            {
                myArray[i] = a;
                i = i + 1;
            }
            else
            {
                Console.WriteLine("Queue is full");
            }
        }

        public T Dequeue()
        {
            if (!isEmpty())
            {
                T x = myArray[0];
                for (int d = 0; d < i - 1; d++)
                {
                    myArray[d] = myArray[d + 1];
                }
                i = i--;
                return x;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
        }
        public override T Peek()
        {
            if (!isEmpty())
            {
                T x = myArray[i - 1];
                return x;
            }
            else
            {
                return default(T);
            }
        }
    }
}
