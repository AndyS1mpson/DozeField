using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ConvertPointExtension
    {
        public static (double, double)[] ConvertToTuplesArray(this PointF[] points)
        {
            (double, double)[] convertPoints = new (double, double)[points.Length];
            for(int i = 0;i < points.Length; i++)
            {
                convertPoints[i] = (points[i].X, points[i].Y);
            }
            return convertPoints;
        }
        public static List<(PointF, PointF)> ConvertToTuplePointsList(this List<Segment> list)
        {
            List<(PointF,PointF)> pointList = new List<(PointF,PointF)>();
            for(int i = 0;i < list.Count; i++)
            {
                pointList.Add((new PointF((float)list[i].start.x, (float)list[i].start.y), (new PointF((float)list[i].end.x, (float)list[i].end.y))));
            }
            return pointList;
        }
        public static (double,double)[] ConvertFromListTo(this List<(double x,double y)> list)
        {
            (double, double)[] arr = new (double, double)[list.Count];
            for(int i = 0;i < list.Count; i++)
            {
                arr[i] = (list[i].x, list[i].y);
            }
            return arr;
        }
    }
}
