namespace WinForms
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
            this.wbrower = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbrower
            // 
            this.wbrower.Location = new System.Drawing.Point(12, 48);
            this.wbrower.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrower.Name = "wbrower";
            this.wbrower.Size = new System.Drawing.Size(926, 575);
            this.wbrower.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(13, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(833, 21);
            this.txtURL.TabIndex = 1;
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(852, 12);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(75, 23);
            this.btnAccess.TabIndex = 2;
            this.btnAccess.Text = "访问";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.wbrower);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrower;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnAccess;
    }
}

