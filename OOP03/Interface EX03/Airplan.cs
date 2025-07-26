using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_EX03
{
    internal class Airplan : IMoveable, IFlyable
    {
        int IMoveable.Speed { get  ; set ; }
        int IFlyable.Speed { get ; set ; }

         void IMoveable.Backward()
        {
            Console.WriteLine("Car IMoveable Backward"); ;
        }

         void IMoveable. Foward()
        {
            Console.WriteLine("Car IMoveable Foward"); ;
        }

         void IMoveable. Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

         void IMoveable. Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Car IFlyable Backward"); ;
        }

        void IFlyable.Foward()
        {
            Console.WriteLine("Car IFlyable Foward"); ;
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right");
        }
    }
}
