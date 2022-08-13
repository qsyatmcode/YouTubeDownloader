using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDownloader
{
	public partial class SettingsFormcs : Form
	{
		public static string SaveLocation = String.Empty;
		private static System.Drawing.Color headerColor = Form1.headerColor;

		public SettingsFormcs()
		{
			InitializeComponent();
			SaveLocation = Form1.SavePath;
			textBox1.Text = SaveLocation;
			comboBox1.DataSource = Enum.GetValues(typeof(SaveMode));
			comboBox1.SelectedItem = Form1.saveMode;
			checkBox1.Checked = Form1.highestQualityMode;
		}

		private void button1_Click(object sender, EventArgs e) // APPLY BUTTON
		{

			Form1.saveMode = (SaveMode)comboBox1.SelectedItem;
			Form1.SavePath = SaveLocation;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e) // PATH BROWSE BUTTON
		{
			try
			{
				if (saveLocationBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					textBox1.Text = saveLocationBrowserDialog.SelectedPath;
					SaveLocation = saveLocationBrowserDialog.SelectedPath;
				}
			}
			catch
			{
				MessageBox.Show("При указании пути сохранения произошла ошибка", "Ошикба", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Form1.highestQualityMode = checkBox1.Checked;
		}
	}
}
