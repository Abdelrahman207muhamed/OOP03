using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_EX03
{
    internal interface IMoveable
    {
        int Speed { get; set; }
        void Foward();
        void Backward();
        void Right();
        void Left();
    }
}
