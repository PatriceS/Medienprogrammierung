namespace Programming
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
            ((System.ComponentModel.ISupportInitialize)(this.statistikPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statistikPictureBox
            // 
            this.statistikPictureBox.Location = new System.Drawing.Point(12, 12);
            this.statistikPictureBox.Name = "statistikPictureBox";
            this.statistikPictureBox.Size = new System.Drawing.Size(395, 193);
            this.statistikPictureBox.TabIndex = 0;
            this.statistikPictureBox.TabStop = false;
            // 
            // all_channel_radio
            // 
            this.all_channel_radio.AutoSize = true;
            this.all_channel_radio.Location = new System.Drawing.Point(534, 12);
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
            this.blue_channel_radio.Location = new System.Drawing.Point(534, 81);
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
            this.green_channel_radio.Location = new System.Drawing.Point(534, 58);
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
            this.red_channel_radio.Location = new System.Drawing.Point(534, 35);
            this.red_channel_radio.Name = "red_channel_radio";
            this.red_channel_radio.Size = new System.Drawing.Size(76, 17);
            this.red_channel_radio.TabIndex = 8;
            this.red_channel_radio.TabStop = true;
            this.red_channel_radio.Text = "roter Kanal";
            this.red_channel_radio.UseVisualStyleBackColor = true;
            this.red_channel_radio.CheckedChanged += new System.EventHandler(this.red_channel_radio_CheckedChanged);
            // 
            // Statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 565);
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
    }
}