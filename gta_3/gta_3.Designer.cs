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
            // 
            // gta3
            // 
            this.gta3.Location = new System.Drawing.Point(12, 12);
            this.gta3.Name = "gta3";
            this.gta3.Size = new System.Drawing.Size(460, 40);
            this.gta3.TabIndex = 0;
            this.gta3.Text = "Grand Theft Auto III";
            this.gta3.UseVisualStyleBackColor = true;
            this.gta3.Click += new System.EventHandler(this.Click_gta_3);
            // 
            // lu
            // 
            this.lu.Location = new System.Drawing.Point(12, 58);
            this.lu.Name = "lu";
            this.lu.Size = new System.Drawing.Size(460, 40);
            this.lu.TabIndex = 1;
            this.lu.Text = "Liberty Unleashed";
            this.lu.UseVisualStyleBackColor = true;
            this.lu.Click += new System.EventHandler(this.Click_lu);
            // 
            // gta_3
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.lu);
            this.Controls.Add(this.gta3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_3";
            this.ShowIcon = false;
            this.Text = "Launcher for Grand Theft Auto III";
            this.Load += new System.EventHandler(this.Gta_3_load);
            this.ResumeLayout(false);

  }

        private System.Windows.Forms.Button gta3;
        private System.Windows.Forms.Button lu;
    }
}