using System;

namespace DozeField
{
    class Program
    {
        static void Main(string[] args)
        {
            (double,double)[] temp=new (double, double)[5];
            temp[0]=(1,3);
            temp[1]=(3,-4);
            temp[2]=(-4,-5);
            temp[3]=(-1,4);
            temp[4]=(1,3);
            DozeField field=new DozeField(temp);
            bool result=field.PointAffiliationAlgorithm((1,-3));
            Console.WriteLine(result);
        }
    }
}
