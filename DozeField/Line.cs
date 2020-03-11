using System;
using System.Collections.Generic;

namespace DozeField
{
    public class Segment
    {
        public (double x,double y) start;
        public (double x,double y) end;
        public (double x,double y) guideVector;
        public Segment((double x,double y) _srart,(double x,double y) _end)
            {
                start = _srart;
                end = _end;
                guideVector = (end.x - start.x,
                                                            end.y - start.y);
                double norm = Math.Sqrt(guideVector.Item1 * guideVector.Item1 + guideVector.Item2 * guideVector.Item2);
                guideVector.Item1 /= norm;
                guideVector.Item2 /= norm;
            }

        public int IsPointOnSegment((double x,double y) point)
        {
            int result = 0;
            /*
                if point is on segment , must be true :
                0 <= (x-x1)(x2-x) <= (x2-x1)^2
                0 <= (y-y1)(y2-y) <= (y2-y1)^2
            */
            if(((point.x - start.x) * (end.x - point.x) <= (end.x - start.x) * (end.x - start.x) 
                            && 0 <= (point.x - start.x) * (end.x - point.x))
                && (point.y - start.y) * (end.y - point.y) <= (end.y - start.y) * (end.y - start.y) 
                            && 0 <= (point.y - start.y) * (end.y - point.y))
            {
                if(end.x >= start.x)
                    result = 1;
                else result =2;
            }
            return result;

            // if(startOfSegment.x <= endOfSegment.x)
            // {
            //     if(point.x >= startOfSegment.x && point.x <= endOfSegment.x)
            //     if((startOfSegment.y <= endOfSegment.y && point.y >= startOfSegment.y && point.y <= endOfSegment.y)
            //             || (startOfSegment.y >= endOfSegment.y && point.y <= startOfSegment.y && point.y >= endOfSegment.y))
            //         result = 1;
            // }
            // else if(startOfSegment.x >= endOfSegment.x)
            // {
            //     if(point.x <= startOfSegment.x && point.x >= endOfSegment.x)
            //     if((startOfSegment.y <= endOfSegment.y && point.y >= startOfSegment.y && point.y <= endOfSegment.y)
            //             || (startOfSegment.y >= endOfSegment.y && point.y <= startOfSegment.y && point.y >= endOfSegment.y))
            //         result = 2;
            // }
            //return result;
        }

        //checking segment is in field or not
        public bool IsIn((double x,double t)[] vertices)
        {
            bool result = false;
            bool check = PointExtension.IsPointInField(start,vertices);
            if(check == true && PointExtension.IsPointInField((start.x + guideVector.x
                                                                    ,start.y + guideVector.y),vertices))
            {
                bool check2 = PointExtension.IsPointInField(end,vertices);
                if(check2 == true && PointExtension.IsPointInField((end.x - guideVector.x
                                                                    ,end.y - guideVector.y),vertices))
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

        public Line((double x,double y) point1,(double x, double y) point2)
        {   
            a = point2.y - point1.y;
            b = -(point2.x - point1.x);
            c = -b * point2.y - a * point2.x;
            var normCoef = (c >0 ? -1 : 1) / Math.Sqrt(a * a + b * b);
            a *= normCoef;
            b *= normCoef;
            c *= normCoef;
        }
        //find the coefficients of the equation of the perpendicular line passing current point
        public Line NormalTo ((double x,double y) point)
        {
            Line normalLine;
            normalLine.a = b;
            normalLine.b = -a;
            normalLine.c = a * point.y - b * point.x;
            return normalLine;
        }
        
        //find intersection of 2 lines
        public (double x,double y) IntersectionWith(Line line)
        {
            (double x,double y) intersection;
            if(a !=0)
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