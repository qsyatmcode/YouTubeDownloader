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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.DurationVideo = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(580, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// VideoTitle
			// 
			this.VideoTitle.AutoSize = true;
			this.VideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VideoTitle.Location = new System.Drawing.Point(12, 262);
			this.VideoTitle.Name = "VideoTitle";
			this.VideoTitle.Size = new System.Drawing.Size(59, 20);
			this.VideoTitle.TabIndex = 2;
			this.VideoTitle.Text = "label1";
			this.VideoTitle.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1081, 47);
			this.panel1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(451, 22);
			this.textBox1.TabIndex = 2;
			// 
			// DurationVideo
			// 
			this.DurationVideo.AutoSize = true;
			this.DurationVideo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.DurationVideo.Location = new System.Drawing.Point(15, 236);
			this.DurationVideo.Name = "DurationVideo";
			this.DurationVideo.Size = new System.Drawing.Size(44, 16);
			this.DurationVideo.TabIndex = 5;
			this.DurationVideo.Text = "label2";
			this.DurationVideo.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LimeGreen;
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(697, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "Download this";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 511);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "@QsyAtmCode | v22.8.4";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 528);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DurationVideo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VideoTitle);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YouTube video Downloader v22.8.4";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label VideoTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label DurationVideo;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
	}
}

