using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP3
{
    internal interface IRectangle:IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
