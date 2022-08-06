using System;
using System.Linq;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownloader
{
	public partial class Form1 : Form
	{
		public static YoutubeClient client;
		public static YoutubeExplode.Videos.Video SelectedVideo;
		private static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		//public static YoutubeExplode.Videos.Streams.IStreamInfo streamInfo;
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
				richTextBox1.Text = video.Description;
				DurationVideo.Text = video.Duration.ToString();
				SelectedVideo = video;
				var thumbnail = video.Thumbnails[0];
				string thumbnailUrl = thumbnail.Url.ToString().Split('?')[0];
				ThumbnailBox.WaitOnLoad = false;
				ThumbnailBox.LoadAsync(thumbnailUrl);
				ThumbnailBox.Width = thumbnail.Resolution.Width * 2;
				ThumbnailBox.Height = thumbnail.Resolution.Height * 2;
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
					richTextBox1.Text = video.Description;
					DurationVideo.Text = video.Duration.ToString();
					SelectedVideo = video;
					var thumbnail = video.Thumbnails[0];
					string thumbnailUrl = thumbnail.Url.ToString().Split('?')[0];
					ThumbnailBox.WaitOnLoad = false;
					ThumbnailBox.LoadAsync(thumbnailUrl);
					ThumbnailBox.Width = thumbnail.Resolution.Width * 2;
					ThumbnailBox.Height = thumbnail.Resolution.Height * 2;
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
				DurationVideo.Visible = true;
				richTextBox1.Visible = true;
				if (SelectedVideo != null)
				{
					button2.Enabled = true;
				}
				DurationVideo.Location = ThumbnailBox.Location;
			}
		}
		private static int fileCount = 0;
		private async void button2_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show(SavePath, "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.Yes)
			{
				var streamManifest = await client.Videos.Streams.GetManifestAsync(SelectedVideo.Id);
				IStreamInfo StreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
				var stream = await client.Videos.Streams.GetAsync(StreamInfo);
				await client.Videos.Streams.DownloadAsync(StreamInfo, SavePath + "\\video" + fileCount + "." + StreamInfo.Container);
				fileCount++;
				
				MessageBox.Show("Download"); // TODO
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
		}
	}
}
