using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DozeField
    {
        private (double, double)[] _vertices;
        public DozeField((double, double)[] vertices)
            => _vertices = vertices;

        public List<Segment> Clip((double x, double y) startOfSegment, (double x, double y) endOfSegment)
        {
            List<Segment> finalSetOfSegments = new List<Segment>();
            Line line = new Line(startOfSegment, endOfSegment);
            List<((double x, double y) point, double length)> interPointsArr = new List<((double x, double y), double length)>();
            interPointsArr.Add((startOfSegment, 0));

            //find all intersections of the line with the sides of the field
            for (int i = 0; i < _vertices.Length - 1; i++)
            {
                Line side = new Line(_vertices[i], _vertices[i + 1]);
                (double x, double y) curInter = side.IntersectionWith(line);
                Segment sideSegment = new Segment(_vertices[i], _vertices[i + 1]);
                bool check = sideSegment.IsPointOnSegment(curInter);
                if (check)
                {
                    interPointsArr.Add((curInter, Measure.Distance(startOfSegment, curInter)));

                    //sort the list by the distance to the beginning of the segment
                    for (int j = 1; j < interPointsArr.Count - 1; j++)
                    {
                        if (interPointsArr[j].length > interPointsArr[j + 1].length)
                        {
                            var temp = interPointsArr[j];
                            interPointsArr[j] = interPointsArr[j + 1];
                            interPointsArr[j + 1] = temp;
                        }
                    }
                }
            }
            interPointsArr.Add((endOfSegment, Measure.Distance(startOfSegment, endOfSegment)));
            for (int i = 0; i < interPointsArr.Count - 1; i++)
            {
                Segment segment = new Segment(interPointsArr[i].point, interPointsArr[i + 1].point);
                if (segment.IsIn(_vertices))
                    finalSetOfSegments.Add(segment);
            }
            return finalSetOfSegments;
        }
    }
}
