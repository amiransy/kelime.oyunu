using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    static class Program
    {
        public static User? CurrentUser; // Nullable olarak işaretleyin

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGiris());
        }
    }
}
