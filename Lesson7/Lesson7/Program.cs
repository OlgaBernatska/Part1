using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = new int[5] { 5, 54, 86, 788, 7 };
            BubbleSorter<int> bubble = new BubbleSorter<int>(theArray);
            bubble.Print();
            bubble.Sort();
            bubble.Print();

            int[] thisArray = new int[6] { 5, 8563, 84, 3, 75, 56 };
            InsertionSorter<int> isort = new InsertionSorter<int>(thisArray);
            isort.Print();
            isort.Sort();
            isort.Print();
            Console.ReadKey();


            MyQueue<int> queue1 = new MyQueue<int>(4);
            queue1.Enqueue(34);
            queue1.Print();
            queue1.Enqueue(56);
            queue1.Print();
            queue1.Enqueue(8);
            queue1.Print();
            queue1.Enqueue(58);
            queue1.Print();

            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Dequeue());
            Console.WriteLine(queue1.Dequeue());

            MyStack<double> stack1 = new MyStack<double>(3);
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(0);
            stack1.Print();

            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());

             


            Console.ReadKey();
        }
    }
}
