using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace gta_sa
{
    public partial class gta_sa : Form
    {
        public gta_sa()
        {
            InitializeComponent();
        }
        private void gtasa_click(object sender, EventArgs e)
        {
            if (File.Exists("gta_sa.exe")) {
                Process.Start("gta_sa.exe");
                Close();
            }
            else
            {
                MessageBox.Show("I can not find the gta_sa.exe file," + "check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();

            }
        }
        private void gtasade_click(object sender, EventArgs e)
        {
            if (File.Exists("gta_sa_de.lnk"))
            {
                Process.Start("gta_sa_de.lnk");
                Close();
            }
            else
            {
                MessageBox.Show("I can not find the gta_sa_de.lnk file," + "check its availability and try again.", "File not found", MessageBoxButtons.OK);
                Close();

            }
        }
    }
}