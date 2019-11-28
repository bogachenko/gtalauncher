namespace gta_sa {
 partial class gta_sa {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if (disposing && (components != null)) {
    components.Dispose();
   }
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_sa));
   this.gtasa = new System.Windows.Forms.Button();
   this.samp = new System.Windows.Forms.Button();
   this.SuspendLayout();
   resources.ApplyResources(this.gtasa, "gtasa");
   this.gtasa.Name = "gtasa";
   this.gtasa.UseVisualStyleBackColor = true;
   resources.ApplyResources(this.samp, "samp");
   this.samp.Name = "samp";
   this.samp.UseVisualStyleBackColor = true;
   resources.ApplyResources(this, "$this");
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.Controls.Add(this.samp);
   this.Controls.Add(this.gtasa);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "gta_sa";
   this.Load += new System.EventHandler(this.gta_sa_load);
   this.ResumeLayout(false);
  }
  private System.Windows.Forms.Button gtasa;
  private System.Windows.Forms.Button samp;
 }
}