namespace BootCDN {
    partial class formMain {
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGet = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.progressTotal = new System.Windows.Forms.ProgressBar();
            this.labelTipCurrentFile = new System.Windows.Forms.Label();
            this.labelTipCurrentItem = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.labelTip5 = new System.Windows.Forms.Label();
            this.textCharset = new System.Windows.Forms.TextBox();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.textXpathHref = new System.Windows.Forms.TextBox();
            this.labelTip4 = new System.Windows.Forms.Label();
            this.textXpathEachLink = new System.Windows.Forms.TextBox();
            this.labelTip3 = new System.Windows.Forms.Label();
            this.textXpathName = new System.Windows.Forms.TextBox();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.textSourceUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(205, 11);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(120, 30);
            this.buttonGet.TabIndex = 6;
            this.buttonGet.Text = "获取可用列表";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 15;
            this.listBoxItems.Location = new System.Drawing.Point(12, 11);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(187, 139);
            this.listBoxItems.TabIndex = 9;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // progressTotal
            // 
            this.progressTotal.Location = new System.Drawing.Point(205, 79);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.Size = new System.Drawing.Size(120, 71);
            this.progressTotal.TabIndex = 12;
            // 
            // labelTipCurrentFile
            // 
            this.labelTipCurrentFile.AutoSize = true;
            this.labelTipCurrentFile.Location = new System.Drawing.Point(9, 153);
            this.labelTipCurrentFile.Name = "labelTipCurrentFile";
            this.labelTipCurrentFile.Size = new System.Drawing.Size(75, 15);
            this.labelTipCurrentFile.TabIndex = 14;
            this.labelTipCurrentFile.Text = "当前文件:";
            // 
            // labelTipCurrentItem
            // 
            this.labelTipCurrentItem.Location = new System.Drawing.Point(9, 178);
            this.labelTipCurrentItem.Name = "labelTipCurrentItem";
            this.labelTipCurrentItem.Size = new System.Drawing.Size(315, 15);
            this.labelTipCurrentItem.TabIndex = 15;
            this.labelTipCurrentItem.Text = "当前项目:";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(205, 43);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 30);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "采集当前所选";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.Location = new System.Drawing.Point(90, 153);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(234, 15);
            this.labelCurrentFile.TabIndex = 17;
            // 
            // labelTip5
            // 
            this.labelTip5.AutoSize = true;
            this.labelTip5.Location = new System.Drawing.Point(516, 11);
            this.labelTip5.Name = "labelTip5";
            this.labelTip5.Size = new System.Drawing.Size(63, 15);
            this.labelTip5.TabIndex = 27;
            this.labelTip5.Text = "Charset";
            // 
            // textCharset
            // 
            this.textCharset.Location = new System.Drawing.Point(519, 29);
            this.textCharset.Name = "textCharset";
            this.textCharset.Size = new System.Drawing.Size(85, 25);
            this.textCharset.TabIndex = 26;
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(331, 57);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(123, 15);
            this.labelTip2.TabIndex = 25;
            this.labelTip2.Text = "[XPath]项目链接";
            // 
            // textXpathHref
            // 
            this.textXpathHref.Location = new System.Drawing.Point(331, 75);
            this.textXpathHref.Name = "textXpathHref";
            this.textXpathHref.Size = new System.Drawing.Size(273, 25);
            this.textXpathHref.TabIndex = 24;
            // 
            // labelTip4
            // 
            this.labelTip4.AutoSize = true;
            this.labelTip4.Location = new System.Drawing.Point(331, 149);
            this.labelTip4.Name = "labelTip4";
            this.labelTip4.Size = new System.Drawing.Size(153, 15);
            this.labelTip4.TabIndex = 23;
            this.labelTip4.Text = "[XPath]每项目中链接";
            // 
            // textXpathEachLink
            // 
            this.textXpathEachLink.Location = new System.Drawing.Point(330, 167);
            this.textXpathEachLink.Name = "textXpathEachLink";
            this.textXpathEachLink.Size = new System.Drawing.Size(274, 25);
            this.textXpathEachLink.TabIndex = 22;
            // 
            // labelTip3
            // 
            this.labelTip3.AutoSize = true;
            this.labelTip3.Location = new System.Drawing.Point(331, 103);
            this.labelTip3.Name = "labelTip3";
            this.labelTip3.Size = new System.Drawing.Size(123, 15);
            this.labelTip3.TabIndex = 21;
            this.labelTip3.Text = "[XPath]项目名称";
            // 
            // textXpathName
            // 
            this.textXpathName.Location = new System.Drawing.Point(331, 121);
            this.textXpathName.Name = "textXpathName";
            this.textXpathName.Size = new System.Drawing.Size(273, 25);
            this.textXpathName.TabIndex = 20;
            // 
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.Location = new System.Drawing.Point(331, 11);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(67, 15);
            this.labelTip1.TabIndex = 19;
            this.labelTip1.Text = "采集地址";
            // 
            // textSourceUrl
            // 
            this.textSourceUrl.Location = new System.Drawing.Point(331, 29);
            this.textSourceUrl.Name = "textSourceUrl";
            this.textSourceUrl.Size = new System.Drawing.Size(182, 25);
            this.textSourceUrl.TabIndex = 18;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 205);
            this.Controls.Add(this.labelTip5);
            this.Controls.Add(this.textCharset);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.textXpathHref);
            this.Controls.Add(this.labelTip4);
            this.Controls.Add(this.textXpathEachLink);
            this.Controls.Add(this.labelTip3);
            this.Controls.Add(this.textXpathName);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.textSourceUrl);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTipCurrentItem);
            this.Controls.Add(this.labelTipCurrentFile);
            this.Controls.Add(this.progressTotal);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.buttonGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.Text = "前端CDN";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ProgressBar progressTotal;
        private System.Windows.Forms.Label labelTipCurrentFile;
        private System.Windows.Forms.Label labelTipCurrentItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelTip5;
        private System.Windows.Forms.TextBox textCharset;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.TextBox textXpathHref;
        private System.Windows.Forms.Label labelTip4;
        private System.Windows.Forms.TextBox textXpathEachLink;
        private System.Windows.Forms.Label labelTip3;
        private System.Windows.Forms.TextBox textXpathName;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.TextBox textSourceUrl;
    }
}

