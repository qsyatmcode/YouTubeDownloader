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

			if (SaveLocation == Form1.SavePath && checkBox1.Checked == Form1.highestQualityMode && (SaveMode)comboBox1.SelectedItem == Form1.saveMode)
			{
				this.Close();
				return;
			}
			if (MessageBox.Show("Вы хотите применить изминения?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				Form1.saveMode = (SaveMode)comboBox1.SelectedItem;
				Form1.SavePath = SaveLocation;
				Form1.highestQualityMode = checkBox1.Checked;
				this.Close();
				return;
			}
			else
			{
				this.Close();
				return;
			}
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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((SaveMode)comboBox1.SelectedIndex == SaveMode.Muxed)
			{
				label3.Visible = true;
			}
			else
			{
				label3.Visible = false;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				comboBox1.Enabled = false;
				label2.Enabled = false;
				label3.Enabled = false;
			}
			else
			{
				comboBox1.Enabled = true;
				label2.Enabled = true;
				label3.Enabled = true;
			}
		}
	}
}
