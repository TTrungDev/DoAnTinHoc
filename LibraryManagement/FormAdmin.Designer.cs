namespace LibraryManagement
{
    partial class FormAdmin
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
            QuanLyTaiKhoang = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            dgvAccount = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            tabPage3 = new TabPage();
            button7 = new Button();
            label7 = new Label();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            QuanLyTaiKhoang.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // QuanLyTaiKhoang
            // 
            QuanLyTaiKhoang.Appearance = TabAppearance.Buttons;
            QuanLyTaiKhoang.Controls.Add(tabPage1);
            QuanLyTaiKhoang.Controls.Add(tabPage2);
            QuanLyTaiKhoang.Controls.Add(tabPage3);
            QuanLyTaiKhoang.Location = new Point(12, 15);
            QuanLyTaiKhoang.Margin = new Padding(3, 4, 3, 4);
            QuanLyTaiKhoang.Name = "QuanLyTaiKhoang";
            QuanLyTaiKhoang.SelectedIndex = 0;
            QuanLyTaiKhoang.Size = new Size(967, 630);
            QuanLyTaiKhoang.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Linen;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvAccount);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(959, 594);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 159);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "vai trò:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 102);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 14;
            label2.Text = "mật khẩu:";
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(659, 146);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(116, 42);
            button4.TabIndex = 13;
            button4.Text = "Khoa/Mo Khoa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(528, 146);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(99, 42);
            button3.TabIndex = 12;
            button3.Text = "Sua";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(402, 146);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 42);
            button2.TabIndex = 11;
            button2.Text = "Xoa";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 58);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "tên đăng nhập:";
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvAccount.Location = new Point(6, 214);
            dgvAccount.Margin = new Padding(3, 4, 3, 4);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 24;
            dgvAccount.Size = new Size(947, 372);
            dgvAccount.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên đăng nhập";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mật khẩu";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Vai trò";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(278, 146);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 42);
            button1.TabIndex = 3;
            button1.Text = "Them";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin" });
            comboBox1.Location = new Point(141, 154);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Admin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 102);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 58);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Linen;
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(959, 594);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cấu hình hệ thống";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(528, 210);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(297, 42);
            numericUpDown2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 210);
            label5.Name = "label5";
            label5.Size = new Size(440, 35);
            label5.TabIndex = 5;
            label5.Text = "Mức phí phạt quá hạn (VNĐ / ngày):";
            // 
            // button5
            // 
            button5.BackColor = Color.LightCoral;
            button5.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(528, 361);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(305, 104);
            button5.TabIndex = 4;
            button5.Text = "Luu Cau hinh He Thong";
            button5.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(528, 82);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 42);
            numericUpDown1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 85);
            label4.Name = "label4";
            label4.Size = new Size(419, 35);
            label4.TabIndex = 0;
            label4.Text = "Số ngày mượn sách tối đa (ngày):";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Linen;
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(959, 594);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Thống kê & Báo cáo";
            // 
            // button7
            // 
            button7.BackColor = Color.LightCoral;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(786, 488);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(164, 95);
            button7.TabIndex = 4;
            button7.Text = "Xuất báo cáo PDF";
            button7.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 71);
            label7.Name = "label7";
            label7.Size = new Size(861, 16);
            label7.TabIndex = 3;
            label7.Text = "Cấu hình hiện hành: Mượn tối đa {CAdminn.SoNgayMuonToiDa} ngày | Phí phạt quá hạn: {CAdminn.MucPhiPhatQuaHan:N0} VNĐ/ngày";
            // 
            // button6
            // 
            button6.BackColor = Color.LightCoral;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(591, 488);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(164, 95);
            button6.TabIndex = 2;
            button6.Text = "Xuất báo cáo Excel";
            button6.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            dataGridView2.Location = new Point(3, 156);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(947, 324);
            dataGridView2.TabIndex = 1;
            // 
            // Column5
            // 
            Column5.HeaderText = "Username";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Password";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Vai Tro";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Trang Thai";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 24);
            label6.Name = "label6";
            label6.Size = new Size(874, 24);
            label6.TabIndex = 0;
            label6.Text = "Tổng số tài khoản: {tongTK} (Đang hoạt động: {soTKHoatDong} | Đã khóa: {soTKKhoa})\\n\"";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 660);
            Controls.Add(QuanLyTaiKhoang);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdmin";
            Text = "QuanLyThuVien(Admin)";
            QuanLyTaiKhoang.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QuanLyTaiKhoang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}