using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace gta_3
{
    public partial class gta_3 : Form
    {
        public gta_3() => InitializeComponent();
        private void click_gta_3(object sender, EventArgs e)
        {
            {
                if (File.Exists("gta3.exe"))
                {
                    Process.Start("gta3.exe");
                    Close();
                }
                else
                {
                    MessageBox.Show(
                     "I can not find the \"gta3.exe\" file," +
                     "check its availability and try again", "File not found",
                     MessageBoxButtons.OK);
                    Close();
                }
            }
        }
        private void click_lu(object sender, EventArgs e)
        {
            if (File.Exists("LU.exe"))
            {
                Process.Start("LU.exe");
                Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                 "It looks like you do not have Liberty Unleashed installed," +
                 "click \"Yes\" to go to the developer's website or click on \"No\" to exit the launcher.", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Process.Start("http://www.liberty-unleashed.co.uk/");
                }
                else if (result == DialogResult.No)
                    Close();
                { }
            }
        }
        private void gta_3_load(object sender, EventArgs e) { }
    }
}