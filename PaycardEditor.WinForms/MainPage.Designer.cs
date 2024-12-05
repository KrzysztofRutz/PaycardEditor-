
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
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
            CardIdTextbox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            SerialNrTextbox = new TextBox();
            label5 = new Label();
            PINTextbox = new TextBox();
            label4 = new Label();
            OwnerAccountNrTextbox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            NextRecordButton = new Button();
            PreviousRecordButton = new Button();
            panel2 = new Panel();
            PaycardsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerAccountNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pINDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serialNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cardIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            DisplayAllComponentButton = new Button();
            paycardDtoBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaycardsDataGridView).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paycardDtoBindingSource).BeginInit();
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
            SettingsButton.Size = new Size(72, 72);
            SettingsButton.TabIndex = 1;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.BackgroundImage = Properties.Resources.delete;
            DeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(159, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(72, 72);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_ClickAsync;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(87, 179, 254);
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 290F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AddButton, 1, 0);
            tableLayoutPanel1.Controls.Add(SettingsButton, 0, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 5, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(1045, 78);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(0, 192, 0);
            AddButton.BackgroundImage = Properties.Resources.more;
            AddButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(81, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(72, 72);
            AddButton.TabIndex = 8;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = Color.FromArgb(42, 130, 218);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Controls.Add(KindOfSearchComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(SearchTextbox, 1, 1);
            tableLayoutPanel2.Location = new Point(237, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(353, 70);
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
            KindOfSearchComboBox.Size = new Size(109, 25);
            KindOfSearchComboBox.TabIndex = 3;
            KindOfSearchComboBox.SelectedValueChanged += KindOfSearchComboBox_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Calibri", 14F);
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
            SearchTextbox.Location = new Point(118, 38);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(232, 25);
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
            SearchButton.Location = new Point(596, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(72, 72);
            SearchButton.TabIndex = 7;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_ClickAsync;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(779, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 78);
            label3.TabIndex = 9;
            label3.Text = "Paycard 3dit0r";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = Properties.Resources.debit_card;
            pictureBox3.Location = new Point(970, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Paycard;
            pictureBox1.Location = new Point(473, 145);
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
            SerialNrLabel.Location = new Point(594, 320);
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
            panel1.Size = new Size(467, 353);
            panel1.TabIndex = 7;
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(87, 179, 254);
            label11.Location = new Point(1, 272);
            label11.Name = "label11";
            label11.Size = new Size(468, 23);
            label11.TabIndex = 6;
            label11.Text = "------------------------------------------------------------------------------------------------";
            // 
            // label10
            // 
            label10.ForeColor = Color.FromArgb(87, 179, 254);
            label10.Location = new Point(0, 200);
            label10.Name = "label10";
            label10.Size = new Size(469, 23);
            label10.TabIndex = 5;
            label10.Text = "------------------------------------------------------------------------------------------------";
            // 
            // label9
            // 
            label9.ForeColor = Color.FromArgb(87, 179, 254);
            label9.Location = new Point(0, 125);
            label9.Name = "label9";
            label9.Size = new Size(469, 23);
            label9.TabIndex = 4;
            label9.Text = "------------------------------------------------------------------------------------------------";
            // 
            // label8
            // 
            label8.ForeColor = Color.FromArgb(87, 179, 254);
            label8.Location = new Point(0, 49);
            label8.Name = "label8";
            label8.Size = new Size(469, 23);
            label8.TabIndex = 3;
            label8.Text = "------------------------------------------------------------------------------------------------";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.09938F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.90062F));
            tableLayoutPanel3.Controls.Add(CardIdTextbox, 1, 3);
            tableLayoutPanel3.Controls.Add(label7, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 2);
            tableLayoutPanel3.Controls.Add(SerialNrTextbox, 1, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Controls.Add(PINTextbox, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(OwnerAccountNrTextbox, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 59);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(467, 294);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // CardIdTextbox
            // 
            CardIdTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CardIdTextbox.BackColor = Color.Gainsboro;
            CardIdTextbox.Font = new Font("Yu Gothic UI", 9F);
            CardIdTextbox.Location = new Point(208, 245);
            CardIdTextbox.Name = "CardIdTextbox";
            CardIdTextbox.ReadOnly = true;
            CardIdTextbox.Size = new Size(256, 23);
            CardIdTextbox.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(69, 245);
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
            label6.Location = new Point(69, 171);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 4;
            label6.Text = "Nr seryjny karty:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SerialNrTextbox
            // 
            SerialNrTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SerialNrTextbox.BackColor = Color.Gainsboro;
            SerialNrTextbox.Font = new Font("Yu Gothic UI", 9F);
            SerialNrTextbox.Location = new Point(208, 171);
            SerialNrTextbox.Name = "SerialNrTextbox";
            SerialNrTextbox.ReadOnly = true;
            SerialNrTextbox.Size = new Size(256, 23);
            SerialNrTextbox.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(69, 98);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 2;
            label5.Text = "PIN:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PINTextbox
            // 
            PINTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PINTextbox.BackColor = Color.Gainsboro;
            PINTextbox.Font = new Font("Yu Gothic UI", 9F);
            PINTextbox.Location = new Point(208, 98);
            PINTextbox.Name = "PINTextbox";
            PINTextbox.ReadOnly = true;
            PINTextbox.Size = new Size(256, 23);
            PINTextbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(69, 25);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 0;
            label4.Text = "Nr konta właściciela:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OwnerAccountNrTextbox
            // 
            OwnerAccountNrTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            OwnerAccountNrTextbox.BackColor = Color.Gainsboro;
            OwnerAccountNrTextbox.Font = new Font("Yu Gothic UI", 9F);
            OwnerAccountNrTextbox.Location = new Point(208, 25);
            OwnerAccountNrTextbox.Name = "OwnerAccountNrTextbox";
            OwnerAccountNrTextbox.ReadOnly = true;
            OwnerAccountNrTextbox.Size = new Size(256, 23);
            OwnerAccountNrTextbox.TabIndex = 1;
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
            tableLayoutPanel4.Size = new Size(467, 49);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.atm_card;
            pictureBox2.Location = new Point(326, 3);
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
            label2.Size = new Size(317, 56);
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
            NextRecordButton.Location = new Point(963, 299);
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
            PreviousRecordButton.Location = new Point(500, 299);
            PreviousRecordButton.Name = "PreviousRecordButton";
            PreviousRecordButton.Size = new Size(63, 53);
            PreviousRecordButton.TabIndex = 9;
            PreviousRecordButton.UseVisualStyleBackColor = true;
            PreviousRecordButton.Click += PreviousRecordButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(PaycardsDataGridView);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Location = new Point(473, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 119);
            panel2.TabIndex = 10;
            // 
            // PaycardsDataGridView
            // 
            PaycardsDataGridView.AllowUserToAddRows = false;
            PaycardsDataGridView.AllowUserToDeleteRows = false;
            PaycardsDataGridView.AllowUserToResizeColumns = false;
            PaycardsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 224, 224);
            PaycardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PaycardsDataGridView.BackgroundColor = Color.FromArgb(58, 119, 169);
            PaycardsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            PaycardsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PaycardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PaycardsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PaycardsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ownerAccountNrDataGridViewTextBoxColumn, pINDataGridViewTextBoxColumn, serialNrDataGridViewTextBoxColumn, cardIdDataGridViewTextBoxColumn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            PaycardsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            PaycardsDataGridView.Dock = DockStyle.Top;
            PaycardsDataGridView.EnableHeadersVisualStyles = false;
            PaycardsDataGridView.GridColor = Color.FromArgb(58, 119, 169);
            PaycardsDataGridView.Location = new Point(0, 33);
            PaycardsDataGridView.MultiSelect = false;
            PaycardsDataGridView.Name = "PaycardsDataGridView";
            PaycardsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PaycardsDataGridView.RowHeadersVisible = false;
            PaycardsDataGridView.RowHeadersWidth = 40;
            PaycardsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PaycardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(58, 119, 169);
            PaycardsDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PaycardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ControlLight;
            PaycardsDataGridView.RowTemplate.ReadOnly = true;
            PaycardsDataGridView.ScrollBars = ScrollBars.Vertical;
            PaycardsDataGridView.Size = new Size(564, 85);
            PaycardsDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLight;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // ownerAccountNrDataGridViewTextBoxColumn
            // 
            ownerAccountNrDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ownerAccountNrDataGridViewTextBoxColumn.DataPropertyName = "OwnerAccountNr";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(58, 119, 169);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlLight;
            ownerAccountNrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            ownerAccountNrDataGridViewTextBoxColumn.HeaderText = "Nr konta właściciela";
            ownerAccountNrDataGridViewTextBoxColumn.Name = "ownerAccountNrDataGridViewTextBoxColumn";
            ownerAccountNrDataGridViewTextBoxColumn.ReadOnly = true;
            ownerAccountNrDataGridViewTextBoxColumn.Width = 136;
            // 
            // pINDataGridViewTextBoxColumn
            // 
            pINDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            pINDataGridViewTextBoxColumn.DataPropertyName = "PIN";
            pINDataGridViewTextBoxColumn.HeaderText = "PIN";
            pINDataGridViewTextBoxColumn.Name = "pINDataGridViewTextBoxColumn";
            pINDataGridViewTextBoxColumn.ReadOnly = true;
            pINDataGridViewTextBoxColumn.Width = 49;
            // 
            // serialNrDataGridViewTextBoxColumn
            // 
            serialNrDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            serialNrDataGridViewTextBoxColumn.DataPropertyName = "SerialNr";
            serialNrDataGridViewTextBoxColumn.HeaderText = "Nr seryjny";
            serialNrDataGridViewTextBoxColumn.Name = "serialNrDataGridViewTextBoxColumn";
            serialNrDataGridViewTextBoxColumn.ReadOnly = true;
            serialNrDataGridViewTextBoxColumn.Width = 83;
            // 
            // cardIdDataGridViewTextBoxColumn
            // 
            cardIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cardIdDataGridViewTextBoxColumn.DataPropertyName = "CardId";
            cardIdDataGridViewTextBoxColumn.HeaderText = "Identyfikator karty";
            cardIdDataGridViewTextBoxColumn.Name = "cardIdDataGridViewTextBoxColumn";
            cardIdDataGridViewTextBoxColumn.ReadOnly = true;
            cardIdDataGridViewTextBoxColumn.Width = 126;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(DisplayAllComponentButton, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(564, 33);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // DisplayAllComponentButton
            // 
            DisplayAllComponentButton.BackColor = Color.WhiteSmoke;
            DisplayAllComponentButton.Cursor = Cursors.Hand;
            DisplayAllComponentButton.Dock = DockStyle.Fill;
            DisplayAllComponentButton.FlatStyle = FlatStyle.Flat;
            DisplayAllComponentButton.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DisplayAllComponentButton.Location = new Point(3, 3);
            DisplayAllComponentButton.Name = "DisplayAllComponentButton";
            DisplayAllComponentButton.Size = new Size(276, 27);
            DisplayAllComponentButton.TabIndex = 0;
            DisplayAllComponentButton.Text = "Wyświetl wszystko";
            DisplayAllComponentButton.UseVisualStyleBackColor = false;
            DisplayAllComponentButton.Click += DisplayAllComponentButton_ClickAsync;
            // 
            // paycardDtoBindingSource
            // 
            paycardDtoBindingSource.DataSource = typeof(Applications.Dtos.PaycardDto);
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1045, 431);
            Controls.Add(panel2);
            Controls.Add(PreviousRecordButton);
            Controls.Add(NextRecordButton);
            Controls.Add(panel1);
            Controls.Add(SerialNrLabel);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekran główny";
            Load += MainPage_LoadAsync;
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PaycardsDataGridView).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paycardDtoBindingSource).EndInit();
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
        private Panel panel2;
        private DataGridView PaycardsDataGridView;
        private TableLayoutPanel tableLayoutPanel5;
        private Button DisplayAllComponentButton;
        private TextBox CardIdTextbox;
        private BindingSource paycardDtoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerAccountNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serialNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardIdDataGridViewTextBoxColumn;
    }
}
