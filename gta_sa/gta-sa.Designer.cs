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
            this.gtasade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtasa
            // 
            this.gtasa.Location = new System.Drawing.Point(12, 13);
            this.gtasa.Name = "gtasa";
            this.gtasa.Size = new System.Drawing.Size(460, 43);
            this.gtasa.TabIndex = 0;
            this.gtasa.Text = "Grand Theft Auto: San Andreas";
            this.gtasa.UseVisualStyleBackColor = true;
            this.gtasa.Click += new System.EventHandler(this.gtasa_click);
            // 
            // gtasade
            // 
            this.gtasade.Location = new System.Drawing.Point(12, 62);
            this.gtasade.Name = "gtasade";
            this.gtasade.Size = new System.Drawing.Size(460, 43);
            this.gtasade.TabIndex = 1;
            this.gtasade.Text = "Grand Theft Auto: San Andreas – The Definitive Edition";
            this.gtasade.UseVisualStyleBackColor = true;
            this.gtasade.Click += new System.EventHandler(this.gtasade_click);
            // 
            // gta_sa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 120);
            this.Controls.Add(this.gtasade);
            this.Controls.Add(this.gtasa);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

