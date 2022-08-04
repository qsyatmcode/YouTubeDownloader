using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;

namespace YouTubeDownloader
{
	public partial class Form1 : Form
	{
		public static YoutubeClient client;
		public static YoutubeExplode.Videos.Video SelectedVideo;
		public Form1()
		{
			InitializeComponent();
			client = new YoutubeClient();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == String.Empty)
			{
				MessageBox.Show("Please, enter the video's URL", "Attemption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			try
			{
				var video = await client.Videos.GetAsync(textBox1.Text);
				VideoTitle.Text = video.Title;
				label1.Text = video.Description;
				DurationVideo.Text = video.Duration.ToString();
				SelectedVideo = video;
				EnableLabels();
			}
			catch
			{
				try
				{
					MessageBox.Show("Поиск по названию займёт время, пожалуйста, подождите", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
					var videos = await client.Search.GetVideosAsync(textBox1.Text);
					var video = await client.Videos.GetAsync(videos.ElementAt(0).Url);
					MessageBox.Show("Поиск выполнен");
					VideoTitle.Text = video.Title;
					label1.Text = video.Description;
					DurationVideo.Text = video.Duration.ToString();
					SelectedVideo = video;
					EnableLabels();
				}
				catch
				{
					MessageBox.Show("не удалось ничего найти :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			void EnableLabels()
			{
				VideoTitle.Visible = true;
				label1.Visible = true;
				DurationVideo.Visible = true;
				if(SelectedVideo != null)
				{
					button2.Enabled = true;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
