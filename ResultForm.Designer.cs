namespace Encoder
{
	partial class ResultForm
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
			this.textResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.butSave = new System.Windows.Forms.Button();
			this.butOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textResult
			// 
			this.textResult.Location = new System.Drawing.Point(13, 29);
			this.textResult.Multiline = true;
			this.textResult.Name = "textResult";
			this.textResult.ReadOnly = true;
			this.textResult.Size = new System.Drawing.Size(568, 100);
			this.textResult.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Result:";
			// 
			// butSave
			// 
			this.butSave.Location = new System.Drawing.Point(506, 135);
			this.butSave.Name = "butSave";
			this.butSave.Size = new System.Drawing.Size(75, 23);
			this.butSave.TabIndex = 2;
			this.butSave.Text = "Save";
			this.butSave.UseVisualStyleBackColor = true;
			this.butSave.Click += new System.EventHandler(this.butSave_Click);
			// 
			// butOk
			// 
			this.butOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butOk.Location = new System.Drawing.Point(427, 135);
			this.butOk.Name = "butOk";
			this.butOk.Size = new System.Drawing.Size(75, 23);
			this.butOk.TabIndex = 3;
			this.butOk.Text = "OK";
			this.butOk.UseVisualStyleBackColor = true;
			this.butOk.Click += new System.EventHandler(this.butOk_Click);
			// 
			// ResultForm
			// 
			this.AcceptButton = this.butOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.butOk;
			this.ClientSize = new System.Drawing.Size(593, 168);
			this.Controls.Add(this.butOk);
			this.Controls.Add(this.butSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textResult);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResultForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Results";
			this.Load += new System.EventHandler(this.ResultForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butSave;
		private System.Windows.Forms.Button butOk;
	}
}