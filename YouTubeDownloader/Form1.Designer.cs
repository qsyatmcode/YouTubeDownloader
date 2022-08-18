namespace YouTubeDownloader
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.VideoTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.loadingCircle1 = new MRG.Controls.UI.LoadingCircle();
			this.settingsButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.DurationVideo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ThumbnailBox = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(596, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Искать";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// VideoTitle
			// 
			this.VideoTitle.AutoSize = true;
			this.VideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VideoTitle.Location = new System.Drawing.Point(12, 297);
			this.VideoTitle.Name = "VideoTitle";
			this.VideoTitle.Size = new System.Drawing.Size(59, 20);
			this.VideoTitle.TabIndex = 2;
			this.VideoTitle.Text = "label1";
			this.VideoTitle.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.loadingCircle1);
			this.panel1.Controls.Add(this.settingsButton);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1900, 47);
			this.panel1.TabIndex = 4;
			// 
			// loadingCircle1
			// 
			this.loadingCircle1.Active = true;
			this.loadingCircle1.Color = System.Drawing.Color.Chartreuse;
			this.loadingCircle1.InnerCircleRadius = 5;
			this.loadingCircle1.Location = new System.Drawing.Point(12, 0);
			this.loadingCircle1.Name = "loadingCircle1";
			this.loadingCircle1.NumberSpoke = 12;
			this.loadingCircle1.OuterCircleRadius = 11;
			this.loadingCircle1.RotationSpeed = 50;
			this.loadingCircle1.Size = new System.Drawing.Size(79, 51);
			this.loadingCircle1.SpokeThickness = 2;
			this.loadingCircle1.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
			this.loadingCircle1.TabIndex = 9;
			this.loadingCircle1.Text = "loadingCircle1";
			this.loadingCircle1.Visible = false;
			// 
			// settingsButton
			// 
			this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Location = new System.Drawing.Point(1768, 7);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(105, 33);
			this.settingsButton.TabIndex = 4;
			this.settingsButton.Text = "Параметры";
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LimeGreen;
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(713, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "Скачать";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(126, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(451, 22);
			this.textBox1.TabIndex = 2;
			// 
			// DurationVideo
			// 
			this.DurationVideo.AutoSize = true;
			this.DurationVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.DurationVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DurationVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.DurationVideo.Location = new System.Drawing.Point(15, 268);
			this.DurationVideo.Name = "DurationVideo";
			this.DurationVideo.Size = new System.Drawing.Size(53, 20);
			this.DurationVideo.TabIndex = 5;
			this.DurationVideo.Text = "label2";
			this.DurationVideo.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 711);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "@QsyAtmCode | v22.8.18";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(16, 320);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(810, 394);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			this.richTextBox1.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label1.Location = new System.Drawing.Point(832, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 9;
			// 
			// ThumbnailBox
			// 
			this.ThumbnailBox.Location = new System.Drawing.Point(18, 65);
			this.ThumbnailBox.Name = "ThumbnailBox";
			this.ThumbnailBox.Size = new System.Drawing.Size(338, 200);
			this.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ThumbnailBox.TabIndex = 7;
			this.ThumbnailBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1900, 728);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VideoTitle);
			this.Controls.Add(this.DurationVideo);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.ThumbnailBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(1918, 775);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YouTube video Downloader v22.8.18";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label VideoTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label DurationVideo;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox ThumbnailBox;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button settingsButton;
		private MRG.Controls.UI.LoadingCircle loadingCircle1;
		private System.Windows.Forms.Label label1;
	}
}

