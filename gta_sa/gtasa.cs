using System;
using System.Windows.Forms;
namespace gta_sa {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gta_sa());
        }
    }
}