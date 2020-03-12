using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Cosine
    {
        //cosine of angle between two vectors
        public static double Cos((double x, double y) vector1, (double x, double y) vector2)
            => (vector1.x * vector2.x + vector1.y * vector2.y)
                    / (Math.Sqrt(vector1.x * vector1.x + vector1.y * vector1.y)
                            * Math.Sqrt(vector2.x * vector2.x + vector2.y * vector2.y));
    }
}
