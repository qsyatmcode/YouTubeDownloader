﻿namespace YouTubeDownloader
{
	partial class SettingsFormcs
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
			this.button1 = new System.Windows.Forms.Button();
			this.saveLocationBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(0, 522);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(582, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(172, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(327, 22);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(505, 39);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(67, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Обзор..";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Путь сохранения видео:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Режим сохранения:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(140, 95);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.Gold;
			this.checkBox1.Location = new System.Drawing.Point(251, 155);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(264, 20);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Наивысшее качество звука и видео";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(263, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "* Видео только в качестве 720p!";
			this.label3.Visible = false;
			// 
			// SettingsFormcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 562);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsFormcs";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog saveLocationBrowserDialog;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
	}
}