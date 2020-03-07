using System;

namespace DozeField
{
    class Program
    {
        static void Main(string[] args)
        {
            (double,double)[] temp=new (double, double)[5];
            temp[0]=(7,7);
            temp[1]=(7,3);
            temp[2]=(4,-3);
            temp[3]=(5,6);
            temp[4]=(7,7);
            DozeField field=new DozeField(temp);
            bool result=field.IsPointInField((4,-3));
            Console.WriteLine(result);
        }
    }
}
