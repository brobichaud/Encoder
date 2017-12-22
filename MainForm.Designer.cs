namespace Encoder
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textRaw = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.butEncode64 = new System.Windows.Forms.Button();
			this.butDecode64 = new System.Windows.Forms.Button();
			this.butEncodeHex = new System.Windows.Forms.Button();
			this.butDecodeHex = new System.Windows.Forms.Button();
			this.butOk = new System.Windows.Forms.Button();
			this.butLoad = new System.Windows.Forms.Button();
			this.butFromUnixDate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textRaw
			// 
			this.textRaw.Location = new System.Drawing.Point(60, 11);
			this.textRaw.Name = "textRaw";
			this.textRaw.Size = new System.Drawing.Size(341, 20);
			this.textRaw.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butEncode64
			// 
			this.butEncode64.Location = new System.Drawing.Point(7, 46);
			this.butEncode64.Name = "butEncode64";
			this.butEncode64.Size = new System.Drawing.Size(95, 23);
			this.butEncode64.TabIndex = 2;
			this.butEncode64.Text = "Base64 Encode";
			this.butEncode64.UseVisualStyleBackColor = true;
			this.butEncode64.Click += new System.EventHandler(this.butEncode64_Click);
			// 
			// butDecode64
			// 
			this.butDecode64.Location = new System.Drawing.Point(7, 72);
			this.butDecode64.Name = "butDecode64";
			this.butDecode64.Size = new System.Drawing.Size(95, 23);
			this.butDecode64.TabIndex = 3;
			this.butDecode64.Text = "Base64 Decode";
			this.butDecode64.UseVisualStyleBackColor = true;
			this.butDecode64.Click += new System.EventHandler(this.butDecode64_Click);
			// 
			// butEncodeHex
			// 
			this.butEncodeHex.Location = new System.Drawing.Point(108, 46);
			this.butEncodeHex.Name = "butEncodeHex";
			this.butEncodeHex.Size = new System.Drawing.Size(95, 23);
			this.butEncodeHex.TabIndex = 4;
			this.butEncodeHex.Text = "Hex Encode";
			this.butEncodeHex.UseVisualStyleBackColor = true;
			this.butEncodeHex.Click += new System.EventHandler(this.butEncodeHex_Click);
			// 
			// butDecodeHex
			// 
			this.butDecodeHex.Location = new System.Drawing.Point(108, 72);
			this.butDecodeHex.Name = "butDecodeHex";
			this.butDecodeHex.Size = new System.Drawing.Size(95, 23);
			this.butDecodeHex.TabIndex = 5;
			this.butDecodeHex.Text = "Hex Decode";
			this.butDecodeHex.UseVisualStyleBackColor = true;
			this.butDecodeHex.Click += new System.EventHandler(this.butDecodeHex_Click);
			// 
			// butOk
			// 
			this.butOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butOk.Location = new System.Drawing.Point(326, 72);
			this.butOk.Name = "butOk";
			this.butOk.Size = new System.Drawing.Size(75, 23);
			this.butOk.TabIndex = 9;
			this.butOk.Text = "Close";
			this.butOk.UseVisualStyleBackColor = true;
			this.butOk.Click += new System.EventHandler(this.butOk_Click);
			// 
			// butLoad
			// 
			this.butLoad.Location = new System.Drawing.Point(326, 46);
			this.butLoad.Name = "butLoad";
			this.butLoad.Size = new System.Drawing.Size(75, 23);
			this.butLoad.TabIndex = 8;
			this.butLoad.Text = "Load";
			this.butLoad.UseVisualStyleBackColor = true;
			this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
			// 
			// butFromUnixDate
			// 
			this.butFromUnixDate.Location = new System.Drawing.Point(209, 46);
			this.butFromUnixDate.Name = "butFromUnixDate";
			this.butFromUnixDate.Size = new System.Drawing.Size(95, 23);
			this.butFromUnixDate.TabIndex = 6;
			this.butFromUnixDate.Text = "From Unix Date";
			this.butFromUnixDate.UseVisualStyleBackColor = true;
			this.butFromUnixDate.Click += new System.EventHandler(this.butFromUnixDate_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.butOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.butOk;
			this.ClientSize = new System.Drawing.Size(409, 105);
			this.Controls.Add(this.butLoad);
			this.Controls.Add(this.butOk);
			this.Controls.Add(this.butDecodeHex);
			this.Controls.Add(this.butDecode64);
			this.Controls.Add(this.butFromUnixDate);
			this.Controls.Add(this.butEncodeHex);
			this.Controls.Add(this.butEncode64);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textRaw);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Encoder & Decoder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textRaw;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butEncode64;
		private System.Windows.Forms.Button butDecode64;
		private System.Windows.Forms.Button butEncodeHex;
		private System.Windows.Forms.Button butDecodeHex;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.Button butLoad;
		private System.Windows.Forms.Button butFromUnixDate;
	}
}

