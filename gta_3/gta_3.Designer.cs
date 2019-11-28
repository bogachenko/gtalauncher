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
   this.gta3 = new System.Windows.Forms.Button();
   this.lu = new System.Windows.Forms.Button();
   this.SuspendLayout();
   resources.ApplyResources(this.gta3, "gta3");
   this.gta3.Name = "gta3";
   this.gta3.UseVisualStyleBackColor = true;
   this.gta3.Click += new System.EventHandler(this.Click_gta_3);
   resources.ApplyResources(this.lu, "lu");
   this.lu.Name = "lu";
   this.lu.UseVisualStyleBackColor = true;
   this.lu.Click += new System.EventHandler(this.Click_lu);
   resources.ApplyResources(this, "$this");
   this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.Controls.Add(this.lu);
   this.Controls.Add(this.gta3);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "gta_3";
   this.ShowIcon = false;
   this.Load += new System.EventHandler(this.Gta_3_load);
   this.ResumeLayout(false);
  }
  private System.Windows.Forms.Button gta3;
  private System.Windows.Forms.Button lu;
 }
}