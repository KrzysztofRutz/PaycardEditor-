
namespace PaycardEditor.WinForms
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SettingsButton = new Button();
            DeleteButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            KindOfSearchComboBox = new ComboBox();
            label1 = new Label();
            SearchTextbox = new TextBox();
            SearchButton = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            SerialNrLabel = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            SerialNrTextbox = new TextBox();
            label5 = new Label();
            PINTextbox = new TextBox();
            label4 = new Label();
            OwnerAccountNrTextbox = new TextBox();
            CardIdTextbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            NextRecordButton = new Button();
            PreviousRecordButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(192, 255, 255);
            SettingsButton.BackgroundImage = Properties.Resources.settings;
            SettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsButton.Cursor = Cursors.Hand;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Location = new Point(3, 3);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(66, 72);
            SettingsButton.TabIndex = 1;
            SettingsButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.BackgroundImage = Properties.Resources.delete;
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(147, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(66, 72);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(87, 179, 254);
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AddButton, 1, 0);
            tableLayoutPanel1.Controls.Add(SettingsButton, 0, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 7, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 8, 0);
            tableLayoutPanel1.Controls.Add(label3, 9, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 10, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(936, 78);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.BackgroundImage = Properties.Resources.more;
            AddButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(75, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(66, 72);
            AddButton.TabIndex = 8;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.FromArgb(42, 130, 218);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(KindOfSearchComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(SearchTextbox, 1, 1);
            tableLayoutPanel2.Location = new Point(219, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(357, 70);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // KindOfSearchComboBox
            // 
            KindOfSearchComboBox.BackColor = Color.WhiteSmoke;
            KindOfSearchComboBox.Dock = DockStyle.Left;
            KindOfSearchComboBox.FlatStyle = FlatStyle.Flat;
            KindOfSearchComboBox.Font = new Font("Segoe UI", 10F);
            KindOfSearchComboBox.FormattingEnabled = true;
            KindOfSearchComboBox.Location = new Point(3, 38);
            KindOfSearchComboBox.Name = "KindOfSearchComboBox";
            KindOfSearchComboBox.Size = new Size(162, 25);
            KindOfSearchComboBox.TabIndex = 3;
            KindOfSearchComboBox.SelectedValueChanged += KindOfSearchComboBox_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 5;
            label1.Text = "Wyszukaj kartę po: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchTextbox
            // 
            SearchTextbox.BackColor = Color.WhiteSmoke;
            SearchTextbox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextbox.Dock = DockStyle.Fill;
            SearchTextbox.Font = new Font("Segoe UI", 10F);
            SearchTextbox.Location = new Point(171, 38);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(183, 25);
            SearchTextbox.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(224, 224, 224);
            SearchButton.BackgroundImage = Properties.Resources.loop;
            SearchButton.BackgroundImageLayout = ImageLayout.Stretch;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(582, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(66, 72);
            SearchButton.TabIndex = 7;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(654, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 78);
            label3.TabIndex = 9;
            label3.Text = "Paycard 3dit0r";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.debit_card;
            pictureBox3.Location = new Point(813, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Paycard;
            pictureBox1.Location = new Point(384, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SerialNrLabel
            // 
            SerialNrLabel.AutoSize = true;
            SerialNrLabel.BackColor = Color.Silver;
            SerialNrLabel.Font = new Font("Segoe UI", 18F);
            SerialNrLabel.Location = new Point(505, 271);
            SerialNrLabel.Name = "SerialNrLabel";
            SerialNrLabel.Size = new Size(195, 32);
            SerialNrLabel.TabIndex = 6;
            SerialNrLabel.Text = "---- ---- ---- ----";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 119, 169);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 353);
            panel1.TabIndex = 7;
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(87, 179, 254);
            label11.Location = new Point(-1, 272);
            label11.Name = "label11";
            label11.Size = new Size(412, 23);
            label11.TabIndex = 6;
            label11.Text = "---------------------------------------------------------------------------------";
            // 
            // label10
            // 
            label10.ForeColor = Color.FromArgb(87, 179, 254);
            label10.Location = new Point(-2, 200);
            label10.Name = "label10";
            label10.Size = new Size(412, 23);
            label10.TabIndex = 5;
            label10.Text = "---------------------------------------------------------------------------------";
            // 
            // label9
            // 
            label9.ForeColor = Color.FromArgb(87, 179, 254);
            label9.Location = new Point(-2, 125);
            label9.Name = "label9";
            label9.Size = new Size(412, 23);
            label9.TabIndex = 4;
            label9.Text = "---------------------------------------------------------------------------------";
            // 
            // label8
            // 
            label8.ForeColor = Color.FromArgb(87, 179, 254);
            label8.Location = new Point(-2, 49);
            label8.Name = "label8";
            label8.Size = new Size(412, 23);
            label8.TabIndex = 3;
            label8.Text = "---------------------------------------------------------------------------------";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.09938F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.90062F));
            tableLayoutPanel3.Controls.Add(label7, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(SerialNrTextbox, 1, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(PINTextbox, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(OwnerAccountNrTextbox, 1, 0);
            tableLayoutPanel3.Controls.Add(CardIdTextbox, 1, 3);
            tableLayoutPanel3.Location = new Point(0, 59);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(410, 294);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(44, 245);
            label7.Name = "label7";
            label7.Size = new Size(133, 23);
            label7.TabIndex = 6;
            label7.Text = "Identyfikator karty:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(44, 171);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 4;
            label6.Text = "Nr seryjny karty";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SerialNrTextbox
            // 
            SerialNrTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SerialNrTextbox.Location = new Point(183, 171);
            SerialNrTextbox.Name = "SerialNrTextbox";
            SerialNrTextbox.ReadOnly = true;
            SerialNrTextbox.Size = new Size(224, 23);
            SerialNrTextbox.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(44, 98);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 2;
            label5.Text = "PIN:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PINTextbox
            // 
            PINTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PINTextbox.Location = new Point(183, 98);
            PINTextbox.Name = "PINTextbox";
            PINTextbox.ReadOnly = true;
            PINTextbox.Size = new Size(224, 23);
            PINTextbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(44, 25);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 0;
            label4.Text = "Nr konta właściciela:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OwnerAccountNrTextbox
            // 
            OwnerAccountNrTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            OwnerAccountNrTextbox.Location = new Point(183, 25);
            OwnerAccountNrTextbox.Name = "OwnerAccountNrTextbox";
            OwnerAccountNrTextbox.ReadOnly = true;
            OwnerAccountNrTextbox.Size = new Size(224, 23);
            OwnerAccountNrTextbox.TabIndex = 1;
            // 
            // CardIdTextbox
            // 
            CardIdTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CardIdTextbox.BackColor = SystemColors.Control;
            CardIdTextbox.BorderStyle = BorderStyle.None;
            CardIdTextbox.Location = new Point(183, 248);
            CardIdTextbox.Name = "CardIdTextbox";
            CardIdTextbox.ReadOnly = true;
            CardIdTextbox.Size = new Size(224, 16);
            CardIdTextbox.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.36027F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.63973F));
            tableLayoutPanel4.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(410, 49);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.atm_card;
            pictureBox2.Location = new Point(287, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 56);
            label2.TabIndex = 1;
            label2.Text = "Szczegóły karty";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NextRecordButton
            // 
            NextRecordButton.BackgroundImage = Properties.Resources.right_arrow;
            NextRecordButton.BackgroundImageLayout = ImageLayout.Zoom;
            NextRecordButton.Cursor = Cursors.Hand;
            NextRecordButton.FlatAppearance.BorderSize = 0;
            NextRecordButton.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            NextRecordButton.FlatStyle = FlatStyle.Flat;
            NextRecordButton.Location = new Point(874, 250);
            NextRecordButton.Name = "NextRecordButton";
            NextRecordButton.Size = new Size(63, 53);
            NextRecordButton.TabIndex = 8;
            NextRecordButton.UseVisualStyleBackColor = true;
            NextRecordButton.Click += NextRecordButton_Click;
            // 
            // PreviousRecordButton
            // 
            PreviousRecordButton.BackgroundImage = Properties.Resources.left_arrow;
            PreviousRecordButton.BackgroundImageLayout = ImageLayout.Zoom;
            PreviousRecordButton.Cursor = Cursors.Hand;
            PreviousRecordButton.FlatAppearance.BorderSize = 0;
            PreviousRecordButton.FlatAppearance.CheckedBackColor = Color.FromArgb(224, 224, 224);
            PreviousRecordButton.FlatStyle = FlatStyle.Flat;
            PreviousRecordButton.Location = new Point(411, 250);
            PreviousRecordButton.Name = "PreviousRecordButton";
            PreviousRecordButton.Size = new Size(63, 53);
            PreviousRecordButton.TabIndex = 9;
            PreviousRecordButton.UseVisualStyleBackColor = true;
            PreviousRecordButton.Click += PreviousRecordButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(936, 431);
            Controls.Add(PreviousRecordButton);
            Controls.Add(NextRecordButton);
            Controls.Add(panel1);
            Controls.Add(SerialNrLabel);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SettingsButton;
        private Button DeleteButton;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label SerialNrLabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private TextBox CardIdTextbox;
        private Label label6;
        private TextBox SerialNrTextbox;
        private Label label5;
        private TextBox PINTextbox;
        private Label label4;
        private TextBox OwnerAccountNrTextbox;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Button AddButton;
        private Button SearchButton;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox KindOfSearchComboBox;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox SearchTextbox;
        private Button NextRecordButton;
        private Button PreviousRecordButton;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}
