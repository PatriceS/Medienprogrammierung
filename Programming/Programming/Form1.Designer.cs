namespace Programming
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überSompeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginTwitter = new System.Windows.Forms.Button();
            this.loginFacebook = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.publishTwitter = new System.Windows.Forms.Button();
            this.publishFacebook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.manipulationenToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bildÖffnenToolStripMenuItem,
            this.bildSpeichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.öffnenToolStripMenuItem.Text = "Menü";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // bildÖffnenToolStripMenuItem
            // 
            this.bildÖffnenToolStripMenuItem.Name = "bildÖffnenToolStripMenuItem";
            this.bildÖffnenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bildÖffnenToolStripMenuItem.Text = "Bild öffnen";
            this.bildÖffnenToolStripMenuItem.Click += new System.EventHandler(this.bildÖffnenToolStripMenuItem_Click);
            // 
            // bildSpeichernToolStripMenuItem
            // 
            this.bildSpeichernToolStripMenuItem.Name = "bildSpeichernToolStripMenuItem";
            this.bildSpeichernToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bildSpeichernToolStripMenuItem.Text = "Bild speichern";
            this.bildSpeichernToolStripMenuItem.Click += new System.EventHandler(this.bildSpeichernToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // manipulationenToolStripMenuItem
            // 
            this.manipulationenToolStripMenuItem.Name = "manipulationenToolStripMenuItem";
            this.manipulationenToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manipulationenToolStripMenuItem.Text = "Manipulationen";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überSompeToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // überSompeToolStripMenuItem
            // 
            this.überSompeToolStripMenuItem.Name = "überSompeToolStripMenuItem";
            this.überSompeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.überSompeToolStripMenuItem.Text = "Über Sompe";
            this.überSompeToolStripMenuItem.Click += new System.EventHandler(this.überSompeToolStripMenuItem_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(59, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 18);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTwitter
            // 
            this.loginTwitter.Location = new System.Drawing.Point(659, 40);
            this.loginTwitter.Name = "loginTwitter";
            this.loginTwitter.Size = new System.Drawing.Size(145, 25);
            this.loginTwitter.TabIndex = 6;
            this.loginTwitter.Text = "mit Twitter einloggen";
            this.loginTwitter.UseVisualStyleBackColor = true;
            // 
            // loginFacebook
            // 
            this.loginFacebook.Location = new System.Drawing.Point(508, 40);
            this.loginFacebook.Name = "loginFacebook";
            this.loginFacebook.Size = new System.Drawing.Size(145, 25);
            this.loginFacebook.TabIndex = 7;
            this.loginFacebook.Text = "mit Facebook einloggen";
            this.loginFacebook.UseVisualStyleBackColor = true;
            this.loginFacebook.Click += new System.EventHandler(this.loginFacebook_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfile.TabIndex = 8;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1320, 955);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1314, 843);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxProfile);
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.publishTwitter);
            this.flowLayoutPanel1.Controls.Add(this.publishFacebook);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1314, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // publishTwitter
            // 
            this.publishTwitter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.publishTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publishTwitter.BackgroundImage")));
            this.publishTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.publishTwitter.Location = new System.Drawing.Point(65, 3);
            this.publishTwitter.Name = "publishTwitter";
            this.publishTwitter.Size = new System.Drawing.Size(80, 80);
            this.publishTwitter.TabIndex = 3;
            this.publishTwitter.UseVisualStyleBackColor = false;
            this.publishTwitter.Click += new System.EventHandler(this.publishTwitter_Click);
            // 
            // publishFacebook
            // 
            this.publishFacebook.AutoSize = true;
            this.publishFacebook.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.publishFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publishFacebook.BackgroundImage")));
            this.publishFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.publishFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishFacebook.Location = new System.Drawing.Point(151, 3);
            this.publishFacebook.Name = "publishFacebook";
            this.publishFacebook.Size = new System.Drawing.Size(80, 80);
            this.publishFacebook.TabIndex = 0;
            this.publishFacebook.Text = "\r\n";
            this.publishFacebook.UseCompatibleTextRendering = true;
            this.publishFacebook.UseVisualStyleBackColor = false;
            this.publishFacebook.Click += new System.EventHandler(this.publishFacebook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1323, 677);
            this.Controls.Add(this.loginFacebook);
            this.Controls.Add(this.loginTwitter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sompe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bildÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bildSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überSompeToolStripMenuItem;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginTwitter;
        private System.Windows.Forms.Button loginFacebook;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button publishTwitter;
        private System.Windows.Forms.Button publishFacebook;
        private System.Windows.Forms.Button button1;
    }
}

