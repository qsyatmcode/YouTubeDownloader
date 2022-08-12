﻿using System;
using System.Linq;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;
using System.Security.Cryptography;

namespace YouTubeDownloader
{
	public enum SaveMode
	{
		Audio,
		Video,
		Mixed
	}
	public partial class Form1 : Form
	{
		public static YoutubeClient client;
		public static YoutubeExplode.Videos.Video SelectedVideo;
		public static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		public static SaveMode saveMode = SaveMode.Mixed;

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
			try // Поиск по URL
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
				try // Поиск по названию
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
		private async void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var streamManifest = await client.Videos.Streams.GetManifestAsync(SelectedVideo.Id);
				IStreamInfo StreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
				var stream = await client.Videos.Streams.GetAsync(StreamInfo);
				DialogResult dialogResult = MessageBox.Show($"Файл будет сохранен в каталоге: {SavePath}" + Environment.NewLine + $"Режим скачивания: {saveMode}" + Environment.NewLine + $"Размер файла составит: {StreamInfo.Size}", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (dialogResult == DialogResult.Yes)
				{
					await client.Videos.Streams.DownloadAsync(StreamInfo, SavePath + $"\\{GenerateSavename()}" + "." + StreamInfo.Container);
					// НАДО СДЕЛАТЬ ПРОГРЕСС БАР ПРОЦЕССА ЗАГРУЗКИ
					MessageBox.Show("Скачивание завершено!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else if (dialogResult == DialogResult.No)
				{
					return;
				}
			}
			catch
			{
				MessageBox.Show("Не удалось начать скачивание видеоролика. Возможно вы пытаетесь скачать прямую транслацию", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			SettingsFormcs sf = new SettingsFormcs();
			sf.Show();
		}
		private static string GenerateSavename()
		{
			string output = String.Empty;
			int seed = 0;
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				var buffer = new byte[4];
				rng.GetBytes(buffer);
				seed = BitConverter.ToInt32(buffer, 0);
			}
			Random rnd = new Random(seed);
			for(int i = 0; i <= 12; i++)
			{
				output += Convert.ToString(rnd.Next());
			}
			return output.Substring(output.Length - 12);
		}
	}
}
