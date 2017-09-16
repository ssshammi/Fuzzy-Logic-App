using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApplication3
{
    public partial class Fuzzy_Control : Form
    {
        public Fuzzy_Control()
        {
            InitializeComponent();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            RWvalue_Box.Text = Convert.ToString(RW_Bar.Value) + " (làn xe)";
            fuzzy();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            FSvalue_Box.Text = Convert.ToString(FS_Bar.Value) + " (mét)";
            fuzzy();
            

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            DIvalue_Box.Text = Convert.ToString(DI_Bar.Value) + " (mét)";
            fuzzy();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            CIFvalue_Box.Text = Convert.ToString(CIF_Bar.Value) + " (xe)";
            fuzzy();
            
        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {
            
            
        }

        private void SafeSpeed_Value_TextChanged(object sender, EventArgs e)
        {
            

        }
      
        double current_Speed = 50;
        double Giatoc1 = 10;
        double Giatoc2 = 5;
        double Giatoc3 = 2;
        double Giatoc4 = 1;
        double TocDoAnToan = 0.0;
        public void fuzzy()
        {
            
            double SafeSpeed = 0.0;
             
            
            FSvalue_Box.Text = Convert.ToString(FS_Bar.Value) + " (mét)";
            RWvalue_Box.Text = Convert.ToString(RW_Bar.Value) + " (làn xe)";
            DIvalue_Box.Text = Convert.ToString(DI_Bar.Value) + " (mét)";
            CIFvalue_Box.Text = Convert.ToString(CIF_Bar.Value) + " (xe)";

            FuzzySet Foresight = new FuzzySet("Foresight");
            FuzzySet RoadWidth = new FuzzySet("Road Width");
            FuzzySet CarInFront = new FuzzySet("Cars in front");
            FuzzySet Distance = new FuzzySet("Distance to the intersection");
            FuzzySet Speed = new FuzzySet("Safe Speed");

            ///Tap mo Road Width
            FuzzyVar RSmall = new FuzzyVar("RSmall", KieuHam.LeftLine, 0, 1, 4);
            FuzzyVar RMedium = new FuzzyVar("RMedium", KieuHam.Triangular, 1, 4, 7);
            FuzzyVar RBig = new FuzzyVar("RBig", KieuHam.RightLine, 4, 7, 0);

            RoadWidth.Add(RSmall);
            RoadWidth.Add(RMedium);
            RoadWidth.Add(RBig);
            //Tap mo Cars in front
            FuzzyVar CFew = new FuzzyVar("CFew", KieuHam.LeftLine, 0, 0, 10);
            FuzzyVar CMedium = new FuzzyVar("CMedium", KieuHam.Triangular, 0, 10, 20);
            FuzzyVar CMany = new FuzzyVar("CMany", KieuHam.RightLine, 10, 20, 0);

            CarInFront.Add(CFew);
            CarInFront.Add(CMedium);
            CarInFront.Add(CMany);
            //Tap mo Distance to the intersection
            FuzzyVar DShort = new FuzzyVar("DShort", KieuHam.LeftTrapezoid, 0, 25, 100);
            FuzzyVar DMedium = new FuzzyVar("DMedium", KieuHam.Triangular, 25, 100, 175);
            FuzzyVar DLong = new FuzzyVar("DLong", KieuHam.RightTrapezoid, 100, 175, 200);

            Distance.Add(DShort);
            Distance.Add(DMedium);
            Distance.Add(DLong);
            //Tap mo Foresight
            FuzzyVar FShort = new FuzzyVar("FShort", KieuHam.LeftTrapezoid, 0, 20, 100);
            FuzzyVar FMedium = new FuzzyVar("FMedium", KieuHam.Triangular, 20, 100, 180);
            FuzzyVar FLong = new FuzzyVar("FLong", KieuHam.RightTrapezoid, 100, 180, 200);

            Foresight.Add(FShort);
            Foresight.Add(FMedium);
            Foresight.Add(FLong);
            //Tap mo Speed
            FuzzyVar SSlow = new FuzzyVar("SSlow", KieuHam.LeftLine, 0, 25, 50);
            FuzzyVar SMedium = new FuzzyVar("SMedium", KieuHam.Triangular, 25, 50, 75);
            FuzzyVar SFast = new FuzzyVar("SFast", KieuHam.RightLine, 50, 100, 0);

            Speed.Add(SSlow);
            Speed.Add(SMedium);
            Speed.Add(SFast);
            ////
            CarspeedSet SlowSet = new CarspeedSet();
            CarspeedSet MediumSet = new CarspeedSet();
            CarspeedSet FastSet = new CarspeedSet();
            //Gia tri input
            double RW = RW_Bar.Value;
            double CIF = CIF_Bar.Value;
            double DI = DI_Bar.Value;
            double FS = FS_Bar.Value;

            CarspeedSet Speed_slow = new CarspeedSet();
            CarspeedSet Speed_medium = new CarspeedSet();
            CarspeedSet Speed_fast = new CarspeedSet();

            //Do rong duong di
            double membership_RoadWidth = 0.0;

            //Luong xe truoc mat
            double membership_CarInFront = 0.0;

            //Khoang cach toi giao lo
            double membership_Distance = 0.0;
            //Tma nhin xa
            double membership_Foresight = 0.0;

            //Toc do an toan
            double membership_SSlow = 0.0;
            double membership_SMedium = 0.0;
            double membership_SFast = 0.0;


            /////////////////////////////////////
            ////CAC LUAT MO
            //R1
            #region Tap_Luat
            if (Foresight.ForeSight_Is_Short(FS))
            {
                membership_Foresight = Membership_Function.Membership_Value(FShort, FS);
                membership_SSlow = membership_Foresight;
                Speed_slow.Add(membership_SSlow);
            }
            //R2
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);


                Speed_slow.Add(membership_SSlow);


            }
            //R3
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);


                Speed_slow.Add(membership_SSlow);

            }
            ///R4
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);
                Console.WriteLine(membership_SSlow);

                Speed_slow.Add(membership_SSlow);


            }
            ///R5
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);



            }
            ///R6
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SSlow);

            }
            //R7
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SSlow);

            }
            ///R8
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R9
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R10
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R11
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R12
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SSlow);

            }
            //R13
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R14
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SFast);

            }
            //R15
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R16
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R17
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R18
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R19
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R20
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R21
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R22
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R23
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R24
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R25
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R26
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R27
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R28
            if (Foresight.ForeSight_Is_Medium(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FMedium, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R29
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R30
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R31
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R32
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R32
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R33
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SSlow);

            }
            //R34
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R35
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R36
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R37
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Small(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RSmall, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R38
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R39
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SSlow);

            }
            //R40
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R41
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R42
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R43
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R44
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R45
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R46
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Medium(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RMedium, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R47
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R48
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R49
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Short(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DShort, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SSlow = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_slow.Add(membership_SSlow);

            }
            //R50
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R51
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R52
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Medium(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DMedium, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SMedium = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SMedium);

            }
            //R53
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Few(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CFew, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R54
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Medium(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMedium, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_fast.Add(membership_SFast);

            }
            //R55
            if (Foresight.ForeSight_Is_Long(FS) && RoadWidth.RoadWidth_Is_Big(RW) && Distance.Distance_Is_Long(DI) && CarInFront.CarsInFront_is_Many(CIF))
            {
                membership_Foresight = Membership_Function.Membership_Value(FLong, FS);
                membership_RoadWidth = Membership_Function.Membership_Value(RBig, RW);
                membership_Distance = Membership_Function.Membership_Value(DLong, DI);
                membership_CarInFront = Membership_Function.Membership_Value(CMany, CIF);

                membership_SFast = FuzzySet.Min(membership_Foresight, membership_RoadWidth, membership_Distance, membership_CarInFront);

                Speed_medium.Add(membership_SFast);

            }
            #endregion

            /////////
            FuzzySpeed_performance.Text = "Speed = " + Math.Round(Speed_slow.Mandani_Max(), 2) + "/Slow" + " + " + Math.Round(Speed_medium.Mandani_Max(), 2) + "/Medium" + " + " + Math.Round(Speed_fast.Mandani_Max(), 2) + "/Fast";
            SafeSpeed = Math.Round(CarspeedSet.Defuzzy(Speed_slow.Mandani_Max(), Speed_medium.Mandani_Max(), Speed_fast.Mandani_Max()), 2);
            SafeSpeed_Value.Text = Convert.ToString(SafeSpeed);



            TocDoAnToan = SafeSpeed;
               
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
        Random rand = new Random();
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            FS_Bar.Value = rand.Next(50, 1000);
            fuzzy();
            
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            RW_Bar.Value = rand.Next(2, 7);
            fuzzy();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            DI_Bar.Value = rand.Next(20, 200);
            fuzzy();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            CIF_Bar.Value = rand.Next(2, 20);
            fuzzy();
        }

        void startFuzzyControl()
        {
            FS_Timer.Enabled = true;
            RW_Timer.Enabled = true;
            DI_Timer.Enabled = true;
            CIF_Timer.Enabled = true;
            timer1.Enabled = true;
        }

        void stopFuzzyControl()
        {
            FS_Timer.Enabled = false;
            RW_Timer.Enabled = false;
            DI_Timer.Enabled = false;
            CIF_Timer.Enabled = false;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startFuzzyControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopFuzzyControl();
        }
        ///Chi thi dieu khien va dieu chinh gia toc
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Chi thi dieu khien
            if (TocDoAnToan < current_Speed && current_Speed - TocDoAnToan > 1)
            {
                ChiThiDieuKhien.Text = "Giảm tốc";
            }
            else if (TocDoAnToan > current_Speed && TocDoAnToan - current_Speed > 1)
            {
                ChiThiDieuKhien.Text = "Tăng tốc";
            }
            else if (TocDoAnToan - current_Speed >= 0 && TocDoAnToan - current_Speed <= 1)
            {
                ChiThiDieuKhien.Text = "Giữ nguyên tốc độ";
            }
            else if (current_Speed - TocDoAnToan >= 0 && current_Speed - TocDoAnToan <= 1)
            {
                ChiThiDieuKhien.Text = "Giữ nguyên tốc độ";
            }
            else
            {
                ChiThiDieuKhien.Text = "Giữ nguyên tốc độ";
            }

            //Dieu chinh toc do va gia toc

            if (current_Speed > TocDoAnToan)
            {
                if (current_Speed - TocDoAnToan > 10)
                {                    
                    current_Speed -= Giatoc1;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "-" + Convert.ToString(Giatoc1);
                }
                else if (current_Speed - TocDoAnToan > 5)
                {                    
                    current_Speed -= Giatoc2;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "-" + Convert.ToString(Giatoc2);
                }
                else if (current_Speed - TocDoAnToan > 2)
                {                    
                    current_Speed -= Giatoc3;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "-" + Convert.ToString(Giatoc3);
                }
                else if (current_Speed - TocDoAnToan > 1)
                {
                    current_Speed -= Giatoc4;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "-" + Convert.ToString(Giatoc4);
                }
                else 
                {                    
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "0";
                }

            }
            else if (current_Speed < TocDoAnToan)
            {
                if (TocDoAnToan - current_Speed > 10)
                {                    
                    current_Speed += Giatoc1;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = Convert.ToString(Giatoc1);
                }
                else if (TocDoAnToan - current_Speed > 5)
                {                   
                    current_Speed += Giatoc2;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = Convert.ToString(Giatoc2);
                }
                else if (TocDoAnToan - current_Speed > 2)
                {                    
                    current_Speed += Giatoc3;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = Convert.ToString(Giatoc3);
                }
                else if (TocDoAnToan - current_Speed > 1)
                {
                    current_Speed += Giatoc4;
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = Convert.ToString(Giatoc4);
                }
                else
                {
                    tocdohientai.Text = Convert.ToString(current_Speed);
                    Gia_toc.Text = "0";
                }
            }
            else if ((TocDoAnToan - current_Speed <= 1 && TocDoAnToan - current_Speed > 0) || (current_Speed - TocDoAnToan > 0 && current_Speed - TocDoAnToan <= 1))
            {
                Gia_toc.Text = "0";
                tocdohientai.Text = Convert.ToString(current_Speed);
            }
            else
            {
                Gia_toc.Text = "0";
                tocdohientai.Text = Convert.ToString(current_Speed);
            }

            //Bieu dien toc do
            string a = Convert.ToString(current_Speed);
            aGauge1.Value = float.Parse(a);
            
            
            
        }

        private void tocdohientai_Click(object sender, EventArgs e)
        {

        }

        private void Comman_control1_Load(object sender, EventArgs e)
        {

        }

        private void SafeSpeed_Value_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        



        


    }
}
