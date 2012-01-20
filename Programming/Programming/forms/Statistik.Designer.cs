﻿namespace Programming
{
    partial class Statistik
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
            this.statistikPictureBox = new System.Windows.Forms.PictureBox();
            this.all_channel_radio = new System.Windows.Forms.RadioButton();
            this.blue_channel_radio = new System.Windows.Forms.RadioButton();
            this.green_channel_radio = new System.Windows.Forms.RadioButton();
            this.red_channel_radio = new System.Windows.Forms.RadioButton();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.entropyLabel = new System.Windows.Forms.Label();
            this.statistikRefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statistikPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statistikPictureBox
            // 
            this.statistikPictureBox.Location = new System.Drawing.Point(12, 17);
            this.statistikPictureBox.Name = "statistikPictureBox";
            this.statistikPictureBox.Size = new System.Drawing.Size(395, 101);
            this.statistikPictureBox.TabIndex = 0;
            this.statistikPictureBox.TabStop = false;
            // 
            // all_channel_radio
            // 
            this.all_channel_radio.AutoSize = true;
            this.all_channel_radio.Location = new System.Drawing.Point(413, 15);
            this.all_channel_radio.Name = "all_channel_radio";
            this.all_channel_radio.Size = new System.Drawing.Size(77, 17);
            this.all_channel_radio.TabIndex = 5;
            this.all_channel_radio.TabStop = true;
            this.all_channel_radio.Text = "alle Kanäle";
            this.all_channel_radio.UseVisualStyleBackColor = true;
            this.all_channel_radio.CheckedChanged += new System.EventHandler(this.all_channel_radio_CheckedChanged);
            // 
            // blue_channel_radio
            // 
            this.blue_channel_radio.AutoSize = true;
            this.blue_channel_radio.Location = new System.Drawing.Point(413, 84);
            this.blue_channel_radio.Name = "blue_channel_radio";
            this.blue_channel_radio.Size = new System.Drawing.Size(84, 17);
            this.blue_channel_radio.TabIndex = 6;
            this.blue_channel_radio.TabStop = true;
            this.blue_channel_radio.Text = "blauer Kanal";
            this.blue_channel_radio.UseVisualStyleBackColor = true;
            this.blue_channel_radio.CheckedChanged += new System.EventHandler(this.blue_channel_radio_CheckedChanged);
            // 
            // green_channel_radio
            // 
            this.green_channel_radio.AutoSize = true;
            this.green_channel_radio.Location = new System.Drawing.Point(413, 61);
            this.green_channel_radio.Name = "green_channel_radio";
            this.green_channel_radio.Size = new System.Drawing.Size(85, 17);
            this.green_channel_radio.TabIndex = 7;
            this.green_channel_radio.TabStop = true;
            this.green_channel_radio.Text = "grüner Kanal";
            this.green_channel_radio.UseVisualStyleBackColor = true;
            this.green_channel_radio.CheckedChanged += new System.EventHandler(this.green_channel_radio_CheckedChanged);
            // 
            // red_channel_radio
            // 
            this.red_channel_radio.AutoSize = true;
            this.red_channel_radio.Location = new System.Drawing.Point(413, 38);
            this.red_channel_radio.Name = "red_channel_radio";
            this.red_channel_radio.Size = new System.Drawing.Size(76, 17);
            this.red_channel_radio.TabIndex = 8;
            this.red_channel_radio.TabStop = true;
            this.red_channel_radio.Text = "roter Kanal";
            this.red_channel_radio.UseVisualStyleBackColor = true;
            this.red_channel_radio.CheckedChanged += new System.EventHandler(this.red_channel_radio_CheckedChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(12, 121);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(75, 13);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "min Helligkeit: ";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(12, 149);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(78, 13);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "max Helligkeit: ";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(12, 176);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(58, 13);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "Mittelwert: ";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Location = new System.Drawing.Point(12, 202);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(51, 13);
            this.varianceLabel.TabIndex = 12;
            this.varianceLabel.Text = "Varianz:  ";
            // 
            // entropyLabel
            // 
            this.entropyLabel.AutoSize = true;
            this.entropyLabel.Location = new System.Drawing.Point(12, 229);
            this.entropyLabel.Name = "entropyLabel";
            this.entropyLabel.Size = new System.Drawing.Size(52, 13);
            this.entropyLabel.TabIndex = 13;
            this.entropyLabel.Text = "Entropie: ";
            // 
            // statistikRefreshButton
            // 
            this.statistikRefreshButton.Location = new System.Drawing.Point(377, 216);
            this.statistikRefreshButton.Name = "statistikRefreshButton";
            this.statistikRefreshButton.Size = new System.Drawing.Size(113, 23);
            this.statistikRefreshButton.TabIndex = 14;
            this.statistikRefreshButton.Text = "neu berechnen";
            this.statistikRefreshButton.UseVisualStyleBackColor = true;
            this.statistikRefreshButton.Click += new System.EventHandler(this.statistikRefreshButton_Click);
            // 
            // Statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 251);
            this.Controls.Add(this.statistikRefreshButton);
            this.Controls.Add(this.entropyLabel);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.red_channel_radio);
            this.Controls.Add(this.green_channel_radio);
            this.Controls.Add(this.blue_channel_radio);
            this.Controls.Add(this.all_channel_radio);
            this.Controls.Add(this.statistikPictureBox);
            this.Name = "Statistik";
            this.Text = "Statistik";
            this.Load += new System.EventHandler(this.Statistik_Load);
            this.Shown += new System.EventHandler(this.Statistik_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.statistikPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statistikPictureBox;
        private System.Windows.Forms.RadioButton all_channel_radio;
        private System.Windows.Forms.RadioButton blue_channel_radio;
        private System.Windows.Forms.RadioButton green_channel_radio;
        private System.Windows.Forms.RadioButton red_channel_radio;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label entropyLabel;
        private System.Windows.Forms.Button statistikRefreshButton;
    }
}