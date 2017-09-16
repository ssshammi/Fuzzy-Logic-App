using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class FuzzyVar
    {


        //Ten bien ngon ngu
        private string _name = "";
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        //Kieu ham thuoc
        private KieuHam _MFtype = 0;
        public KieuHam MFtype
        {
            set { _MFtype = value; }
            get { return _MFtype; }
        }
        //Moc gia tri thu nhat
        private double _p1 = 0.0;
        public double P1
        {
            set { _p1 = value; }
            get { return _p1; }
        }
        //Moc gia tri thu hai
        private double _p2 = 0.0;
        public double P2
        {
            set { _p2 = value; }
            get { return _p2; }
        }
        //Moc gia tri thu ba
        private double _p3 = 0.0;
        public double P3
        {
            set { _p3 = value; }
            get { return _p3; }
        }

        //khoi tao
        public FuzzyVar(string ten, KieuHam kieuham, double g1, double g2, double g3)
        {
            _name = ten;
            _MFtype = kieuham;
            _p1 = g1;
            _p2 = g2;
            _p3 = g3;
        }
        public FuzzyVar()
        { }

    }
}
