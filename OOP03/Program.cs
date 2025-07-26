using OOP03.Interface_Ex01;
using OOP03.Interface_EX02;
using OOP03.Interface_EX03;
using System.Text;

namespace OOP03
{
    #region EX01
    // 1. Class
    // 2. Struct
    // 3. Enum
    // 4. Interfaces 
    #endregion

    internal class Program
    {
        #region Interface
        //static void Print10Number(SeriesByTwo series )
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //}
        //static void Print10Number(seriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //}
        //static void Print10Number(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //}
        //static void Print10Number(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current} ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //} 
        #endregion
        static void Main()
        {
            #region Revision
            //Class Vs Struct 
            //Inheritance : 
            //X ----> Y
            //RelationShips Between Classes
            //Polymorphism 
            #endregion

            #region Interface EX01
            //Inheritance :Reference Type
            //Code ContractBetween The Developer Who Write And The Developer Who Use It [Implementation]

            //IMyType myType = new IMyType();

            //Note: Can't Create Object From Any Interfaces


            //MyType mytype = new MyType();
            //mytype.MyFun();
            //Console.WriteLine(mytype.Salary);
            //mytype.MyFun();

            //IMyType myType1 = new IMyType() ;

            //myType1.MyFun();

            //IMyType mytype;
            ////Ref --> Can Refere To From Any Class Wich Implement The Interface 'IMyType'

            //mytype = new MyType();

            //mytype .Salary = 12000;
            //Console.WriteLine(mytype.Salary);
            //mytype.MyFun();
            //mytype.Print();

            #endregion

            #region Interfaces EX02
            ////SeriesByTwo seriesByTwo = new SeriesByTwo();
            ////seriesByThree seriesByThree = new seriesByThree();
            ////SeriesByFour seriesByFour = new SeriesByFour();

            ////Print10Number(seriesByFour);


            ////int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };
            ////Array.Sort(Numbers);

            ////foreach (int item in Numbers)
            ////{ 
            ////    Console.WriteLine($"{item} ");
            ////}

            //Employee[] employee = new Employee[3]
            //{
            //    new Employee (){ Id= 1, Name ="Ahmed ",Age =30,Salary =12000},
            //    new Employee (){ Id= 2, Name ="Ali ",Age =25,Salary =13000},
            //    new Employee (){ Id= 3, Name ="Amr",Age =27,Salary =18000}
            //};

            //Array.Sort(employee);
            //foreach (Employee item in employee)
            //{
            //    Console.WriteLine(item);            
            //} 
            #endregion

            #region Interface EX03
            ////Car car = new Car();

            ////car.Speed = 120;
            ////car.Foward();

            //Airplan airplan = new Airplan();

            //IMoveable moveable = airplan;
            //moveable.Foward();

            //IFlyable flyable =airplan;
            //flyable.Foward(); 
            #endregion

            #region Shallow Copy VS Deep Copy
            //Shallow Copy VS Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Ziad", "Adel", "Amr" };

            // StringBuilder[] Arr01 = new StringBuilder[]
            // {
            //     new StringBuilder("Ahmed"),
            //     new StringBuilder("Ali"),
            //     new StringBuilder("Omar")
            // };

            // StringBuilder[] Arr02 = new StringBuilder[]
            //{
            //     new StringBuilder("Ziad "),
            //     new StringBuilder("Adel"),
            //     new StringBuilder("Amr")
            //};


            //Console.WriteLine($"Arr01:{Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02:{Arr02.GetHashCode()}");

            //Arr01 = (StringBuilder[]) Arr01.Clone(); //Shallow Copy
            ////Copy Identity
            ////{1,2,3}---> Has two  Reference Arr01, Arr02
            ////{4,5,6}---> UnReachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01:{Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02:{Arr02.GetHashCode()}");

            ////Identity (Address) = Object State [Data]

            //Arr02[0] .Append( "Ahmed Amin ");

            //Console.WriteLine(Arr01[0]);


            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01:{Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02:{Arr02.GetHashCode()}");

            //Arr01 = (int[]) Arr02.Clone(); //Deep Copy
            ////Clone Method Will Copy The Object State Of Caller 
            ////Assign The New Object To Arr02,Will Generete New Identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01:{Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02:{Arr02.GetHashCode()}");

            ////Identity (Address) = Object State [Data]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); 
            #endregion


            #region Built-In Interface ICloneable 
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Amr", Age = 32, Salary = 11000 };


            ////E02 = E01; //Shallow Copy
            ////E02 = (Employee)E01.Clone(); //Deep Copy
            //E02 = new Employee(E01); //Deep Copy ->Copy Constructor


            //E01.Salary = 5;

            //Console.WriteLine(E01.GetHashCode);
            //Console.WriteLine(E02.GetHashCode);
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            #endregion


            #region Built-In Interface ICompareable
            //Employee[] employee = new Employee[3]
            //{
            //    new Employee (){ Id= 1, Name ="Ahmed ",Age =30,Salary =12000},
            //    new Employee (){ Id= 2, Name ="Ali ",Age =25,Salary =13000},
            //    new Employee (){ Id= 3, Name ="Amr",Age =27,Salary =18000}
            //};

            //Array.Sort(employee);


            ////int X = employee[1].CompareTo(employee[0]);
            //////+ve: Caller Greater than Parameter
            //////-ve: Caller less than Parameter
            //////0:Caller Equal Parameter


            ////Console.WriteLine(X);


            //foreach (Employee item in employee)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            Employee[] employee = new Employee[3]
            {
                new Employee (){ Id= 1, Name ="Ahmed ",Age =30,Salary =12000},
                new Employee (){ Id= 2, Name ="Ali ",Age =25,Salary =13000},
                new Employee (){ Id= 3, Name ="Amr",Age =27,Salary =18000}
            };

            //Array.Sort(employee, new EmployeeComparerSalary());
            Array.Sort(employee, new EmployeeComparerNameLength());
            
            
            foreach (Employee item in employee)
            {
                Console.WriteLine(item);
            }

        }
    }
}
