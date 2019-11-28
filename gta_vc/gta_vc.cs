using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace gta_vc {
 public partial class gta_vc: Form {
  public gta_vc() {
   TopMost = true;
   this.StartPosition = FormStartPosition.CenterScreen;
   InitializeComponent();
  }
  private void gta_vc_click(object sender, EventArgs e) {
   {
    if (File.Exists("gta_vc.exe")) {
     Process.Start("gta_vc.exe");
     Close();
    } else {
     MessageBox.Show("I can not find the gta_vc.exe file," + "check its availability and try again.", "File not found", MessageBoxButtons.OK);
     Close();
    }
   }
  }
  private void vcmp_click(object sender, EventArgs e) {
   if (File.Exists("VCMPBrowser.exe")) {
    Process.Start("VCMPBrowser.exe");
    Close();
   } else {
    DialogResult result = MessageBox.Show("It looks like you do not have VC-MP installed," + "click \"Yes\" to go to the developer's website.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    if (result == DialogResult.Yes) {
     Process.Start("https://www.vc-mp.org/");
    } else if (result == DialogResult.No)
     Close(); {}
   }
  }
  private void gta_vc_load(object sender, EventArgs e) {}
 }
}