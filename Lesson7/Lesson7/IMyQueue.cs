using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface IMyQueue <T>
    {
        void Enqueue(T a);
        T Dequeue();
    }
}
