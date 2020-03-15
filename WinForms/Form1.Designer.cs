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
            this.lstPic = new System.Windows.Forms.ListBox();
            this.picbDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPic
            // 
            this.lstPic.FormattingEnabled = true;
            this.lstPic.ItemHeight = 12;
            this.lstPic.Location = new System.Drawing.Point(12, 12);
            this.lstPic.Name = "lstPic";
            this.lstPic.Size = new System.Drawing.Size(252, 472);
            this.lstPic.TabIndex = 0;
            this.lstPic.SelectedIndexChanged += new System.EventHandler(this.lstPic_SelectedIndexChanged);
            // 
            // picbDisplay
            // 
            this.picbDisplay.Location = new System.Drawing.Point(281, 12);
            this.picbDisplay.Name = "picbDisplay";
            this.picbDisplay.Size = new System.Drawing.Size(639, 472);
            this.picbDisplay.TabIndex = 1;
            this.picbDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.picbDisplay);
            this.Controls.Add(this.lstPic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPic;
        private System.Windows.Forms.PictureBox picbDisplay;
    }
}

