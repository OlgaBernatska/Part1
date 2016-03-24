using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        public MyStack(int Size) : base(Size)
        { }

        public T Pop()
        {
            if (!isEmpty())
            {
                T x = myArray[i - 1];
                --i;
                return x;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default (T);
            }
        }

        public void Push(T a)
        {
            if (!isFull())
            {
                myArray[i++] = a;
            }
            else
            {
                Console.WriteLine("Stack is full");
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