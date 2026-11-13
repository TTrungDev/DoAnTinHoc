namespace LibraryManagement
{
    partial class UCReturnRecord
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
            panel1 = new Panel();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 73);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(122, 38);
            label1.TabIndex = 0;
            label1.Text = "Trả sách";
            // 
            // button7
            // 
            button7.Location = new Point(512, 48);
            button7.Name = "button7";
            button7.Size = new Size(81, 27);
            button7.TabIndex = 3;
            button7.Text = "Làm mới";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(425, 48);
            button6.Name = "button6";
            button6.Size = new Size(81, 27);
            button6.TabIndex = 2;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 235);
            panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(583, 134);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 20);
            label3.Name = "label3";
            label3.Size = new Size(237, 23);
            label3.TabIndex = 4;
            label3.Text = "1. Tìm độc giả và phiếu mượn";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 100);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(439, 47);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 32;
            button1.Text = "Xác nhận trả";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 56);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 31;
            label4.Text = "Tổng phạt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 56);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 29;
            label9.Text = "Ngày trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "2. Xác nhận";
            // 
            // UCReturnRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCReturnRecord";
            Size = new Size(607, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private TextBox textBox3;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label label9;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
