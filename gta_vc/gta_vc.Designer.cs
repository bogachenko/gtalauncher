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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_vc));
   this.gtavc = new System.Windows.Forms.Button();
   this.vcmp = new System.Windows.Forms.Button();
   this.SuspendLayout();
   resources.ApplyResources(this.gtavc, "gtavc");
   this.gtavc.Name = "gtavc";
   this.gtavc.UseVisualStyleBackColor = true;
   this.gtavc.Click += new System.EventHandler(this.Gta_vc_click);
   resources.ApplyResources(this.vcmp, "vcmp");
   this.vcmp.Name = "vcmp";
   this.vcmp.UseVisualStyleBackColor = true;
   this.vcmp.Click += new System.EventHandler(this.Vcmp_click);
   resources.ApplyResources(this, "$this");
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.Controls.Add(this.vcmp);
   this.Controls.Add(this.gtavc);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "gta_vc";
   this.ShowIcon = false;
   this.Load += new System.EventHandler(this.Gta_vc_load);
   this.ResumeLayout(false);
  }
  private System.Windows.Forms.Button gtavc;
  private System.Windows.Forms.Button vcmp;
 }
}