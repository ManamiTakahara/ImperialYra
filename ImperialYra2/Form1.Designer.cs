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
            this.reverseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 19);
            this.textBox1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(236, 11);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 42);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // westernLabel
            // 
            this.westernLabel.AutoSize = true;
            this.westernLabel.Location = new System.Drawing.Point(31, 84);
            this.westernLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.westernLabel.Name = "westernLabel";
            this.westernLabel.Size = new System.Drawing.Size(101, 12);
            this.westernLabel.TabIndex = 2;
            this.westernLabel.Text = "西暦が表示されます";
            // 
            // inperiaLabel
            // 
            this.inperiaLabel.AutoSize = true;
            this.inperiaLabel.Location = new System.Drawing.Point(31, 135);
            this.inperiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inperiaLabel.Name = "inperiaLabel";
            this.inperiaLabel.Size = new System.Drawing.Size(101, 12);
            this.inperiaLabel.TabIndex = 3;
            this.inperiaLabel.Text = "年号が表示されます";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(236, 135);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 42);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(236, 70);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(98, 41);
            this.reverseButton.TabIndex = 5;
            this.reverseButton.Text = "逆引検索";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // ImperialYraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 190);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.inperiaLabel);
            this.Controls.Add(this.westernLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button reverseButton;
    }
}

