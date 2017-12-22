using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
	public partial class ResultForm : Form
	{
		public byte[] Bytes { get; set; }
		public string StringResult { get; set; }

		public ResultForm()
		{
			InitializeComponent();
		}

		private void ResultForm_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(StringResult))
				textResult.Text = StringResult;
			else
				textResult.Text = Encoding.UTF8.GetString(Bytes);
		}

		private void butOk_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void butSave_Click(object sender, EventArgs e)
		{
			var dlg = new SaveFileDialog();
			dlg.Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*";
			dlg.DefaultExt = ".txt";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllBytes(dlg.FileName, Bytes);
			}
		}
	}
}
