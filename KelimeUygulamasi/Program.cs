using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    static class Program
    {
        public static User? CurrentUser; // Nullable olarak i�aretleyin

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGiris());
        }
    }
}
