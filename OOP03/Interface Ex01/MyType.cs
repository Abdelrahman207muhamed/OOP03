using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_Ex01
{
    internal class MyType : IMyType //->Implement 
    {
        public double Salary
        { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
