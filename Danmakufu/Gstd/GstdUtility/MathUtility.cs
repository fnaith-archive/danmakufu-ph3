using System;

namespace Gstd
{
    namespace GstdUtility
    {
        sealed class MathUtility
        {
            public static readonly double PAI = 3.14159265358979323846;
            public static double DegreeToRadian(double angle)
            {
                return angle * PAI / 180;
            }
            public static double RadianToDegree(double angle)
            {
                return angle * 180 / PAI;
            }
            /*public static double Round(double val)
            { TODO
                return floorl(val + 0.5);
            }*/
        }
    }
}
