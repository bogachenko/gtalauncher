namespace gta_vc {
 partial class gta_vc {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if (disposing && (components != null)) {
    components.Dispose();
   }
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
   this.gtavc = new System.Windows.Forms.Button();
   this.vcmp = new System.Windows.Forms.Button();
   this.SuspendLayout();
   this.gtavc.Location = new System.Drawing.Point(12, 12);
   this.gtavc.Name = "gtavc";
   this.gtavc.Size = new System.Drawing.Size(460, 40);
   this.gtavc.TabIndex = 0;
   this.gtavc.Text = "Grand Theft Auto Vice City";
   this.gtavc.UseVisualStyleBackColor = true;
   this.gtavc.Click += new System.EventHandler(this.gta_vc_click);
   this.vcmp.Location = new System.Drawing.Point(12, 59);
   this.vcmp.Name = "vcmp";
   this.vcmp.Size = new System.Drawing.Size(460, 40);
   this.vcmp.TabIndex = 1;
   this.vcmp.Text = "VC-MP";
   this.vcmp.UseVisualStyleBackColor = true;
   this.vcmp.Click += new System.EventHandler(this.vcmp_click);
   this.AutoScaleDimensions = new System.Drawing.SizeF(6 F, 13 F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(484, 111);
   this.Controls.Add(this.vcmp);
   this.Controls.Add(this.gtavc);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "gta_vc";
   this.ShowIcon = false;
   this.Text = "Launcher for Grand Theft Auto Vice City";
   this.Load += new System.EventHandler(this.gta_vc_load);
   this.ResumeLayout(false);
  }
  private System.Windows.Forms.Button gtavc;
  private System.Windows.Forms.Button vcmp;
 }
}