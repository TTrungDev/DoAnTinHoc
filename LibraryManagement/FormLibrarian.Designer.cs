namespace LibraryManagement
{
    partial class FormLibrarian
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
            panel2 = new Panel();
            ucStatistical1 = new UCStatistical();
            ucOverdue1 = new UCOverdue();
            ucReturnRecord1 = new UCReturnRecord();
            ucBorrowRecord1 = new UCBorrowRecord();
            ucReader1 = new UCReader();
            ucBook1 = new UCBook();
            ucCategory1 = new UCCategory();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogOut = new Button();
            rbtnStatistical = new RadioButton();
            rbtnOverdue = new RadioButton();
            rbtnReturnRecord = new RadioButton();
            rbtnBorrowRecord = new RadioButton();
            rbtnReader = new RadioButton();
            rbtnBook = new RadioButton();
            rbtnCategory = new RadioButton();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(ucStatistical1);
            panel2.Controls.Add(ucOverdue1);
            panel2.Controls.Add(ucReturnRecord1);
            panel2.Controls.Add(ucBorrowRecord1);
            panel2.Controls.Add(ucReader1);
            panel2.Controls.Add(ucBook1);
            panel2.Controls.Add(ucCategory1);
            panel2.Location = new Point(181, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 426);
            panel2.TabIndex = 6;
            // 
            // ucStatistical1
            // 
            ucStatistical1.Dock = DockStyle.Fill;
            ucStatistical1.Location = new Point(0, 0);
            ucStatistical1.Name = "ucStatistical1";
            ucStatistical1.Size = new Size(607, 426);
            ucStatistical1.TabIndex = 6;
            // 
            // ucOverdue1
            // 
            ucOverdue1.Dock = DockStyle.Fill;
            ucOverdue1.Location = new Point(0, 0);
            ucOverdue1.Name = "ucOverdue1";
            ucOverdue1.Size = new Size(607, 426);
            ucOverdue1.TabIndex = 5;
            // 
            // ucReturnRecord1
            // 
            ucReturnRecord1.Dock = DockStyle.Fill;
            ucReturnRecord1.Location = new Point(0, 0);
            ucReturnRecord1.Name = "ucReturnRecord1";
            ucReturnRecord1.Size = new Size(607, 426);
            ucReturnRecord1.TabIndex = 4;
            // 
            // ucBorrowRecord1
            // 
            ucBorrowRecord1.Dock = DockStyle.Fill;
            ucBorrowRecord1.Location = new Point(0, 0);
            ucBorrowRecord1.Name = "ucBorrowRecord1";
            ucBorrowRecord1.Size = new Size(607, 426);
            ucBorrowRecord1.TabIndex = 3;
            // 
            // ucReader1
            // 
            ucReader1.Dock = DockStyle.Fill;
            ucReader1.Location = new Point(0, 0);
            ucReader1.Name = "ucReader1";
            ucReader1.Size = new Size(607, 426);
            ucReader1.TabIndex = 2;
            // 
            // ucBook1
            // 
            ucBook1.Dock = DockStyle.Fill;
            ucBook1.Location = new Point(0, 0);
            ucBook1.Name = "ucBook1";
            ucBook1.Size = new Size(607, 426);
            ucBook1.TabIndex = 1;
            // 
            // ucCategory1
            // 
            ucCategory1.Dock = DockStyle.Fill;
            ucCategory1.Location = new Point(0, 0);
            ucCategory1.Name = "ucCategory1";
            ucCategory1.Size = new Size(607, 426);
            ucCategory1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 86);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Lib;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(rbtnStatistical);
            panel1.Controls.Add(rbtnOverdue);
            panel1.Controls.Add(rbtnReturnRecord);
            panel1.Controls.Add(rbtnBorrowRecord);
            panel1.Controls.Add(rbtnReader);
            panel1.Controls.Add(rbtnBook);
            panel1.Controls.Add(rbtnCategory);
            panel1.Location = new Point(12, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 334);
            panel1.TabIndex = 9;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(0, 266);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(163, 38);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // rbtnStatistical
            // 
            rbtnStatistical.Appearance = Appearance.Button;
            rbtnStatistical.AutoSize = true;
            rbtnStatistical.Dock = DockStyle.Top;
            rbtnStatistical.Font = new Font("Segoe UI", 12F);
            rbtnStatistical.Location = new Point(0, 228);
            rbtnStatistical.Name = "rbtnStatistical";
            rbtnStatistical.Size = new Size(163, 38);
            rbtnStatistical.TabIndex = 6;
            rbtnStatistical.TabStop = true;
            rbtnStatistical.Text = "Thống kê";
            rbtnStatistical.TextAlign = ContentAlignment.MiddleCenter;
            rbtnStatistical.UseVisualStyleBackColor = true;
            rbtnStatistical.CheckedChanged += rbtnStatistical_CheckedChanged;
            // 
            // rbtnOverdue
            // 
            rbtnOverdue.Appearance = Appearance.Button;
            rbtnOverdue.AutoSize = true;
            rbtnOverdue.Dock = DockStyle.Top;
            rbtnOverdue.Font = new Font("Segoe UI", 12F);
            rbtnOverdue.Location = new Point(0, 190);
            rbtnOverdue.Name = "rbtnOverdue";
            rbtnOverdue.Size = new Size(163, 38);
            rbtnOverdue.TabIndex = 5;
            rbtnOverdue.TabStop = true;
            rbtnOverdue.Text = "Quá hạn";
            rbtnOverdue.TextAlign = ContentAlignment.MiddleCenter;
            rbtnOverdue.UseVisualStyleBackColor = true;
            rbtnOverdue.CheckedChanged += rbtnOverdue_CheckedChanged;
            // 
            // rbtnReturnRecord
            // 
            rbtnReturnRecord.Appearance = Appearance.Button;
            rbtnReturnRecord.AutoSize = true;
            rbtnReturnRecord.Dock = DockStyle.Top;
            rbtnReturnRecord.Font = new Font("Segoe UI", 12F);
            rbtnReturnRecord.Location = new Point(0, 152);
            rbtnReturnRecord.Name = "rbtnReturnRecord";
            rbtnReturnRecord.Size = new Size(163, 38);
            rbtnReturnRecord.TabIndex = 4;
            rbtnReturnRecord.TabStop = true;
            rbtnReturnRecord.Text = "Trả sách";
            rbtnReturnRecord.TextAlign = ContentAlignment.MiddleCenter;
            rbtnReturnRecord.UseVisualStyleBackColor = true;
            rbtnReturnRecord.CheckedChanged += rbtnReturnRecord_CheckedChanged;
            // 
            // rbtnBorrowRecord
            // 
            rbtnBorrowRecord.Appearance = Appearance.Button;
            rbtnBorrowRecord.AutoSize = true;
            rbtnBorrowRecord.Dock = DockStyle.Top;
            rbtnBorrowRecord.Font = new Font("Segoe UI", 12F);
            rbtnBorrowRecord.Location = new Point(0, 114);
            rbtnBorrowRecord.Name = "rbtnBorrowRecord";
            rbtnBorrowRecord.Size = new Size(163, 38);
            rbtnBorrowRecord.TabIndex = 3;
            rbtnBorrowRecord.TabStop = true;
            rbtnBorrowRecord.Text = "Mượn sách";
            rbtnBorrowRecord.TextAlign = ContentAlignment.MiddleCenter;
            rbtnBorrowRecord.UseVisualStyleBackColor = true;
            rbtnBorrowRecord.CheckedChanged += rbtnBorrowRecord_CheckedChanged;
            // 
            // rbtnReader
            // 
            rbtnReader.Appearance = Appearance.Button;
            rbtnReader.AutoSize = true;
            rbtnReader.Dock = DockStyle.Top;
            rbtnReader.Font = new Font("Segoe UI", 12F);
            rbtnReader.Location = new Point(0, 76);
            rbtnReader.Name = "rbtnReader";
            rbtnReader.Size = new Size(163, 38);
            rbtnReader.TabIndex = 2;
            rbtnReader.TabStop = true;
            rbtnReader.Text = "Độc giả";
            rbtnReader.TextAlign = ContentAlignment.MiddleCenter;
            rbtnReader.UseVisualStyleBackColor = true;
            rbtnReader.CheckedChanged += rbtnReader_CheckedChanged;
            // 
            // rbtnBook
            // 
            rbtnBook.Appearance = Appearance.Button;
            rbtnBook.AutoSize = true;
            rbtnBook.Dock = DockStyle.Top;
            rbtnBook.Font = new Font("Segoe UI", 12F);
            rbtnBook.Location = new Point(0, 38);
            rbtnBook.Name = "rbtnBook";
            rbtnBook.Size = new Size(163, 38);
            rbtnBook.TabIndex = 1;
            rbtnBook.TabStop = true;
            rbtnBook.Text = "Sách";
            rbtnBook.TextAlign = ContentAlignment.MiddleCenter;
            rbtnBook.UseVisualStyleBackColor = true;
            rbtnBook.CheckedChanged += rbtnBook_CheckedChanged;
            // 
            // rbtnCategory
            // 
            rbtnCategory.Appearance = Appearance.Button;
            rbtnCategory.AutoSize = true;
            rbtnCategory.Checked = true;
            rbtnCategory.Dock = DockStyle.Top;
            rbtnCategory.Font = new Font("Segoe UI", 12F);
            rbtnCategory.Location = new Point(0, 0);
            rbtnCategory.Name = "rbtnCategory";
            rbtnCategory.Size = new Size(163, 38);
            rbtnCategory.TabIndex = 0;
            rbtnCategory.TabStop = true;
            rbtnCategory.Text = "Thể loại";
            rbtnCategory.TextAlign = ContentAlignment.MiddleCenter;
            rbtnCategory.UseVisualStyleBackColor = true;
            rbtnCategory.CheckedChanged += rbtnCategory_CheckedChanged;
            // 
            // FormLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormLibrarian";
            Text = "Trình quản lý thư viện";
            Load += FormLibrarian_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private UCCategory uC_Categorys1;
        private UCBook uC_Book1;
        private UCReader uC_Reader1;
        private UCBorrowRecord uC_BorrowRecord1;
        private UCReturnRecord uC_ReturnRecord1;
        private UCOverdue uC_Overdue1;
        private UCStatistical uC_Statistical1;
        private Panel panel1;
        private RadioButton rbtnStatistical;
        private RadioButton rbtnOverdue;
        private RadioButton rbtnReturnRecord;
        private RadioButton rbtnBorrowRecord;
        private RadioButton rbtnReader;
        private RadioButton rbtnBook;
        private RadioButton rbtnCategory;
        private Button btnLogOut;
        private UCBook ucBook1;
        private UCCategory ucCategory1;
        private UCStatistical ucStatistical1;
        private UCOverdue ucOverdue1;
        private UCReturnRecord ucReturnRecord1;
        private UCBorrowRecord ucBorrowRecord1;
        private UCReader ucReader1;
        private PictureBox pictureBox1;
    }
}