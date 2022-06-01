using System;
using System.Windows.Forms;
namespace gta_sa {
 static class gtasa {
  [STAThread]
  static void Main() {
   Application.EnableVisualStyles();
   Application.SetCompatibleTextRenderingDefault(false);
   Application.Run(new gta_sa());
  }
 }
}