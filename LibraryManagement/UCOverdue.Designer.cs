namespace LibraryManagement
{
    partial class UCOverdue
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
            button7 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 73);
            panel1.TabIndex = 4;
            // 
            // button7
            // 
            button7.Location = new Point(503, 31);
            button7.Name = "button7";
            button7.Size = new Size(81, 27);
            button7.TabIndex = 3;
            button7.Text = "Làm mới";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(416, 31);
            button6.Name = "button6";
            button6.Size = new Size(81, 27);
            button6.TabIndex = 2;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 0;
            label1.Text = "Phạt quá hạn";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 341);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(593, 146);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(451, 282);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 1;
            button1.Text = "Thu phạt";
            button1.UseVisualStyleBackColor = true;
            // 
            // UCOverdue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UCOverdue";
            Size = new Size(607, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
    }
}
