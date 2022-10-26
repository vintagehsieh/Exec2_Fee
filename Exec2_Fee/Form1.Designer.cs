namespace Exec2_Fee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.genderLabel = new System.Windows.Forms.Label();
			this.ageLabel = new System.Windows.Forms.Label();
			this.genderCbBox = new System.Windows.Forms.ComboBox();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// genderLabel
			// 
			this.genderLabel.AutoSize = true;
			this.genderLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.genderLabel.Location = new System.Drawing.Point(112, 97);
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(52, 25);
			this.genderLabel.TabIndex = 0;
			this.genderLabel.Text = "性別";
			// 
			// ageLabel
			// 
			this.ageLabel.AutoSize = true;
			this.ageLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ageLabel.Location = new System.Drawing.Point(112, 171);
			this.ageLabel.Name = "ageLabel";
			this.ageLabel.Size = new System.Drawing.Size(52, 25);
			this.ageLabel.TabIndex = 1;
			this.ageLabel.Text = "年齡";
			// 
			// genderCbBox
			// 
			this.genderCbBox.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.genderCbBox.FormattingEnabled = true;
			this.genderCbBox.Items.AddRange(new object[] {
            "男性",
            "女性"});
			this.genderCbBox.Location = new System.Drawing.Point(190, 93);
			this.genderCbBox.Name = "genderCbBox";
			this.genderCbBox.Size = new System.Drawing.Size(145, 33);
			this.genderCbBox.TabIndex = 2;
			// 
			// ageTextBox
			// 
			this.ageTextBox.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ageTextBox.Location = new System.Drawing.Point(190, 166);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(145, 34);
			this.ageTextBox.TabIndex = 3;
			// 
			// calcButton
			// 
			this.calcButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.calcButton.Location = new System.Drawing.Point(365, 89);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(115, 115);
			this.calcButton.TabIndex = 4;
			this.calcButton.Text = "計算\r\n票價";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(111, 261);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(62, 31);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.Text = "結果";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 450);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.genderCbBox);
			this.Controls.Add(this.ageLabel);
			this.Controls.Add(this.genderLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label genderLabel;
		private System.Windows.Forms.Label ageLabel;
		private System.Windows.Forms.ComboBox genderCbBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Label resultLabel;
	}
}

