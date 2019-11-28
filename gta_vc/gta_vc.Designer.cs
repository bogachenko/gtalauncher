namespace gta_vc
{
    partial class gta_vc
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
            this.gtavc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtavc
            // 
            this.gtavc.Location = new System.Drawing.Point(9, 18);
            this.gtavc.Name = "gtavc";
            this.gtavc.Size = new System.Drawing.Size(75, 23);
            this.gtavc.TabIndex = 0;
            this.gtavc.Text = "gta vc";
            this.gtavc.UseVisualStyleBackColor = true;
            this.gtavc.Click += new System.EventHandler(this.gta_vc_Click);
            // 
            // gta_vc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.gtavc);
            this.Name = "gta_vc";
            this.Text = "Launcher for Grand Theft Auto Vice City";
            this.Load += new System.EventHandler(this.gta_vc_load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gtavc;
    }
}

