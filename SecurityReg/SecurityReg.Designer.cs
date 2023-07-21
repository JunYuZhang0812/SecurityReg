namespace SecurityReg
{
    partial class SecurityReg
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
            this.m_btnReg32 = new System.Windows.Forms.Button();
            this.m_btnReg64 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnReg32
            // 
            this.m_btnReg32.Location = new System.Drawing.Point(12, 12);
            this.m_btnReg32.Name = "m_btnReg32";
            this.m_btnReg32.Size = new System.Drawing.Size(75, 23);
            this.m_btnReg32.TabIndex = 0;
            this.m_btnReg32.Text = "32位注册";
            this.m_btnReg32.UseVisualStyleBackColor = true;
            this.m_btnReg32.Click += new System.EventHandler(this.m_btnReg32_Click);
            // 
            // m_btnReg64
            // 
            this.m_btnReg64.Location = new System.Drawing.Point(93, 12);
            this.m_btnReg64.Name = "m_btnReg64";
            this.m_btnReg64.Size = new System.Drawing.Size(75, 23);
            this.m_btnReg64.TabIndex = 1;
            this.m_btnReg64.Text = "64位注册";
            this.m_btnReg64.UseVisualStyleBackColor = true;
            this.m_btnReg64.Click += new System.EventHandler(this.m_btnReg64_Click);
            // 
            // SecurityReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 48);
            this.Controls.Add(this.m_btnReg64);
            this.Controls.Add(this.m_btnReg32);
            this.KeyPreview = true;
            this.Name = "SecurityReg";
            this.Text = "注册Key";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecurityReg_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_btnReg32;
        private System.Windows.Forms.Button m_btnReg64;
    }
}

