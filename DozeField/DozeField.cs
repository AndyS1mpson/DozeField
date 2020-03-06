using System;

namespace DozeField
{
    public class DozeField
    {
        private (double,double)[] _field;   //polygon

        public DozeField((double,double)[] field)
        {
            _field=field;
        }
        //metric measurement function
        public double Metric((double,double) point1,(double,double) point2)
        {
            double metric=Math.Sqrt((point1.Item1-point2.Item1)*(point1.Item1-point2.Item1)
                                        +(point1.Item2-point2.Item2)*(point1.Item2-point2.Item2));
            return metric;
        }

        //Find the equiption coefficients 2 perpendicular straights
        public (double,double,double[,])  FindingIntersectionOfPerpendicularStraights((double,double) point1,(double,double) point2,(double,double) point0)
        {
            double[,] equationCoefficients=new double[2,3];
            //ax+by+c=0 -current side of field
            equationCoefficients[0,0]=point2.Item2-point1.Item2;                    //a
            equationCoefficients[0,1]=-(point2.Item1-point1.Item1);                 //b
            equationCoefficients[0,2]=-equationCoefficients[0,1]*point1.Item2       //c
                                        -equationCoefficients[0,0]*point1.Item1;
            //a1x+b1y+c1=0 - coefficients straight perpendicular to the side                             
            equationCoefficients[1,0]=equationCoefficients[0,1];                    //a1
            equationCoefficients[1,1]=-equationCoefficients[0,0];                   //b1
            equationCoefficients[1,2]=equationCoefficients[0,0]*point0.Item2        //c1
                                         - equationCoefficients[0,1]*point0.Item1;

            (double,double,double[,]) intersectionOfLines;
            intersectionOfLines.Item2=(equationCoefficients[0,0]*equationCoefficients[1,2]
                                            -equationCoefficients[0,1]*equationCoefficients[0,2])
                                            /(equationCoefficients[0,1]*equationCoefficients[0,1]
                                            +equationCoefficients[0,0]*equationCoefficients[0,0]);
            intersectionOfLines.Item1=(-equationCoefficients[0,1]*intersectionOfLines.Item2
                                            -equationCoefficients[0,2])/equationCoefficients[0,0];
            double[,] normalCoordinates=new double[2,2];
            normalCoordinates[0,0]=-equationCoefficients[0,0];
            normalCoordinates[0,1]=-equationCoefficients[0,1];
            normalCoordinates[1,0]=intersectionOfLines.Item1-point0.Item1;
            normalCoordinates[1,1]=intersectionOfLines.Item2-point0.Item2;
            intersectionOfLines.Item3=normalCoordinates;
            return intersectionOfLines;
        }

        public double CosBetweenVectors(double[,] vectors)
        {
            double cos=(vectors[0,0]*vectors[1,0]+vectors[0,1]*vectors[1,1])/Math.Sqrt(vectors[0,0]*vectors[0,0]+vectors[0,1]*vectors[0,1])
                                        *Math.Sqrt(vectors[1,0]*vectors[1,0]+vectors[1,1]*vectors[1,1]);
            return cos;
        }
        //Check the point for belonging to the polygon 
        public bool PointAffiliationAlgorithm((double,double) point)
        {
            
             // Intersection perpendicular straights 
             (double,double,double[,]) intersection=FindingIntersectionOfPerpendicularStraights(_field[0],_field[1],point);
            double minLength=Metric(point,(intersection.Item1,intersection.Item2));
            
            //Find min distance to the sides
            for(int i=1;i< _field.Length-1;i++)
            {
                (double,double,double[,]) nextIntersection=FindingIntersectionOfPerpendicularStraights(_field[i],_field[i+1],point);
                if(minLength>Metric(point,(nextIntersection.Item1,nextIntersection.Item2)))
                    if(_field[i].Item1<_field[i+1].Item1)
                        if(nextIntersection.Item1<_field[i+1].Item1 && nextIntersection.Item1>_field[i].Item1)
                            intersection=nextIntersection;
                    else if(_field[i].Item1>_field[i+1].Item1)
                        if(nextIntersection.Item1>_field[i+1].Item1 && nextIntersection.Item1<_field[i].Item1)
                            intersection=nextIntersection;

            }
            bool signCos;        //cosine sign of the angle between normal and guide vectors  
                                 //+ == true , - == false
            //if(intersection.Item3[0,0] == -intersection.Item3[1,1])
            if(CosBetweenVectors(intersection.Item3)>=0)
                signCos=true;
            else signCos=false;
            return signCos;
        }
    }
}