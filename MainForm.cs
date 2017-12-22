using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
	public partial class MainForm : Form
	{
		private byte[] _bytes;
		private bool _useBytes;

		public MainForm()
		{
			InitializeComponent();
		}

		private void butEncode64_Click(object sender, EventArgs e)
		{
			try
			{
				var dlg = new ResultForm();
				if (_useBytes)
					dlg.Bytes = Encoding.UTF8.GetBytes(Encoder.ToBase64(_bytes));
				else
					dlg.Bytes = Encoding.UTF8.GetBytes(Encoder.ToBase64(textRaw.Text));
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void butDecode64_Click(object sender, EventArgs e)
		{
			try
			{
				var dlg = new ResultForm();
				if (_useBytes)
					dlg.Bytes = Encoder.BytesFromBase64(Encoding.UTF8.GetString(_bytes));
				else
					dlg.Bytes = Encoder.BytesFromBase64(textRaw.Text);
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void butEncodeHex_Click(object sender, EventArgs e)
		{
			try
			{
				var dlg = new ResultForm();
				if (_useBytes)
					dlg.Bytes = Encoding.UTF8.GetBytes(Encoder.ToHex(_bytes));
				else
					dlg.Bytes = Encoding.UTF8.GetBytes(Encoder.ToHex(textRaw.Text));
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void butDecodeHex_Click(object sender, EventArgs e)
		{
			try
			{
				var dlg = new ResultForm();
				if (_useBytes)
					dlg.Bytes = Encoder.BytesFromHex(Encoding.UTF8.GetString(_bytes));
				else
					dlg.Bytes = Encoder.BytesFromHex(textRaw.Text);
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void butFromUnixDate_Click(object sender, EventArgs e)
		{
			try
			{
				// Unix timestamp is seconds past epoch
				var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
				var date = dtDateTime.AddSeconds(Convert.ToDouble(textRaw.Text)).ToLocalTime();

				var dlg = new ResultForm { StringResult = date.ToString() };
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void butLoad_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = @"All files (*.*)|*.*|Text files (*.txt)|*.txt";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				_bytes = File.ReadAllBytes(dlg.FileName);
				textRaw.Text = Encoding.UTF8.GetString(_bytes);
				_useBytes = true;
			}
		}

		private void butOk_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
