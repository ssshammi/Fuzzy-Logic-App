using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class CarspeedSet
    {
        //do thuoc
        public double[] _MF_value = new double[100];


        //so gia tri
        public int _SGT = 0;
        public int SGT
        {
            set { _SGT = value; }
            get { return _SGT; }
        }
        //khoi tao
        public CarspeedSet()
        { }

        public void Add(double a)
        {

            _MF_value[_SGT] = a;
            _SGT++;
        }
        //
        public void Show()
        {
            for (int i = 0; i < SGT; i++)
            {
                Console.WriteLine(_MF_value[i]);
            }
        }
        //
        public double Mandani_Max()
        {
            double max = 0.0;
            for (int i = 0; i < SGT; i++)
            {
                if (_MF_value[i] >= max)
                    max = _MF_value[i];
            }
            return max;
        }
        //Giai mo
        public static double Defuzzy(double a, double b, double c)
        {
            double output_value = 0;
            if (a != 0 && b == 0 && c == 0)
            {
                output_value = 50 * (1 - a);
            }
            else
            {
                output_value = (0 * a + b * 50 + c * 100) / (a + b + c);
            }
            return output_value;
        }

    }
}
