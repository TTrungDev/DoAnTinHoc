namespace LibraryManagement
{
    partial class FormDangNhap
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
            label1 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            chkRemember = new CheckBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblSlogan = new Label();
            lblBrand = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(407, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 36);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            label1.Click += label1_Click;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = SystemColors.Desktop;
            txtusername.Location = new Point(417, 105);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Nhập tên đăng nhập";
            txtusername.Size = new Size(273, 22);
            txtusername.TabIndex = 1;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.ForeColor = SystemColors.Desktop;
            txtpassword.ImeMode = ImeMode.NoControl;
            txtpassword.Location = new Point(417, 180);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = ".......";
            txtpassword.Size = new Size(273, 27);
            txtpassword.TabIndex = 2;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(417, 227);
            chkRemember.Margin = new Padding(3, 4, 3, 4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(146, 24);
            chkRemember.TabIndex = 3;
            chkRemember.Text = "ghi nhớ mật khẩu";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.LightCoral;
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(417, 265);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(273, 35);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LightCoral;
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(417, 320);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(273, 38);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 105);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(417, 75);
            label3.Name = "label3";
            label3.Size = new Size(101, 16);
            label3.TabIndex = 9;
            label3.Text = "Tên Đăng Nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(417, 151);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 10;
            label4.Text = "Mật Khẩu:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 96, 90);
            panel1.Controls.Add(lblSlogan);
            panel1.Controls.Add(lblBrand);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 433);
            panel1.TabIndex = 11;
            // 
            // lblSlogan
            // 
            lblSlogan.Font = new Font("Segoe UI", 11F);
            lblSlogan.ForeColor = Color.FromArgb(255, 227, 224);
            lblSlogan.Location = new Point(22, 265);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(320, 28);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Chào mừng bạn trở lại";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(55, 125);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(287, 116);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 241);
            ClientSize = new Size(802, 433);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(chkRemember);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Đăng Nhập";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Panel panel1;
        private Label lblBrand;
        private Label lblSlogan;
    }
}

