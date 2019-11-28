namespace gta_sa
{
    partial class gta_sa
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_sa));
            this.gtasa = new System.Windows.Forms.Button();
            this.samp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtasa
            // 
            resources.ApplyResources(this.gtasa, "gtasa");
            this.gtasa.Name = "gtasa";
            this.gtasa.UseVisualStyleBackColor = true;
            // 
            // samp
            // 
            resources.ApplyResources(this.samp, "samp");
            this.samp.Name = "samp";
            this.samp.UseVisualStyleBackColor = true;
            // 
            // gta_sa
            // 
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

        #endregion

        private System.Windows.Forms.Button gtasa;
        private System.Windows.Forms.Button samp;
    }
}

