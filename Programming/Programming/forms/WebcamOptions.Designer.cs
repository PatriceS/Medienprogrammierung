namespace Programming
{
    partial class WebcamOptions
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
            this.WebcamDevicescomboBox = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebcamDevicescomboBox
            // 
            this.WebcamDevicescomboBox.FormattingEnabled = true;
            this.WebcamDevicescomboBox.Location = new System.Drawing.Point(12, 70);
            this.WebcamDevicescomboBox.Name = "WebcamDevicescomboBox";
            this.WebcamDevicescomboBox.Size = new System.Drawing.Size(260, 21);
            this.WebcamDevicescomboBox.TabIndex = 0;
            this.WebcamDevicescomboBox.SelectedIndexChanged += new System.EventHandler(this.WebcamDevicescomboBox_SelectedIndexChanged);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(13, 192);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(71, 22);
            this.ok.TabIndex = 1;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // WebcamOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.WebcamDevicescomboBox);
            this.Name = "WebcamOptions";
            this.Text = "WebcamOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebcamOptions_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox WebcamDevicescomboBox;
        private System.Windows.Forms.Button ok;
    }
}