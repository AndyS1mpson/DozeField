using System;

namespace DozeField
{
    public struct Line
    {
        // ax+by+c=0;
        public double a;
        public double b;
        public double c;
        public Line(double _a,double _b,double _c)
        {
            var normCoef = (_c > 0 ? -1 : 1) / Math.Sqrt(_a * _a + _b * _b);

            a = _a * normCoef;
            b = _b * normCoef;
            c = _c * normCoef;
        }
        
    }
    public class DozeField
    {
        private (double,double)[] _field;

        public DozeField((double,double)[] field)
            =>_field=field;
        
        //metric measurement function
        public double Metric((double,double) point1,(double,double) point2)
        {
            double metric=Math.Sqrt((point1.Item1-point2.Item1)*(point1.Item1-point2.Item1)
                                        +(point1.Item2-point2.Item2)*(point1.Item2-point2.Item2));
            return metric;
        }
        
        //find the coefficients of the equation of the line passing through 2 points
        public Line FindCoefficientsOfEquation((double,double) point1, (double,double) point2)
        {
            double a = point2.Item2-point1.Item2;
            double b = -(point2.Item1-point1.Item1);
            double c = -b*point2.Item2           
                            -a*point2.Item1;
            Line coefficients=new Line(a,b,c);
            return coefficients;
        }

        //find the coefficients of the equation of the perpendicular line passing current point
        public Line FindNormalCoefficients(Line lineCoefficients,(double,double) point0)
        {
            Line normalCoefficients;
            normalCoefficients.a = lineCoefficients.b;
            normalCoefficients.b = -lineCoefficients.a;
            normalCoefficients.c = lineCoefficients.a*point0.Item2
                                    - lineCoefficients.b*point0.Item1;
            return normalCoefficients;
        }
    
        //find intersection of perpendicular lines
        public (double,double) IntersectionOfPerpendicularLines(Line line,Line normalLine)
        {
            (double,double) intersection;
            intersection.Item2 = (line.a*normalLine.c - line.b*line.c)/(line.a*line.a + line.b*line.b);
            intersection.Item1 = (-line.b*intersection.Item2 -line.c)/line.a;
            return intersection;
        }
    
        //cosine of angle between two vectors
        public double CosOfAngleBetweenVectors((double,double) vector1,(double,double) vector2)
        {
            double cos=(vector1.Item1*vector2.Item1 + vector1.Item2*vector2.Item2)
                                        /Math.Sqrt(vector1.Item1*vector1.Item1 + vector1.Item2*vector1.Item2)
                                        *Math.Sqrt(vector2.Item1*vector2.Item1 + vector2.Item2*vector2.Item2);
            return cos;
        }

        // check point is in field or not
        public bool IsPointInField((double,double) point)
        {
            bool result=false;
            (double,double) normalSideVector=(0,0);             // normal vector of the current side
            (double,double) guideLineVector=(0,0);              // line direction vector from point to intersection
            (double,double) intersection;                       // intersection of 2 lines
            double lengthGuideLineVector=0;                     // vector length
            
            for(int i=0;i<_field.Length-1;i++)
            {
                if(point == _field[i])
                {       
                    result=true;
                    break;
                }
                
                Line checkingSide;                              // equation coefficients of the current side
                Line checkingLine;                              // equation coefficients of the line perpendicular to the side
                (double,double) curInter;
                (double,double) guideCurLineVector;
                checkingSide = FindCoefficientsOfEquation(_field[i],_field[i+1]);
                checkingLine = FindNormalCoefficients(checkingSide,point);
                curInter = IntersectionOfPerpendicularLines(checkingSide,checkingLine);
                guideCurLineVector = (curInter.Item1 - point.Item1,curInter.Item2 - point.Item2);

                if(lengthGuideLineVector>Metric(curInter,point) || lengthGuideLineVector==0)
                    if(_field[i].Item1 <= _field[i+1].Item1)
                        {
                            if(curInter.Item1 >= _field[i].Item1 && curInter.Item1 <= _field[i+1].Item1)
                            if((_field[i].Item2 < _field[i+1].Item2 && curInter.Item2 >= _field[i].Item2 && curInter.Item2 <= _field[i+1].Item2)
                                         || (_field[i].Item2 > _field[i+1].Item2 && curInter.Item2 >= _field[i+1].Item2 && curInter.Item2 <= _field[i].Item2))
                            {
                                normalSideVector = (-checkingSide.a,-checkingSide.b);
                                guideLineVector = guideCurLineVector;
                                intersection = curInter;
                                lengthGuideLineVector = Metric(curInter,point);
                            }
                        }
                    else if(_field[i].Item1 > _field[i+1].Item1)
                        if(curInter.Item1 <= _field[i].Item1 && curInter.Item1 >= _field[i+1].Item1)
                        if((_field[i].Item2 < _field[i+1].Item2 && curInter.Item2 >= _field[i].Item2 && curInter.Item2 <= _field[i+1].Item2)
                                         || (_field[i].Item2 > _field[i+1].Item2 && curInter.Item2 >= _field[i+1].Item2 && curInter.Item2 <= _field[i].Item2))
                        {
                            normalSideVector = (checkingSide.a,checkingSide.b);
                            guideLineVector = guideCurLineVector;
                            intersection = curInter;
                            lengthGuideLineVector = Metric(curInter,point);
                        }


            }
            if(CosOfAngleBetweenVectors(normalSideVector,guideLineVector)>=0)
                result=true;
                
        return result;
        }
    
    }
}