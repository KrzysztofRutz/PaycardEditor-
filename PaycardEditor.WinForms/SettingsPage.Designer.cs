namespace PaycardEditor.WinForms
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ConnectionDbStatePictureBox = new PictureBox();
            CreateDbButton = new Button();
            CheckConnectionDbButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConnectionDbStatePictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(435, 199);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.24272F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7572823F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(423, 43);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold);
            label1.Location = new Point(29, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 43);
            label1.TabIndex = 0;
            label1.Text = "Ustawienia bazy danych ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gear;
            pictureBox1.Location = new Point(321, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3357F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.6643028F));
            tableLayoutPanel2.Controls.Add(ConnectionDbStatePictureBox, 1, 0);
            tableLayoutPanel2.Controls.Add(CreateDbButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CheckConnectionDbButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 58);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(423, 136);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ConnectionDbStatePictureBox
            // 
            ConnectionDbStatePictureBox.Dock = DockStyle.Fill;
            ConnectionDbStatePictureBox.Image = Properties.Resources.disconnected;
            ConnectionDbStatePictureBox.Location = new Point(199, 3);
            ConnectionDbStatePictureBox.Name = "ConnectionDbStatePictureBox";
            tableLayoutPanel2.SetRowSpan(ConnectionDbStatePictureBox, 2);
            ConnectionDbStatePictureBox.Size = new Size(221, 130);
            ConnectionDbStatePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ConnectionDbStatePictureBox.TabIndex = 9;
            ConnectionDbStatePictureBox.TabStop = false;
            // 
            // CreateDbButton
            // 
            CreateDbButton.BackColor = SystemColors.AppWorkspace;
            CreateDbButton.Cursor = Cursors.Hand;
            CreateDbButton.Dock = DockStyle.Top;
            CreateDbButton.FlatStyle = FlatStyle.Flat;
            CreateDbButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CreateDbButton.Location = new Point(3, 3);
            CreateDbButton.Name = "CreateDbButton";
            CreateDbButton.Size = new Size(190, 62);
            CreateDbButton.TabIndex = 9;
            CreateDbButton.Text = "Utwórz/zaktualizuj \r\nbazę danych";
            CreateDbButton.UseVisualStyleBackColor = false;
            CreateDbButton.Click += CreateDbButton_ClickAsync;
            // 
            // CheckConnectionDbButton
            // 
            CheckConnectionDbButton.BackColor = SystemColors.AppWorkspace;
            CheckConnectionDbButton.Cursor = Cursors.Hand;
            CheckConnectionDbButton.FlatStyle = FlatStyle.Flat;
            CheckConnectionDbButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CheckConnectionDbButton.Location = new Point(3, 71);
            CheckConnectionDbButton.Name = "CheckConnectionDbButton";
            CheckConnectionDbButton.Size = new Size(190, 62);
            CheckConnectionDbButton.TabIndex = 8;
            CheckConnectionDbButton.Text = "Sprawdź połączenie";
            CheckConnectionDbButton.UseVisualStyleBackColor = false;
            CheckConnectionDbButton.Click += CheckConnectionDbButton_ClickAsync;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 199);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ustawienia";
            Load += SettingsPage_LoadAsync;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ConnectionDbStatePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CreateDbButton;
        private PictureBox ConnectionDbStatePictureBox;
        private Button CheckConnectionDbButton;
    }
}