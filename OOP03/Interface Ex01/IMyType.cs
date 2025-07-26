using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_Ex01
{
    internal interface IMyType
    {
       
        //int X;

        //What can Write Inside The Interface:
        //1.Signature Of Properties
        //2.Signature Of Methods[Name ,Parameter ,Return Type]
        //3.Default Implemented Methods [Fully Implemented Methods]                            

        //2.Signature Of Methods[Name ,Parameter ,Return Type]
        void MyFun();

       
        //1.Signature Of Properties
        double Salary { set; get; }

        //3.Default Implemented Methods [Fully Implemented Methods]                            
        void Print() 
        {
            Console.WriteLine("Default Implemented Methods [Fully Implemented Methods] ");
        }

    }
}
