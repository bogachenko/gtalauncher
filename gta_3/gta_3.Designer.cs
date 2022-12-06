namespace gta_3
{
    partial class gta_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gta_3));
            this.gta3 = new System.Windows.Forms.Button();
            this.gta3de = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gta3
            // 
            resources.ApplyResources(this.gta3, "gta3");
            this.gta3.Name = "gta3";
            this.gta3.UseVisualStyleBackColor = true;
            this.gta3.Click += new System.EventHandler(this.gta3_click);
            // 
            // gta3de
            // 
            resources.ApplyResources(this.gta3de, "gta3de");
            this.gta3de.Name = "gta3de";
            this.gta3de.UseVisualStyleBackColor = true;
            this.gta3de.Click += new System.EventHandler(this.gta3de_click);
            // 
            // gta_3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gta3de);
            this.Controls.Add(this.gta3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_3";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gta3;
        private System.Windows.Forms.Button gta3de;
    }
}

