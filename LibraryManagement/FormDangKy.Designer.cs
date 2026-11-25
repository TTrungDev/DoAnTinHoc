using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement
{
    partial class FormDangKy
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
            btnCancel = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            txtRegPassword = new TextBox();
            textBox2 = new TextBox();
            txtRegUsername = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.LightCoral;
            btnCancel.Location = new Point(241, 400);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 40);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 295);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 29;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 227);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 28;
            label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 159);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 27;
            label3.Text = "Email:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(77, 366);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(276, 24);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "tôi đồng ý với tất cả các điều khoảng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 434);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 95);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 24;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightCoral;
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(77, 398);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 42);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(77, 319);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(325, 27);
            txtConfirmPassword.TabIndex = 22;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(77, 251);
            txtRegPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(325, 27);
            txtRegPassword.TabIndex = 21;
            txtRegPassword.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 183);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(77, 119);
            txtRegUsername.Margin = new Padding(3, 4, 3, 4);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(325, 27);
            txtRegUsername.TabIndex = 19;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(114, 35);
            label1.Name = "label1";
            label1.Size = new Size(246, 44);
            label1.TabIndex = 18;
            label1.Text = "Tạo Tài Khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(456, 562);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtRegPassword);
            Controls.Add(textBox2);
            Controls.Add(txtRegUsername);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangKy";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label label1;



    }
}