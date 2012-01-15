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
            this.bildSchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rueckgaengigMachenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwingungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graustufenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwarzWeißToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorDiffusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbkanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbpaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farben_4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farben_8ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.farben_16ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelUploadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.selectAlbumComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.publishFacebook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotate90 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rotate270 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.infoThreads = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.infoTime = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.bearbeitenToolStripMenuItem,
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
            this.bildSchließenToolStripMenuItem,
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
            this.bildSpeichernToolStripMenuItem.Enabled = false;
            this.bildSpeichernToolStripMenuItem.Name = "bildSpeichernToolStripMenuItem";
            this.bildSpeichernToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bildSpeichernToolStripMenuItem.Text = "Bild speichern";
            this.bildSpeichernToolStripMenuItem.Click += new System.EventHandler(this.bildSpeichernToolStripMenuItem_Click);
            // 
            // bildSchließenToolStripMenuItem
            // 
            this.bildSchließenToolStripMenuItem.Enabled = false;
            this.bildSchließenToolStripMenuItem.Name = "bildSchließenToolStripMenuItem";
            this.bildSchließenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bildSchließenToolStripMenuItem.Text = "Bild schließen";
            this.bildSchließenToolStripMenuItem.Click += new System.EventHandler(this.bildSchließenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rueckgaengigMachenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // rueckgaengigMachenToolStripMenuItem
            // 
            this.rueckgaengigMachenToolStripMenuItem.AccessibleName = "rueckgaengigMachenToolStripMenuItem";
            this.rueckgaengigMachenToolStripMenuItem.Enabled = false;
            this.rueckgaengigMachenToolStripMenuItem.Name = "rueckgaengigMachenToolStripMenuItem";
            this.rueckgaengigMachenToolStripMenuItem.ShortcutKeyDisplayString = "(strg+z)";
            this.rueckgaengigMachenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.rueckgaengigMachenToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.rueckgaengigMachenToolStripMenuItem.Text = "Rückgängig machen";
            this.rueckgaengigMachenToolStripMenuItem.Click += new System.EventHandler(this.rueckgaengigMachenToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativToolStripMenuItem,
            this.schwingungToolStripMenuItem,
            this.graustufenToolStripMenuItem,
            this.schwarzWeißToolStripMenuItem,
            this.errorDiffusionToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.farbkanalToolStripMenuItem,
            this.farbpaletteToolStripMenuItem});
            this.filterToolStripMenuItem.Enabled = false;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click_1);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click_1);
            // 
            // schwingungToolStripMenuItem
            // 
            this.schwingungToolStripMenuItem.Name = "schwingungToolStripMenuItem";
            this.schwingungToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.schwingungToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.schwingungToolStripMenuItem.Text = "Schwingung";
            this.schwingungToolStripMenuItem.Click += new System.EventHandler(this.schwingungToolStripMenuItem_Click);
            // 
            // graustufenToolStripMenuItem
            // 
            this.graustufenToolStripMenuItem.Name = "graustufenToolStripMenuItem";
            this.graustufenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.graustufenToolStripMenuItem.Text = "Graustufen";
            this.graustufenToolStripMenuItem.Click += new System.EventHandler(this.graustufenToolStripMenuItem_Click);
            // 
            // schwarzWeißToolStripMenuItem
            // 
            this.schwarzWeißToolStripMenuItem.Name = "schwarzWeißToolStripMenuItem";
            this.schwarzWeißToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.schwarzWeißToolStripMenuItem.Text = "Schwarz/Weiß";
            this.schwarzWeißToolStripMenuItem.Click += new System.EventHandler(this.schwarzWeißToolStripMenuItem_Click);
            // 
            // errorDiffusionToolStripMenuItem
            // 
            this.errorDiffusionToolStripMenuItem.Name = "errorDiffusionToolStripMenuItem";
            this.errorDiffusionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.errorDiffusionToolStripMenuItem.Text = "Error Diffusion";
            this.errorDiffusionToolStripMenuItem.Click += new System.EventHandler(this.errorDiffusionToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // farbkanalToolStripMenuItem
            // 
            this.farbkanalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotToolStripMenuItem,
            this.grünToolStripMenuItem,
            this.blauToolStripMenuItem});
            this.farbkanalToolStripMenuItem.Name = "farbkanalToolStripMenuItem";
            this.farbkanalToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.farbkanalToolStripMenuItem.Text = "Farbkanal";
            // 
            // rotToolStripMenuItem
            // 
            this.rotToolStripMenuItem.Name = "rotToolStripMenuItem";
            this.rotToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.rotToolStripMenuItem.Text = "Rot";
            this.rotToolStripMenuItem.Click += new System.EventHandler(this.rotToolStripMenuItem_Click);
            // 
            // grünToolStripMenuItem
            // 
            this.grünToolStripMenuItem.Name = "grünToolStripMenuItem";
            this.grünToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.grünToolStripMenuItem.Text = "Grün";
            this.grünToolStripMenuItem.Click += new System.EventHandler(this.grünToolStripMenuItem_Click);
            // 
            // blauToolStripMenuItem
            // 
            this.blauToolStripMenuItem.Name = "blauToolStripMenuItem";
            this.blauToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.blauToolStripMenuItem.Text = "Blau";
            this.blauToolStripMenuItem.Click += new System.EventHandler(this.blauToolStripMenuItem_Click);
            // 
            // farbpaletteToolStripMenuItem
            // 
            this.farbpaletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farben_4ToolStripMenuItem,
            this.farben_8ToolStripMenuItem1,
            this.farben_16ToolStripMenuItem2});
            this.farbpaletteToolStripMenuItem.Name = "farbpaletteToolStripMenuItem";
            this.farbpaletteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.farbpaletteToolStripMenuItem.Text = "Farbpalette";
            // 
            // farben_4ToolStripMenuItem
            // 
            this.farben_4ToolStripMenuItem.AccessibleName = "4_farbenToolStripMenuItem_Click";
            this.farben_4ToolStripMenuItem.Name = "farben_4ToolStripMenuItem";
            this.farben_4ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.farben_4ToolStripMenuItem.Text = "4 Farben";
            this.farben_4ToolStripMenuItem.Click += new System.EventHandler(this.farben_4ToolStripMenuItem_Click);
            // 
            // farben_8ToolStripMenuItem1
            // 
            this.farben_8ToolStripMenuItem1.Name = "farben_8ToolStripMenuItem1";
            this.farben_8ToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.farben_8ToolStripMenuItem1.Text = "8 Farben";
            this.farben_8ToolStripMenuItem1.Click += new System.EventHandler(this.farben_8ToolStripMenuItem1_Click);
            // 
            // farben_16ToolStripMenuItem2
            // 
            this.farben_16ToolStripMenuItem2.Name = "farben_16ToolStripMenuItem2";
            this.farben_16ToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.farben_16ToolStripMenuItem2.Text = "16 Farben";
            this.farben_16ToolStripMenuItem2.Click += new System.EventHandler(this.farben_16ToolStripMenuItem2_Click);
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
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(53, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 51);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginTwitter
            // 
            this.loginTwitter.AutoSize = true;
            this.loginTwitter.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginTwitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTwitter.Image = ((System.Drawing.Image)(resources.GetObject("loginTwitter.Image")));
            this.loginTwitter.Location = new System.Drawing.Point(128, 3);
            this.loginTwitter.Name = "loginTwitter";
            this.loginTwitter.Size = new System.Drawing.Size(119, 35);
            this.loginTwitter.TabIndex = 6;
            this.loginTwitter.Text = "mit Twitter einloggen";
            this.loginTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginTwitter.UseVisualStyleBackColor = false;
            // 
            // loginFacebook
            // 
            this.loginFacebook.AutoSize = true;
            this.loginFacebook.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginFacebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFacebook.Image = ((System.Drawing.Image)(resources.GetObject("loginFacebook.Image")));
            this.loginFacebook.Location = new System.Drawing.Point(3, 3);
            this.loginFacebook.Name = "loginFacebook";
            this.loginFacebook.Size = new System.Drawing.Size(119, 35);
            this.loginFacebook.TabIndex = 7;
            this.loginFacebook.Text = "mit Facebook einloggen";
            this.loginFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginFacebook.UseVisualStyleBackColor = false;
            this.loginFacebook.Click += new System.EventHandler(this.loginFacebook_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(50, 50);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 668);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 662);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cancelUploadButton, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.publishFacebook, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 540);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // cancelUploadButton
            // 
            this.cancelUploadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelUploadButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelUploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelUploadButton.Enabled = false;
            this.cancelUploadButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelUploadButton.Image")));
            this.cancelUploadButton.Location = new System.Drawing.Point(17, 264);
            this.cancelUploadButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelUploadButton.Name = "cancelUploadButton";
            this.cancelUploadButton.Size = new System.Drawing.Size(160, 40);
            this.cancelUploadButton.TabIndex = 12;
            this.cancelUploadButton.Text = "Upload abbrechen";
            this.cancelUploadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelUploadButton.UseVisualStyleBackColor = false;
            this.cancelUploadButton.Click += new System.EventHandler(this.cancelUploadButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 219);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(189, 42);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(12, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upload-Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.selectAlbumComboBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 112);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(189, 60);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // selectAlbumComboBox
            // 
            this.selectAlbumComboBox.FormattingEnabled = true;
            this.selectAlbumComboBox.Location = new System.Drawing.Point(3, 32);
            this.selectAlbumComboBox.Name = "selectAlbumComboBox";
            this.selectAlbumComboBox.Size = new System.Drawing.Size(183, 21);
            this.selectAlbumComboBox.Sorted = true;
            this.selectAlbumComboBox.TabIndex = 9;
            this.selectAlbumComboBox.SelectedIndexChanged += new System.EventHandler(this.selectAlbumComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deine Facebook-Alben";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(189, 46);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxProfile, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.usernameLabel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(189, 51);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // publishFacebook
            // 
            this.publishFacebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishFacebook.BackColor = System.Drawing.SystemColors.Highlight;
            this.publishFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.publishFacebook.Enabled = false;
            this.publishFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishFacebook.Image = ((System.Drawing.Image)(resources.GetObject("publishFacebook.Image")));
            this.publishFacebook.Location = new System.Drawing.Point(17, 175);
            this.publishFacebook.Margin = new System.Windows.Forms.Padding(0);
            this.publishFacebook.Name = "publishFacebook";
            this.publishFacebook.Size = new System.Drawing.Size(160, 40);
            this.publishFacebook.TabIndex = 0;
            this.publishFacebook.Text = "Bild auf Facebook veröffentlichen";
            this.publishFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.publishFacebook.UseVisualStyleBackColor = false;
            this.publishFacebook.Click += new System.EventHandler(this.publishFacebook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(209, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(810, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rotate90
            // 
            this.rotate90.BackColor = System.Drawing.SystemColors.Highlight;
            this.rotate90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate90.Image = ((System.Drawing.Image)(resources.GetObject("rotate90.Image")));
            this.rotate90.Location = new System.Drawing.Point(253, 3);
            this.rotate90.Name = "rotate90";
            this.rotate90.Size = new System.Drawing.Size(39, 35);
            this.rotate90.TabIndex = 4;
            this.rotate90.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rotate90.UseVisualStyleBackColor = false;
            this.rotate90.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.Controls.Add(this.rotate270, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.rotate90, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.loginFacebook, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.loginTwitter, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(787, 41);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // rotate270
            // 
            this.rotate270.BackColor = System.Drawing.SystemColors.Highlight;
            this.rotate270.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotate270.Image = ((System.Drawing.Image)(resources.GetObject("rotate270.Image")));
            this.rotate270.Location = new System.Drawing.Point(298, 3);
            this.rotate270.Name = "rotate270";
            this.rotate270.Size = new System.Drawing.Size(39, 35);
            this.rotate270.TabIndex = 8;
            this.rotate270.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(891, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.Text = "Anzahl der Threads:";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoThreads
            // 
            this.infoThreads.AutoSize = true;
            this.infoThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoThreads.Location = new System.Drawing.Point(988, 27);
            this.infoThreads.Name = "infoThreads";
            this.infoThreads.Size = new System.Drawing.Size(0, 13);
            this.infoThreads.TabIndex = 13;
            this.infoThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(10, 0);
            this.linkLabel2.Location = new System.Drawing.Point(965, 41);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(26, 17);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.Text = "Zeit:";
            this.linkLabel2.UseCompatibleTextRendering = true;
            // 
            // infoTime
            // 
            this.infoTime.AutoSize = true;
            this.infoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTime.Location = new System.Drawing.Point(988, 41);
            this.infoTime.Name = "infoTime";
            this.infoTime.Size = new System.Drawing.Size(0, 13);
            this.infoTime.TabIndex = 15;
            this.infoTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Programming.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1031, 742);
            this.Controls.Add(this.infoTime);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.infoThreads);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sompe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
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
        
        private System.Windows.Forms.Button rotate90;
        private System.Windows.Forms.ComboBox selectAlbumComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        public System.Windows.Forms.Button cancelUploadButton;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button publishFacebook;
        private System.Windows.Forms.ToolStripMenuItem bildSchließenToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem schwingungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graustufenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwarzWeißToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorDiffusionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rueckgaengigMachenToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label infoThreads;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label infoTime;
        private System.Windows.Forms.ToolStripMenuItem farbkanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blauToolStripMenuItem;
        private System.Windows.Forms.Button rotate270;
        private System.Windows.Forms.ToolStripMenuItem farbpaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farben_4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farben_8ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem farben_16ToolStripMenuItem2;

    }
}

