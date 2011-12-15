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
            this.components = new System.ComponentModel.Container();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectAlbumComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.publishFacebook = new System.Windows.Forms.Button();
            this.publishTwitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
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
            this.bildÖffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bildÖffnenToolStripMenuItem.Text = "Bild öffnen";
            this.bildÖffnenToolStripMenuItem.Click += new System.EventHandler(this.bildÖffnenToolStripMenuItem_Click);
            // 
            // bildSpeichernToolStripMenuItem
            // 
            this.bildSpeichernToolStripMenuItem.Name = "bildSpeichernToolStripMenuItem";
            this.bildSpeichernToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bildSpeichernToolStripMenuItem.Text = "Bild speichern";
            this.bildSpeichernToolStripMenuItem.Click += new System.EventHandler(this.bildSpeichernToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativToolStripMenuItem});
            this.filterToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click_1);
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
            this.überSompeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überSompeToolStripMenuItem.Text = "Über Sompe";
            this.überSompeToolStripMenuItem.Click += new System.EventHandler(this.überSompeToolStripMenuItem_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(83, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 18);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTwitter
            // 
            this.loginTwitter.Location = new System.Drawing.Point(408, 3);
            this.loginTwitter.Name = "loginTwitter";
            this.loginTwitter.Size = new System.Drawing.Size(86, 25);
            this.loginTwitter.TabIndex = 6;
            this.loginTwitter.Text = "mit Twitter einloggen";
            this.loginTwitter.UseVisualStyleBackColor = true;
            // 
            // loginFacebook
            // 
            this.loginFacebook.Location = new System.Drawing.Point(304, 3);
            this.loginFacebook.Name = "loginFacebook";
            this.loginFacebook.Size = new System.Drawing.Size(98, 25);
            this.loginFacebook.TabIndex = 7;
            this.loginFacebook.Text = "mit Facebook einloggen";
            this.loginFacebook.UseVisualStyleBackColor = true;
            this.loginFacebook.Click += new System.EventHandler(this.loginFacebook_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(80, 86);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 8;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 668);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.selectAlbumComboBox);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 662);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // selectAlbumComboBox
            // 
            this.selectAlbumComboBox.FormattingEnabled = true;
            this.selectAlbumComboBox.Location = new System.Drawing.Point(3, 3);
            this.selectAlbumComboBox.Name = "selectAlbumComboBox";
            this.selectAlbumComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectAlbumComboBox.TabIndex = 9;
            this.selectAlbumComboBox.SelectedIndexChanged += new System.EventHandler(this.selectAlbumComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.publishFacebook, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.publishTwitter, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 448);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.usernameLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxProfile, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 86);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // publishFacebook
            // 
            this.publishFacebook.AutoSize = true;
            this.publishFacebook.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.publishFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publishFacebook.BackgroundImage")));
            this.publishFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.publishFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishFacebook.Location = new System.Drawing.Point(0, 94);
            this.publishFacebook.Margin = new System.Windows.Forms.Padding(0);
            this.publishFacebook.Name = "publishFacebook";
            this.publishFacebook.Size = new System.Drawing.Size(83, 83);
            this.publishFacebook.TabIndex = 0;
            this.publishFacebook.Text = "\r\n";
            this.publishFacebook.UseCompatibleTextRendering = true;
            this.publishFacebook.UseVisualStyleBackColor = false;
            this.publishFacebook.Click += new System.EventHandler(this.publishFacebook_Click);
            // 
            // publishTwitter
            // 
            this.publishTwitter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.publishTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publishTwitter.BackgroundImage")));
            this.publishTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.publishTwitter.Location = new System.Drawing.Point(0, 177);
            this.publishTwitter.Margin = new System.Windows.Forms.Padding(0);
            this.publishTwitter.Name = "publishTwitter";
            this.publishTwitter.Size = new System.Drawing.Size(83, 83);
            this.publishTwitter.TabIndex = 3;
            this.publishTwitter.UseVisualStyleBackColor = false;
            this.publishTwitter.Click += new System.EventHandler(this.publishTwitter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(207, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.Controls.Add(this.loginFacebook, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.loginTwitter, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.infoBox, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(498, 44);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 37);
            this.progressBar1.TabIndex = 9;
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click_1);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(153, 3);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(145, 25);
            this.infoBox.TabIndex = 11;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Programming.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1031, 742);
            this.Controls.Add(this.tableLayoutPanel4);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button publishTwitter;
        private System.Windows.Forms.Button publishFacebook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectAlbumComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.BindingSource userBindingSource;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.TextBox infoBox;
    }
}

