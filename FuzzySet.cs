using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class FuzzySet
    {
        //ten tap mo
        private string _name = "";
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string[] tenBNN = new string[10];

        //so bien ngon ngu
        public int SoBNN = 0;
        public FuzzySet(string a)
        {
            _name = a;
        }
        //Them bien ngon ngu vao tap mo
        public void Add(FuzzyVar a)
        {
            tenBNN[SoBNN] = a.Name;
            SoBNN++;
        }
        //////////////Cac luat danh gia
        //tam nhin gan
        public bool ForeSight_Is_Short(double FS)
        {
            if (FS < 100 && FS >= 0)
                return true;
            return false;
        }
        //tam nhin trung binh
        public bool ForeSight_Is_Medium(double FS)
        {
            if (FS <= 180 && FS >= 20)
                return true;
            return false;
        }
        //tam nhin xa
        public bool ForeSight_Is_Long(double FS)
        {
            if (FS > 100)
                return true;
            return false;
        }
        //duong nho
        public bool RoadWidth_Is_Small(double RW)
        {
            if (RW >= 1 && RW < 4)
                return true;
            return false;
        }
        //duong trung binh
        public bool RoadWidth_Is_Medium(double RW)
        {
            if (RW >= 1 && RW <= 7)
                return true;
            return false;
        }
        //duong lon
        public bool RoadWidth_Is_Big(double RW)
        {
            if (RW > 4 )
                return true;
            return false;
        }
        //Luu luong xe it
        public bool CarsInFront_is_Few(double CIF)
        {
            if (CIF >= 0 && CIF < 10)
                return true;
            return false;
        }
        //Luu luong xe trung binh
        public bool CarsInFront_is_Medium(double CIF)
        {
            if (CIF >= 0 && CIF <= 20)
                return true;
            return false;
        }
        //luu luong xe lon
        public bool CarsInFront_is_Many(double CIF)
        {
            if (CIF > 10)
                return true;
            return false;
        }
        //khoang cach ngan toi giao lo
        public bool Distance_Is_Short(double DI)
        {
            if (DI >= 0 && DI <100)
                return true;
            return false;
        }
        //khoang cach trung binh toi giao lo
        public bool Distance_Is_Medium(double DI)
        {
            if (DI >= 25 && DI <= 175)
                return true;
            return false;
        }
        //khoang cach lon toi giao lo
        public bool Distance_Is_Long(double DI)
        {
            if (DI > 100)
                return true;
            return false;
        }
        ///
        public static double Min(double a, double b, double c, double d)
        {
            double _min = 1.0;
            if (a <= _min)
                _min = a;
            if (b <= _min)
                _min = b;
            if (c <= _min)
                _min = c;
            if (d <= _min)
                _min = d;

            return _min;
        }

    }
}
