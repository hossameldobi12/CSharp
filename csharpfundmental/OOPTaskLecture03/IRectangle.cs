using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTaskLecture03
{
    internal interface IRectangle :IShape
    {
        double length { get;set; }  
        double width { get; set; }
    }
}
