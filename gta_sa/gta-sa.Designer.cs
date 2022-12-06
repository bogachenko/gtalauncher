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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof (gta_sa));
      this.gtasa = new System.Windows.Forms.Button();
      this.gtasade = new System.Windows.Forms.Button();
      this.SuspendLayout();
      this.gtasa.Location = new System.Drawing.Point(12, 13);
      this.gtasa.Name = "gtasa";
      this.gtasa.Size = new System.Drawing.Size(460, 43);
      this.gtasa.TabIndex = 0;
      this.gtasa.Text = "Grand Theft Auto: San Andreas";
      this.gtasa.UseVisualStyleBackColor = true;
      this.gtasa.Click += new System.EventHandler(this.gtasa_click);
      this.gtasade.Location = new System.Drawing.Point(12, 62);
      this.gtasade.Name = "gtasade";
      this.gtasade.Size = new System.Drawing.Size(460, 43);
      this.gtasade.TabIndex = 1;
      this.gtasade.Text = "Grand Theft Auto: San Andreas – The Definitive Edition";
      this.gtasade.UseVisualStyleBackColor = true;
      this.gtasade.Click += new System.EventHandler(this.gtasade_click);
      this.AutoScaleDimensions = new System.Drawing.SizeF(6 F, 14 F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 120);
      this.Controls.Add(this.gtasade);
      this.Controls.Add(this.gtasa);
      this.Font = new System.Drawing.Font("Arial", 8.25 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "gta_sa";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Launcher for the Grand Theft Auto: San Andreas";
      this.ResumeLayout(false);
    }
    #endregion
    private System.Windows.Forms.Button gtasa;
    private System.Windows.Forms.Button gtasade;
  }
}