using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicLibrary
{
    static class Program
    {
        // TODO: להוסיף קומבובוקסים
        // TODO: להגביל את מספר הספרים הניתנים להשאלה ללקוח אחד
        // TODO: לתת התראה כשאר לקוח מנסה להשאיל עוד ספר בעוד שישנם ספרים שהוא עדיין להחזיר
        // TODO: להוסיף מסך חיפוש לספרים

        public static string WorkerName { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
