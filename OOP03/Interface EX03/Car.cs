using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_EX03
{
    internal class Car : IMoveable
    {
        public int Speed { get ; set ; }

        public void Backward()
        {
            Console.WriteLine("Car IMoveable Backward"); ;
        }

        public void Foward()
        {
            Console.WriteLine("Car IMoveable Foward"); ;
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }
    }
}
