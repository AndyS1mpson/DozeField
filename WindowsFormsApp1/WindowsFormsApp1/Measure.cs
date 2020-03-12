using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Measure
    {
        //distance measurement function
        public static double Distance((double x, double y) point1, (double x, double y) point2)
            => Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
    }
}
