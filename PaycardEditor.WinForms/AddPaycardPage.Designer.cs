namespace PaycardEditor.WinForms
{
    partial class AddPaycardPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            SerialNrLabel = new Label();
            SerialNrTextBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            PINLabel = new Label();
            PINTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            OwnerAccountNrLabel = new Label();
            OwnerAccountNrTextBox = new TextBox();
            SubmitButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(SubmitButton, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(424, 390);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6768456F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3231544F));
            tableLayoutPanel4.Controls.Add(SerialNrLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(SerialNrTextBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(6, 226);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(412, 75);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // SerialNrLabel
            // 
            SerialNrLabel.Anchor = AnchorStyles.Right;
            SerialNrLabel.Location = new Point(14, 26);
            SerialNrLabel.Name = "SerialNrLabel";
            SerialNrLabel.Size = new Size(142, 23);
            SerialNrLabel.TabIndex = 0;
            SerialNrLabel.Text = "Numer seryjny karty:";
            SerialNrLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SerialNrTextBox
            // 
            SerialNrTextBox.Anchor = AnchorStyles.Left;
            SerialNrTextBox.Font = new Font("Segoe UI", 14F);
            SerialNrTextBox.Location = new Point(162, 21);
            SerialNrTextBox.Name = "SerialNrTextBox";
            SerialNrTextBox.Size = new Size(206, 32);
            SerialNrTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6768456F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3231544F));
            tableLayoutPanel3.Controls.Add(PINLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(PINTextBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 142);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(412, 75);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // PINLabel
            // 
            PINLabel.Anchor = AnchorStyles.Right;
            PINLabel.Location = new Point(14, 26);
            PINLabel.Name = "PINLabel";
            PINLabel.Size = new Size(142, 23);
            PINLabel.TabIndex = 0;
            PINLabel.Text = "Numer PIN:";
            PINLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PINTextBox
            // 
            PINTextBox.Anchor = AnchorStyles.Left;
            PINTextBox.Font = new Font("Segoe UI", 14F);
            PINTextBox.Location = new Point(162, 21);
            PINTextBox.MaxLength = 4;
            PINTextBox.Name = "PINTextBox";
            PINTextBox.PasswordChar = '*';
            PINTextBox.Size = new Size(206, 32);
            PINTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5167465F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4832535F));
            tableLayoutPanel2.Controls.Add(OwnerAccountNrLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(OwnerAccountNrTextBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 58);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(412, 75);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // OwnerAccountNrLabel
            // 
            OwnerAccountNrLabel.Anchor = AnchorStyles.Right;
            OwnerAccountNrLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            OwnerAccountNrLabel.Location = new Point(13, 26);
            OwnerAccountNrLabel.Name = "OwnerAccountNrLabel";
            OwnerAccountNrLabel.Size = new Size(142, 23);
            OwnerAccountNrLabel.TabIndex = 0;
            OwnerAccountNrLabel.Text = "Numer konta właściciela:";
            OwnerAccountNrLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OwnerAccountNrTextBox
            // 
            OwnerAccountNrTextBox.Anchor = AnchorStyles.Left;
            OwnerAccountNrTextBox.Font = new Font("Segoe UI", 14F);
            OwnerAccountNrTextBox.Location = new Point(161, 21);
            OwnerAccountNrTextBox.Name = "OwnerAccountNrTextBox";
            OwnerAccountNrTextBox.Size = new Size(206, 32);
            OwnerAccountNrTextBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Lime;
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.Dock = DockStyle.Fill;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 16F);
            SubmitButton.Location = new Point(6, 310);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(412, 75);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Zatwierdź i dodaj kartę płatniczą";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
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
            tableLayoutPanel5.Size = new Size(412, 43);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 43);
            label1.TabIndex = 0;
            label1.Text = "Dodawanie karty płatniczej";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.plus;
            pictureBox1.Location = new Point(313, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AddPaycardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 390);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPaycardPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPaycardPage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label OwnerAccountNrLabel;
        private TextBox OwnerAccountNrTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label SerialNrLabel;
        private TextBox SerialNrTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label PINLabel;
        private TextBox PINTextBox;
        private Button SubmitButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}