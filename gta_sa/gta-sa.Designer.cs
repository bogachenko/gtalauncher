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
            this.gtasade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtasa
            // 
            resources.ApplyResources(this.gtasa, "gtasa");
            this.gtasa.Name = "gtasa";
            this.gtasa.UseVisualStyleBackColor = true;
            this.gtasa.Click += new System.EventHandler(this.gtasa_click);
            // 
            // gtasade
            // 
            resources.ApplyResources(this.gtasade, "gtasade");
            this.gtasade.Name = "gtasade";
            this.gtasade.UseVisualStyleBackColor = true;
            this.gtasade.Click += new System.EventHandler(this.gtasade_click);
            // 
            // gta_sa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gtasade);
            this.Controls.Add(this.gtasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_sa";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button gtasa;
        private System.Windows.Forms.Button gtasade;
    }
}