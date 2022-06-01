using System;
using System.Windows.Forms;
namespace gta_vc {
 static class gtavc {
  [STAThread]
  static void Main() {
   Application.EnableVisualStyles();
   Application.SetCompatibleTextRenderingDefault(false);
   Application.Run(new gta_vc());
  }
 }
}