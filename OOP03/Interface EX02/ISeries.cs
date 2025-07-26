using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface_EX02
{
    //0 2 4 6 8 10
    // 0 3 6 9 12 15
    // 0 4 8 12  16 20

    internal interface ISeries
    { 
        int Current { set; get; } //Signature of property
        void Next();
        void Reset();

    }
}
