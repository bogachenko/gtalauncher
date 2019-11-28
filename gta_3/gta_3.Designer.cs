namespace gta_3 {
 partial class gta_3 {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if (disposing && (components != null)) {
    components.Dispose();
   }
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_3));
   this.lu = new System.Windows.Forms.Button();
   this.gta_iii = new System.Windows.Forms.Button();
   this.SuspendLayout();
   resources.ApplyResources(this.lu, "lu");
   this.lu.Name = "lu";
   this.lu.UseVisualStyleBackColor = true;
   this.lu.Click += new System.EventHandler(this.click_lu);
   resources.ApplyResources(this.gta_iii, "gta_iii");
   this.gta_iii.Name = "gta_iii";
   this.gta_iii.UseVisualStyleBackColor = true;
   this.gta_iii.Click += new System.EventHandler(this.click_gta_3);
   resources.ApplyResources(this, "$this");
   this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.Controls.Add(this.gta_iii);
   this.Controls.Add(this.lu);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "gta_3";
   this.ShowIcon = false;
   this.Load += new System.EventHandler(this.gta_3_load);
   this.ResumeLayout(false);
  }
  private System.Windows.Forms.Button lu;
  private System.Windows.Forms.Button gta_iii;
 }
}