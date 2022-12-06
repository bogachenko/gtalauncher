using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace gta_vc {
    public partial class gta_vc: Form {
        public gta_vc() {
            InitializeComponent();
        }
        private void gtavc_click(object sender, EventArgs e) {
            if (File.Exists("gta-vc.exe")) {
                Process.Start("gta-vc.exe");
                Close();
            } else {
                MessageBox.Show("I can not find the gta-vc.exe file, check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();
            }
        }
        private void gtavcde_click(object sender, EventArgs e) {
            if (File.Exists("gta_vc_de.lnk")) {
                Process.Start("gta_vc_de.lnk");
                Close();
            } else {
                MessageBox.Show("I can not find the gta_vc_de.lnk file, check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();
            }
        }
        private void gta_vc_load(object sender, EventArgs e) {
            if (File.Exists("gta_vc_de.lnk")) {
                gtavcde.Enabled = true;
            } else {
                gtavcde.Enabled = false;
            }
            if (File.Exists("gta-vc.exe")) {
                gtavc.Enabled = true;
            } else {
                gtavc.Enabled = false;
            }
        }
    }
}