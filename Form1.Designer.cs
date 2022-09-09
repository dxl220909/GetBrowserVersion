namespace GetChromeVersion
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_get = new System.Windows.Forms.Button();
            this.tbx_version = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(12, 114);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(95, 32);
            this.btn_get.TabIndex = 0;
            this.btn_get.Text = "gET";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // tbx_version
            // 
            this.tbx_version.Location = new System.Drawing.Point(13, 37);
            this.tbx_version.Name = "tbx_version";
            this.tbx_version.Size = new System.Drawing.Size(151, 25);
            this.tbx_version.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ChromeVersion：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_version);
            this.Controls.Add(this.btn_get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox tbx_version;
        private System.Windows.Forms.Label label1;
    }
}

