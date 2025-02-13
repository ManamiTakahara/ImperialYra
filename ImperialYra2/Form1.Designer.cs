namespace ImperialYra2
{
    partial class ImperialYraForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.westernLabel = new System.Windows.Forms.Label();
            this.inperiaLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(294, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 57);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // westernLabel
            // 
            this.westernLabel.AutoSize = true;
            this.westernLabel.Location = new System.Drawing.Point(41, 105);
            this.westernLabel.Name = "westernLabel";
            this.westernLabel.Size = new System.Drawing.Size(126, 15);
            this.westernLabel.TabIndex = 2;
            this.westernLabel.Text = "西暦が表示されます";
            // 
            // inperiaLabel
            // 
            this.inperiaLabel.AutoSize = true;
            this.inperiaLabel.Location = new System.Drawing.Point(41, 169);
            this.inperiaLabel.Name = "inperiaLabel";
            this.inperiaLabel.Size = new System.Drawing.Size(126, 15);
            this.inperiaLabel.TabIndex = 3;
            this.inperiaLabel.Text = "年号が表示されます";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(294, 131);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(131, 53);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ImperialYraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 238);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.inperiaLabel);
            this.Controls.Add(this.westernLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Name = "ImperialYraForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label westernLabel;
        private System.Windows.Forms.Label inperiaLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

