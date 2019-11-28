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
            this.gtasa = new System.Windows.Forms.Button();
            this.samp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtasa
            // 
            this.gtasa.Location = new System.Drawing.Point(12, 12);
            this.gtasa.Name = "gtasa";
            this.gtasa.Size = new System.Drawing.Size(460, 40);
            this.gtasa.TabIndex = 0;
            this.gtasa.Text = "Grand Theft Auto San Andreas";
            this.gtasa.UseVisualStyleBackColor = true;
            // 
            // samp
            // 
            this.samp.Location = new System.Drawing.Point(12, 59);
            this.samp.Name = "samp";
            this.samp.Size = new System.Drawing.Size(460, 40);
            this.samp.TabIndex = 1;
            this.samp.Text = "San Andreas Multiplayer";
            this.samp.UseVisualStyleBackColor = true;
            // 
            // gta_sa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.samp);
            this.Controls.Add(this.gtasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_sa";
            this.Text = "Launcher for Grand Theft Auto San Andreas";
            this.Load += new System.EventHandler(this.gta_sa_load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gtasa;
        private System.Windows.Forms.Button samp;
    }
}

