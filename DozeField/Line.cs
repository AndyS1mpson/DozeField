using System;
using System.Collections.Generic;

namespace DozeField
{
    public class Segment
    {
        public (double x,double y) startOfSegment;
        public (double x,double y) endOfSegment;
        public (double x,double y) guideVector;
        public Segment((double x,double y) _srartOfSegment,(double x,double y) _endOfSegment)
            {
                startOfSegment = _srartOfSegment;
                endOfSegment = _endOfSegment;
                guideVector = (endOfSegment.x - startOfSegment.x,
                                                            endOfSegment.y - startOfSegment.y);
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
            if(((point.x - startOfSegment.x) * (endOfSegment.x - point.x) <= (endOfSegment.x - startOfSegment.x) * (endOfSegment.x - startOfSegment.x) 
                            && 0 <= (point.x - startOfSegment.x) * (endOfSegment.x - point.x))
                && (point.y - startOfSegment.y) * (endOfSegment.y - point.y) <= (endOfSegment.y - startOfSegment.y) * (endOfSegment.y - startOfSegment.y) 
                            && 0 <= (point.y - startOfSegment.y) * (endOfSegment.y - point.y))
            {
                if(endOfSegment.x >= startOfSegment.x)
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
        public Line NormalLine((double x,double y) point)
        {
            Line normalLine;
            normalLine.a = b;
            normalLine.b = -a;
            normalLine.c = a * point.y - b * point.x;
            return normalLine;
        }
        
        //find intersection of 2 lines
        public static (double x,double y) IntersectionOfLines(Line line1,Line line2)
        {
            (double x,double y) intersection;
            if(line1.a !=0)
            {
                intersection.y = (line2.a * line1.c - line2.c * line1.a) / (line1.a * line2.b - line2.a * line1.b);
                intersection.x = (-line1.b * intersection.y - line1.c) / line1.a;
            }
            else
            {
                intersection.y = -line1.c / line1.b;
                intersection.x = (line2.b * line1.c - line2.c * line1.b) / (line2.a * line1.b);
            }
            return intersection;
        }

        //checking segment is in field or not
        public bool IsSegmentInField(Segment segment,(double x,double t)[] vertices)
        {
            bool result = false;
            bool check = PointExtension.IsPointInField(segment.startOfSegment,vertices);
            if(check == true && PointExtension.IsPointInField((segment.startOfSegment.x + segment.guideVector.x
                                                                    ,segment.startOfSegment.y + segment.guideVector.y),vertices))
            {
                bool check2 = PointExtension.IsPointInField(segment.endOfSegment,vertices);
                if(check2 == true && PointExtension.IsPointInField((segment.endOfSegment.x - segment.guideVector.x
                                                                    ,segment.endOfSegment.y - segment.guideVector.y),vertices))
                result = true;
            }
            return result;
        }

        public List<Segment>  ClippingOfLine((double x,double y) startOfSegment,(double x,double y) endOfSegment,(double x,double t)[] vertices)
        {
            
            List<Segment> finalSetOfSegments = new List<Segment>();
            Line line = new Line(startOfSegment,endOfSegment);
            List<((double x,double y) point,double length)> interPointsMas = new List<((double x,double y), double length)>();
            interPointsMas.Add((startOfSegment,0));

            //find all intersections of the line with the sides of the field
            for(int i = 0; i < vertices.Length - 1; i++)
            {
                Line side = new Line(vertices[i],vertices[i+1]);
                (double x,double y) curInter = IntersectionOfLines(side,line);
                Segment sideSegment = new Segment(vertices[i],vertices[i+1]);
                int check = sideSegment.IsPointOnSegment(curInter);
                if(check == 1 || check ==2)
                    {
                        interPointsMas.Add((curInter,Measure.Distance(startOfSegment,curInter)));
                        
                        //sort the list by the distance to the beginning of the segment
                        for(int j = 1; j < interPointsMas.Count - 1; j++)
                        {
                            if(interPointsMas[j].length > interPointsMas[j+1].length)
                            {
                                var temp = interPointsMas[j];
                                interPointsMas[j] = interPointsMas[j+1];
                                interPointsMas[j + 1] = temp;
                            }
                        }
                    }
            }
            interPointsMas.Add((endOfSegment,Measure.Distance(startOfSegment,endOfSegment)));

            for(int i = 0; i < interPointsMas.Count - 1; i++)
            {
                Segment segment = new Segment(interPointsMas[i].point,interPointsMas[i+1].point);
                if(IsSegmentInField(segment,vertices))
                    finalSetOfSegments.Add(segment);
            }
            return finalSetOfSegments;
        }

    
    }
}