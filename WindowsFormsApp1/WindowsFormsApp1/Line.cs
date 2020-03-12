using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Segment
    {
        public (double x, double y) start;
        public (double x, double y) end;
        public (double x, double y) guideVector;
        public Segment((double x, double y) _srart, (double x, double y) _end)
        {
            start = _srart;
            end = _end;
            guideVector = (end.x - start.x,
                                                        end.y - start.y);
            double norm = Math.Sqrt(guideVector.Item1 * guideVector.Item1 + guideVector.Item2 * guideVector.Item2);
            guideVector.Item1 /= (norm * 10);
            guideVector.Item2 /= (norm * 10);
        }

        public bool IsPointOnSegment((double x, double y) point)
        {
            bool result = false;
            /*
                if point is on segment , must be true :
                0 <= (x-x1)(x2-x) <= (x2-x1)^2
                0 <= (y-y1)(y2-y) <= (y2-y1)^2
            */
            if (((point.x - start.x) * (end.x - point.x) <= (end.x - start.x) * (end.x - start.x)
                            && 0 <= (point.x - start.x) * (end.x - point.x))
                && (point.y - start.y) * (end.y - point.y) <= (end.y - start.y) * (end.y - start.y)
                            && 0 <= (point.y - start.y) * (end.y - point.y))
                result = true;
            return result;
        }

        //checking segment is in field or not
        public bool IsIn((double x, double t)[] vertices)
        {
            bool result = false;
            if ((start.x + guideVector.x, start.y + guideVector.y).IsPointInField(vertices))
            {
                if ((end.x - guideVector.x, end.y - guideVector.y).IsPointInField(vertices))
                    result = true;
            }
            return result;
        }
    }
    public struct Line
    {
        //ax+by+c=0;
        public double a;
        public double b;
        public double c;
        //find the coefficietns of the equation of the line passing through 2 points

        public Line((double x, double y) point1, (double x, double y) point2)
        {
            a = point2.y - point1.y;
            b = -(point2.x - point1.x);
            c = -b * point2.y - a * point2.x;
        }
        //find the coefficients of the equation of the perpendicular line passing current point
        public Line NormalTo((double x, double y) point)
        {
            Line normalLine;
            normalLine.a = b;
            normalLine.b = -a;
            normalLine.c = a * point.y - b * point.x;
            return normalLine;
        }

        //find intersection of 2 lines
        public (double x, double y) IntersectionWith(Line line)
        {
            (double x, double y) intersection;
            if (a != 0)
            {
                intersection.y = (line.a * c - line.c * a) / (a * line.b - line.a * b);
                intersection.x = (-b * intersection.y - c) / a;
            }
            else
            {
                intersection.y = -c / b;
                intersection.x = (line.b * c - line.c * b) / (line.a * b);
            }
            return intersection;
        }
    }
}
