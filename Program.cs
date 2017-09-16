using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public enum KieuHam
    {
        Triangular = 1,
        RightTrapezoid = 2,
        LeftTrapezoid = 3,
        RightLine = 4,
        LeftLine = 5,
    }
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fuzzy_Control());
        }
    }
}
