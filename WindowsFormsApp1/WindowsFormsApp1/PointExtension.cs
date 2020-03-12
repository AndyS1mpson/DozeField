using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class PointExtension
    {
        //check point is in field or not
        public static bool IsPointInField(this (double x, double y) point, (double x, double y)[] vertices)
        {
            bool result = false;
            (double x, double y) normalVectorOfSide = (0, 0);           // normal vector of the current side
            (double x, double y) guideVectorOfLine = (0, 0);            // line direction vector from point to intersection
            (double x, double y) intersection;                          // intersection of 2 lines
            double distance = 0;                                        // vector length

            for (int i = 0; i < vertices.Length - 1; i++)
            {
                if (point == vertices[i])
                {
                    result = true;
                    break;
                }
                Line checkingSide;                                      // equation coefficients of the current side
                Line checkingLine;                                      // equation coefficients of the line perpendicular to the side
                (double x, double y) curInter;                          // intersection of current side and current line
                (double x, double y) curGuideVector;

                checkingSide = new Line(vertices[i], vertices[i + 1]);
                checkingLine = checkingSide.NormalTo(point);
                curInter = checkingSide.IntersectionWith(checkingLine);
                curGuideVector = (curInter.x - point.x, curInter.y - point.y);

                double curDistance = Measure.Distance(curInter, point);
                if (distance > curDistance || distance == 0)
                {
                    Segment sideSegment = new Segment(vertices[i], vertices[i + 1]);

                    bool check = sideSegment.IsPointOnSegment(curInter);
                    if (check)
                    {
                        normalVectorOfSide = (-checkingSide.a, -checkingSide.b);
                        guideVectorOfLine = curGuideVector;
                        intersection = curInter;
                        distance = curDistance;
                    }

                }
            }
            if (Cosine.Cos(normalVectorOfSide, guideVectorOfLine) >= 0)
                result = true;
            return result;
        }
    }
}
