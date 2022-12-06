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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_vc));
            this.gtavc = new System.Windows.Forms.Button();
            this.gtavcde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtavc
            // 
            this.gtavc.Location = new System.Drawing.Point(12, 12);
            this.gtavc.Name = "gtavc";
            this.gtavc.Size = new System.Drawing.Size(460, 40);
            this.gtavc.TabIndex = 0;
            this.gtavc.Text = "Grand Theft Auto: Vice City";
            this.gtavc.UseVisualStyleBackColor = true;
            this.gtavc.Click += new System.EventHandler(this.gtavc_click);
            // 
            // gtavcde
            // 
            this.gtavcde.Location = new System.Drawing.Point(12, 59);
            this.gtavcde.Name = "gtavcde";
            this.gtavcde.Size = new System.Drawing.Size(460, 40);
            this.gtavcde.TabIndex = 1;
            this.gtavcde.Text = "Grand Theft Auto: Vice City – The Definitive Edition";
            this.gtavcde.UseVisualStyleBackColor = true;
            this.gtavcde.Click += new System.EventHandler(this.gtavcde_click);
            // 
            // gta_vc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.gtavcde);
            this.Controls.Add(this.gtavc);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_vc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher for the Grand Theft Auto: Vice City";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gtavc;
        private System.Windows.Forms.Button gtavcde;
    }
}

