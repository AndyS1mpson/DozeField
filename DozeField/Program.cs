using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace DozeField
{
    class Program
    {
        
        static void Main(string[] args)
        {
            (double,double)[] temp=new (double, double)[6];
            temp[0]=(7,7);
            temp[1]=(7,3);
            temp[2]=(4,4);
            temp[3]=(2,2);
            temp[4]=(1,5);
            temp[5]=(7,7);

            // Point[] myPointArray = {
            //    new Point(7,7),
            //    new Point(7,3),
            //    new Point(4,4),
            //    new Point(2,2),
            //    new Point(1,5)
            // };
            
            DozeField field=new DozeField(temp);
            //bool result=field.IsPointInField((5.714285714285714,3.428571428571429));
            // Console.WriteLine(result);
            var result = field.ClippingOfLine((4,4),(4,1));
            foreach(var el in result)
            {
            Console.WriteLine("{0},{1}",el.Item1,el.Item2);
            }
        }
    }
}
