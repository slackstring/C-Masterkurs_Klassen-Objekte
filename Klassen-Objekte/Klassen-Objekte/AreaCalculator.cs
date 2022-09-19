using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Objekte
{
    static class AreaCalculator
    {
       //Eigenschaften
       // =>Keine Eigenschaften notwendig
       //Methoden
       static public double GetRectangleArea (double höhe,double breite)
        {
            return höhe*breite;
        }
        static public double GetSquareArea (double seitenlänge)
        {
            return seitenlänge*seitenlänge;
        }
        static public double GetCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }
        static public double GetTriangleArea(double höhe, double grundseitelänge)
        {
            return (höhe * grundseitelänge) / 2;
        }

    }
}
