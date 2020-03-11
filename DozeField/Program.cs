using System;
using System.Diagnostics;

namespace DozeField
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            (double x,double y)[] temp = new (double,double)[6];
            temp[0] = (7,7);
            temp[1] = (7,3);
            temp[2] = (4,4);
            temp[3] = (2,2);
            temp[4] = (1,5);
            temp[5] = (7,7);    
            //(double,double) point = (7.1,7.1);
            //Console.WriteLine(point.IsPointInField(temp)); 
            Segment segment = new Segment((4,5),(7,10));
            Line line = new Line((4,5),(7,10));
            DozeField field = new DozeField(temp);
            stopWatch.Start();
            var result = field.Clip(segment.start,segment.end);
            stopWatch.Stop();
            long ts = stopWatch.ElapsedMilliseconds;
            foreach(var el in result)
            {
                Console.WriteLine("{0},{1}",el.start,el.end);
            }
            Console.WriteLine(ts);
        }
    }
}
