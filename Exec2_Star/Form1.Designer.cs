namespace Exec2_Star
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
			this.leftbtn = new System.Windows.Forms.Button();
			this.rightbtn = new System.Windows.Forms.Button();
			this.equalbtn = new System.Windows.Forms.Button();
			this.inputtxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.resulttxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// leftbtn
			// 
			this.leftbtn.Location = new System.Drawing.Point(375, 62);
			this.leftbtn.Name = "leftbtn";
			this.leftbtn.Size = new System.Drawing.Size(75, 23);
			this.leftbtn.TabIndex = 2;
			this.leftbtn.Text = "靠左";
			this.leftbtn.UseVisualStyleBackColor = true;
			this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
			// 
			// rightbtn
			// 
			this.rightbtn.Location = new System.Drawing.Point(469, 62);
			this.rightbtn.Name = "rightbtn";
			this.rightbtn.Size = new System.Drawing.Size(75, 23);
			this.rightbtn.TabIndex = 3;
			this.rightbtn.Text = "靠右";
			this.rightbtn.UseVisualStyleBackColor = true;
			this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
			// 
			// equalbtn
			// 
			this.equalbtn.Location = new System.Drawing.Point(563, 62);
			this.equalbtn.Name = "equalbtn";
			this.equalbtn.Size = new System.Drawing.Size(75, 23);
			this.equalbtn.TabIndex = 4;
			this.equalbtn.Text = "等腰";
			this.equalbtn.UseVisualStyleBackColor = true;
			this.equalbtn.Click += new System.EventHandler(this.equalbtn_Click);
			// 
			// inputtxt
			// 
			this.inputtxt.Location = new System.Drawing.Point(228, 62);
			this.inputtxt.Name = "inputtxt";
			this.inputtxt.Size = new System.Drawing.Size(100, 22);
			this.inputtxt.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(37, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入列數(介於1到10)";
			// 
			// resulttxt
			// 
			this.resulttxt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resulttxt.Location = new System.Drawing.Point(120, 101);
			this.resulttxt.Multiline = true;
			this.resulttxt.Name = "resulttxt";
			this.resulttxt.Size = new System.Drawing.Size(518, 327);
			this.resulttxt.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resulttxt);
			this.Controls.Add(this.inputtxt);
			this.Controls.Add(this.equalbtn);
			this.Controls.Add(this.rightbtn);
			this.Controls.Add(this.leftbtn);
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button leftbtn;
		private System.Windows.Forms.Button rightbtn;
		private System.Windows.Forms.Button equalbtn;
		private System.Windows.Forms.TextBox inputtxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox resulttxt;
	}
}

