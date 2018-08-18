namespace StdioHeadlines
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lstNews = new System.Windows.Forms.ListBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.rtbHead = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNews
            // 
            this.lstNews.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstNews.FormattingEnabled = true;
            this.lstNews.Location = new System.Drawing.Point(15, 8);
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(306, 498);
            this.lstNews.TabIndex = 0;
            this.lstNews.SelectedIndexChanged += new System.EventHandler(this.lstNews_SelectedIndexChanged);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(351, 17);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(403, 145);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // picNew
            // 
            this.picNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picNew.Location = new System.Drawing.Point(351, 168);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(403, 198);
            this.picNew.TabIndex = 2;
            this.picNew.TabStop = false;
            // 
            // rtbHead
            // 
            this.rtbHead.Location = new System.Drawing.Point(351, 359);
            this.rtbHead.Name = "rtbHead";
            this.rtbHead.Size = new System.Drawing.Size(403, 145);
            this.rtbHead.TabIndex = 3;
            this.rtbHead.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(778, 481);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "朗读";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 546);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rtbHead);
            this.Controls.Add(this.picNew);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lstNews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "新闻头条";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNews;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.RichTextBox rtbHead;
        private System.Windows.Forms.Button btnPlay;
    }
}

