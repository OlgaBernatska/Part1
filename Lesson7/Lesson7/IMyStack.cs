using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface IMyStack <T>
    {
        void Push(T a);
        T Pop();
    }
}
