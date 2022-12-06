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
            resources.ApplyResources(this.gtavc, "gtavc");
            this.gtavc.Name = "gtavc";
            this.gtavc.UseVisualStyleBackColor = true;
            this.gtavc.Click += new System.EventHandler(this.gtavc_click);
            // 
            // gtavcde
            // 
            resources.ApplyResources(this.gtavcde, "gtavcde");
            this.gtavcde.Name = "gtavcde";
            this.gtavcde.UseVisualStyleBackColor = true;
            this.gtavcde.Click += new System.EventHandler(this.gtavcde_click);
            // 
            // gta_vc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gtavcde);
            this.Controls.Add(this.gtavc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gta_vc";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gtavc;
        private System.Windows.Forms.Button gtavcde;
    }
}

