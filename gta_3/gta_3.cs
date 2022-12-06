using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace gta_3 {
    public partial class gta_3: Form {
        public gta_3() {
            InitializeComponent();
        }
        private void gta3_click(object sender, EventArgs e) {
            if (File.Exists("gta3.exe")) {
                Process.Start("gta3.exe");
                Close();
            } else {
                MessageBox.Show("I can not find the gta3.exe file, check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();
            }
        }
        private void gta3de_click(object sender, EventArgs e) {
            if (File.Exists("gta_3_de.lnk")) {
                Process.Start("gta_3_de.lnk");
                Close();
            } else {
                MessageBox.Show("I can not find the gta_3_de.lnk file, check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();
            }
        }
        private void gta_3_load(object sender, EventArgs e) {
            if (File.Exists("gta_3_de.lnk")) {
                gta3de.Enabled = true;
            } else {
                gta3de.Enabled = false;
            }
            if (File.Exists("gta3.exe")) {
                gta3.Enabled = true;
            } else {
                gta3.Enabled = false;
            }
        }
    }
}