namespace LibraryManagement
{
    partial class UCStatistical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 365);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(593, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mượn/trả theo thời gian";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(483, 300);
            button3.Name = "button3";
            button3.Size = new Size(92, 30);
            button3.TabIndex = 36;
            button3.Text = "Xuất PDF";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(377, 300);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 35;
            button4.Text = "Xuất Excel";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(581, 157);
            dataGridView1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 79);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 23;
            label3.Text = "lblText";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 79);
            label11.Name = "label11";
            label11.Size = new Size(76, 28);
            label11.TabIndex = 22;
            label11.Text = "lblText";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 59);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 6;
            label5.Text = "Tổng phiếu trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 59);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Tổng phiếu mượn";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(355, 20);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(179, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(284, 25);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Từ ngày:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(593, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sách mượn nhiều";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 49);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 10);
            label6.Name = "label6";
            label6.Size = new Size(140, 38);
            label6.TabIndex = 1;
            label6.Text = "Thống kê";
            // 
            // UCStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "UCStatistical";
            Size = new Size(607, 426);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label11;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label6;
    }
}
