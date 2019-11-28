using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gta_sa {
 public partial class gta_sa: Form {
  public gta_sa() {
   TopMost = true;
   this.StartPosition = FormStartPosition.CenterScreen;
   InitializeComponent();
  }
  private void Gta_sa_click(object sender, EventArgs e) {
   {
    if (File.Exists("gta_sa.exe")) {
     Process.Start("gta_sa.exe");
     Close();
    } else {
     MessageBox.Show("I can not find the gta_sa.exe file," + "check its availability and try again.", "File not found", MessageBoxButtons.OK);
     Close();
    }
   }
  }
  private void Samp_click(object sender, EventArgs e) {
   if (File.Exists("samp.exe")) {
    Process.Start("samp.exe");
    Close();
   } else {
    DialogResult result = MessageBox.Show("It looks like you do not have SAMP installed," + "click \"Yes\" to go to the developer's website.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    if (result == DialogResult.Yes) {
     Process.Start("https://www.sa-mp.com/");
    } else if (result == DialogResult.No)
     Close(); {}
   }
  }
  private void gta_sa_load(object sender, EventArgs e) {

  }
 }
}