using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Membership_Function
    {
        public Membership_Function()
        { }
        //ham thuoc dang tam giac
        public static double Triangular_MF(double a, double b, double c, double x)
        {
            double membership = 0.0;
            if (x <= a)
                membership = 0;
            else if (x > a && x <= b)
                membership = (x - a) / (b - a);
            else if (x > b && x < c)
                membership = (c - x) / (c - b);
            else if (x >= c)
                membership = 0;
            return membership;
        }
        //ham thuoc dang hinh thang phai
        public static double RightTrapezoid_MF(double a, double b, double x)
        {
            double membership = 0.0;
            if (x <= a)
                membership = 0;
            else if (x > a && x < b)
                membership = (x - a) / (b - a);
            else if (x >= b)
                membership = 1;
            return membership;
        }
        //ham thuoc dang hinh thang trai
        public static double LeftTrapezoid_MF(double a, double b, double x)
        {
            double membership = 0.0;
            if (x <= a)
                membership = 1;
            else if (x > a && x < b)
                membership = (b - x) / (b - a);
            else if (x >= b)
                membership = 0;
            return membership;
        }
        //ham thuoc dang duong thang phai
        public static double RightLine_MF(double a, double b, double x)
        {
            double membership = 0.0;
            if (x <= a)
                membership = 0;
            else if (x > a && x < b)
                membership = (x - a) / (b - a);
            else if (x >= b)
                membership = 1;
            return membership;
        }
        //ham thuoc dang duong thang trai
        public static double LeftLine_MF(double a, double b, double x)
        {
            double membership = 0.0;
            if (x <= a)
                membership = 1;
            else if (x > a && x < b)
                membership = (b - x) / (b - a);
            else if (x >= b)
                membership = 0;
            return membership;
        }
        public static double Membership_Value(FuzzyVar a, double b)
        {
            if (a.MFtype == KieuHam.Triangular)
                return Membership_Function.Triangular_MF(a.P1, a.P2, a.P3, b);
            if (a.MFtype == KieuHam.RightTrapezoid)
                return Membership_Function.RightTrapezoid_MF(a.P1, a.P2, b);
            if (a.MFtype == KieuHam.LeftTrapezoid)
                return Membership_Function.LeftTrapezoid_MF(a.P2, a.P3, b);
            if (a.MFtype == KieuHam.RightLine)
                return Membership_Function.RightLine_MF(a.P1, a.P2, b);
            if (a.MFtype == KieuHam.LeftLine)
                return Membership_Function.LeftLine_MF(a.P2, a.P3, b);

            return 0;
        }
    }
}
