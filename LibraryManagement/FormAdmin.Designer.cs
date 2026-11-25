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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            pnlSidebar = new Panel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            pnlLine = new Panel();
            rdoNavHome = new RadioButton();
            btnLogout = new Button();
            rdoNavReaders = new RadioButton();
            rdoNavBooks = new RadioButton();
            rdoNavBorrow = new RadioButton();
            rdoNavReports = new RadioButton();
            rdoNavSettings = new RadioButton();
            pnlMain = new Panel();
            pnlHome = new Panel();
            pnlNotification = new Panel();
            lblNotice4 = new Label();
            lblNotice3 = new Label();
            lblNotice2 = new Label();
            lblNotice1 = new Label();
            lblNotification = new Label();
            picBell = new PictureBox();
            pnlChart = new Panel();
            pnlChartArea = new Panel();
            rdoYear = new RadioButton();
            rdo30Days = new RadioButton();
            rdo7Days = new RadioButton();
            picChart = new PictureBox();
            lblChartTitle = new Label();
            pnlLowStock = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pnlTotalBorrow = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pnlTotalReaders = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlTotalBooks = new Panel();
            lblBooksTitle = new Label();
            lblTotalBooks = new Label();
            picTotalBooks = new PictureBox();
            pnlDateTime = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            lblWelcome = new Label();
            lblAdminTitle = new Label();
            picAdmin = new PictureBox();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMain.SuspendLayout();
            pnlHome.SuspendLayout();
            pnlNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBell).BeginInit();
            pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).BeginInit();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTotalBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTotalReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTotalBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalBooks).BeginInit();
            pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(73, 52, 45);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Controls.Add(pnlLine);
            pnlSidebar.Controls.Add(rdoNavHome);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(190, 653);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 85);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(190, 35);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Thư Viện";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(58, 17);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(70, 65);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.FromArgb(130, 105, 95);
            pnlLine.Location = new Point(15, 490);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(160, 2);
            pnlLine.TabIndex = 7;
            // 
            // rdoNavHome
            // 
            rdoNavHome.Appearance = Appearance.Button;
            rdoNavHome.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavHome.Checked = true;
            rdoNavHome.FlatAppearance.BorderSize = 0;
            rdoNavHome.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavHome.FlatStyle = FlatStyle.Flat;
            rdoNavHome.ForeColor = Color.White;
            rdoNavHome.Location = new Point(7, 145);
            rdoNavHome.Name = "rdoNavHome";
            rdoNavHome.Size = new Size(180, 50);
            rdoNavHome.TabIndex = 1;
            rdoNavHome.TabStop = true;
            rdoNavHome.Text = "Trang Chủ";
            rdoNavHome.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavHome.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(90, 65, 58);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(5, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 50);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // rdoNavReaders
            // 
            rdoNavReaders.Appearance = Appearance.Button;
            rdoNavReaders.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavReaders.FlatAppearance.BorderSize = 0;
            rdoNavReaders.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavReaders.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavReaders.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavReaders.FlatStyle = FlatStyle.Flat;
            rdoNavReaders.ForeColor = Color.White;
            rdoNavReaders.Location = new Point(5, 195);
            rdoNavReaders.Name = "rdoNavReaders";
            rdoNavReaders.Size = new Size(180, 50);
            rdoNavReaders.TabIndex = 9;
            rdoNavReaders.Text = "Quản Lý Độc Giả";
            rdoNavReaders.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavReaders.UseVisualStyleBackColor = false;
            // 
            // rdoNavBooks
            // 
            rdoNavBooks.Appearance = Appearance.Button;
            rdoNavBooks.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavBooks.FlatAppearance.BorderSize = 0;
            rdoNavBooks.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavBooks.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavBooks.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavBooks.FlatStyle = FlatStyle.Flat;
            rdoNavBooks.ForeColor = Color.White;
            rdoNavBooks.Location = new Point(5, 250);
            rdoNavBooks.Name = "rdoNavBooks";
            rdoNavBooks.Size = new Size(180, 50);
            rdoNavBooks.TabIndex = 10;
            rdoNavBooks.Text = "Quản Lý Sách";
            rdoNavBooks.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavBooks.UseVisualStyleBackColor = false;
            // 
            // rdoNavBorrow
            // 
            rdoNavBorrow.Appearance = Appearance.Button;
            rdoNavBorrow.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavBorrow.FlatAppearance.BorderSize = 0;
            rdoNavBorrow.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavBorrow.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavBorrow.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavBorrow.FlatStyle = FlatStyle.Flat;
            rdoNavBorrow.ForeColor = Color.White;
            rdoNavBorrow.Location = new Point(5, 305);
            rdoNavBorrow.Name = "rdoNavBorrow";
            rdoNavBorrow.Size = new Size(180, 50);
            rdoNavBorrow.TabIndex = 11;
            rdoNavBorrow.Text = "Quản Lý Mượn Trả";
            rdoNavBorrow.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavBorrow.UseVisualStyleBackColor = false;
            rdoNavBorrow.CheckedChanged += rdoNavBorrow_CheckedChanged;
            // 
            // rdoNavReports
            // 
            rdoNavReports.Appearance = Appearance.Button;
            rdoNavReports.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavReports.FlatAppearance.BorderSize = 0;
            rdoNavReports.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavReports.FlatStyle = FlatStyle.Flat;
            rdoNavReports.ForeColor = Color.White;
            rdoNavReports.Location = new Point(5, 360);
            rdoNavReports.Name = "rdoNavReports";
            rdoNavReports.Size = new Size(180, 50);
            rdoNavReports.TabIndex = 12;
            rdoNavReports.Text = "Thống Kê";
            rdoNavReports.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavReports.UseVisualStyleBackColor = false;
            // 
            // rdoNavSettings
            // 
            rdoNavSettings.Appearance = Appearance.Button;
            rdoNavSettings.BackColor = Color.FromArgb(73, 52, 45);
            rdoNavSettings.FlatAppearance.BorderSize = 0;
            rdoNavSettings.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoNavSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 78, 65);
            rdoNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 72, 63);
            rdoNavSettings.FlatStyle = FlatStyle.Flat;
            rdoNavSettings.ForeColor = Color.White;
            rdoNavSettings.Location = new Point(5, 415);
            rdoNavSettings.Name = "rdoNavSettings";
            rdoNavSettings.Size = new Size(180, 50);
            rdoNavSettings.TabIndex = 13;
            rdoNavSettings.Text = "Cài Đặt";
            rdoNavSettings.TextAlign = ContentAlignment.MiddleCenter;
            rdoNavSettings.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlHome);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(190, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(972, 653);
            pnlMain.TabIndex = 14;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(pnlNotification);
            pnlHome.Controls.Add(pnlChart);
            pnlHome.Controls.Add(pnlLowStock);
            pnlHome.Controls.Add(pnlTotalBorrow);
            pnlHome.Controls.Add(pnlTotalReaders);
            pnlHome.Controls.Add(pnlTotalBooks);
            pnlHome.Controls.Add(pnlDateTime);
            pnlHome.Controls.Add(lblWelcome);
            pnlHome.Controls.Add(lblAdminTitle);
            pnlHome.Controls.Add(picAdmin);
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.Location = new Point(0, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(972, 653);
            pnlHome.TabIndex = 0;
            // 
            // pnlNotification
            // 
            pnlNotification.BackColor = Color.FromArgb(255, 252, 250);
            pnlNotification.Controls.Add(lblNotice4);
            pnlNotification.Controls.Add(lblNotice3);
            pnlNotification.Controls.Add(lblNotice2);
            pnlNotification.Controls.Add(lblNotice1);
            pnlNotification.Controls.Add(lblNotification);
            pnlNotification.Controls.Add(picBell);
            pnlNotification.Location = new Point(635, 260);
            pnlNotification.Name = "pnlNotification";
            pnlNotification.Size = new Size(310, 320);
            pnlNotification.TabIndex = 8;
            // 
            // lblNotice4
            // 
            lblNotice4.Font = new Font("Segoe UI", 9F);
            lblNotice4.Location = new Point(25, 230);
            lblNotice4.Name = "lblNotice4";
            lblNotice4.Size = new Size(190, 45);
            lblNotice4.TabIndex = 5;
            lblNotice4.Text = "label10";
            // 
            // lblNotice3
            // 
            lblNotice3.Font = new Font("Segoe UI", 9F);
            lblNotice3.Location = new Point(25, 175);
            lblNotice3.Name = "lblNotice3";
            lblNotice3.Size = new Size(190, 45);
            lblNotice3.TabIndex = 4;
            lblNotice3.Text = "label9";
            // 
            // lblNotice2
            // 
            lblNotice2.Font = new Font("Segoe UI", 9F);
            lblNotice2.Location = new Point(25, 120);
            lblNotice2.Name = "lblNotice2";
            lblNotice2.Size = new Size(190, 45);
            lblNotice2.TabIndex = 3;
            lblNotice2.Text = "label8";
            // 
            // lblNotice1
            // 
            lblNotice1.Font = new Font("Segoe UI", 9F);
            lblNotice1.Location = new Point(25, 65);
            lblNotice1.Name = "lblNotice1";
            lblNotice1.Size = new Size(190, 45);
            lblNotice1.TabIndex = 2;
            lblNotice1.Text = "label7";
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotification.Location = new Point(50, 15);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(130, 31);
            lblNotification.TabIndex = 1;
            lblNotification.Text = "Thông Báo";
            // 
            // picBell
            // 
            picBell.Image = (Image)resources.GetObject("picBell.Image");
            picBell.Location = new Point(15, 15);
            picBell.Name = "picBell";
            picBell.Size = new Size(25, 25);
            picBell.SizeMode = PictureBoxSizeMode.Zoom;
            picBell.TabIndex = 0;
            picBell.TabStop = false;
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.FromArgb(255, 252, 250);
            pnlChart.Controls.Add(pnlChartArea);
            pnlChart.Controls.Add(rdoYear);
            pnlChart.Controls.Add(rdo30Days);
            pnlChart.Controls.Add(rdo7Days);
            pnlChart.Controls.Add(picChart);
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Location = new Point(20, 260);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(600, 320);
            pnlChart.TabIndex = 7;
            // 
            // pnlChartArea
            // 
            pnlChartArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChartArea.Location = new Point(15, 60);
            pnlChartArea.Name = "pnlChartArea";
            pnlChartArea.Size = new Size(570, 245);
            pnlChartArea.TabIndex = 5;
            pnlChartArea.Paint += pnlChartArea_Paint;
            // 
            // rdoYear
            // 
            rdoYear.Appearance = Appearance.Button;
            rdoYear.AutoSize = true;
            rdoYear.FlatAppearance.BorderColor = Color.SeaShell;
            rdoYear.FlatAppearance.BorderSize = 0;
            rdoYear.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdoYear.FlatStyle = FlatStyle.Flat;
            rdoYear.Font = new Font("Segoe UI", 9F);
            rdoYear.Location = new Point(524, 16);
            rdoYear.Name = "rdoYear";
            rdoYear.Size = new Size(51, 30);
            rdoYear.TabIndex = 4;
            rdoYear.Text = "Năm";
            rdoYear.TextAlign = ContentAlignment.MiddleCenter;
            rdoYear.UseVisualStyleBackColor = true;
            // 
            // rdo30Days
            // 
            rdo30Days.Appearance = Appearance.Button;
            rdo30Days.AutoSize = true;
            rdo30Days.FlatAppearance.BorderColor = Color.SeaShell;
            rdo30Days.FlatAppearance.BorderSize = 0;
            rdo30Days.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdo30Days.FlatStyle = FlatStyle.Flat;
            rdo30Days.Font = new Font("Segoe UI", 9F);
            rdo30Days.Location = new Point(444, 16);
            rdo30Days.Name = "rdo30Days";
            rdo30Days.Size = new Size(74, 30);
            rdo30Days.TabIndex = 3;
            rdo30Days.Text = "30 Ngày";
            rdo30Days.TextAlign = ContentAlignment.MiddleCenter;
            rdo30Days.UseVisualStyleBackColor = true;
            // 
            // rdo7Days
            // 
            rdo7Days.Appearance = Appearance.Button;
            rdo7Days.AutoSize = true;
            rdo7Days.Checked = true;
            rdo7Days.FlatAppearance.BorderColor = Color.SeaShell;
            rdo7Days.FlatAppearance.BorderSize = 0;
            rdo7Days.FlatAppearance.CheckedBackColor = Color.FromArgb(235, 96, 80);
            rdo7Days.FlatStyle = FlatStyle.Flat;
            rdo7Days.Font = new Font("Segoe UI", 9F);
            rdo7Days.Location = new Point(369, 16);
            rdo7Days.Name = "rdo7Days";
            rdo7Days.Size = new Size(66, 30);
            rdo7Days.TabIndex = 2;
            rdo7Days.TabStop = true;
            rdo7Days.Text = "7 Ngày";
            rdo7Days.TextAlign = ContentAlignment.MiddleCenter;
            rdo7Days.UseVisualStyleBackColor = true;
            // 
            // picChart
            // 
            picChart.Image = (Image)resources.GetObject("picChart.Image");
            picChart.Location = new Point(12, 15);
            picChart.Name = "picChart";
            picChart.Size = new Size(25, 25);
            picChart.SizeMode = PictureBoxSizeMode.Zoom;
            picChart.TabIndex = 1;
            picChart.TabStop = false;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChartTitle.ForeColor = Color.FromArgb(58, 36, 30);
            lblChartTitle.Location = new Point(53, 15);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(243, 31);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Thống Kê Mượn Sách";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.FromArgb(255, 252, 250);
            pnlLowStock.Controls.Add(label5);
            pnlLowStock.Controls.Add(label6);
            pnlLowStock.Controls.Add(pictureBox3);
            pnlLowStock.Location = new Point(725, 130);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(220, 110);
            pnlLowStock.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(73, 52, 45);
            label5.Location = new Point(90, 65);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 2;
            label5.Text = "Sách Sắp Hết";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(58, 36, 30);
            label6.Location = new Point(90, 15);
            label6.Name = "label6";
            label6.Size = new Size(69, 54);
            label6.TabIndex = 1;
            label6.Text = "12";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pnlTotalBorrow
            // 
            pnlTotalBorrow.BackColor = Color.FromArgb(255, 252, 250);
            pnlTotalBorrow.Controls.Add(label3);
            pnlTotalBorrow.Controls.Add(label4);
            pnlTotalBorrow.Controls.Add(pictureBox2);
            pnlTotalBorrow.Location = new Point(490, 130);
            pnlTotalBorrow.Name = "pnlTotalBorrow";
            pnlTotalBorrow.Size = new Size(220, 110);
            pnlTotalBorrow.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(73, 52, 45);
            label3.Location = new Point(90, 69);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 2;
            label3.Text = "Lượt Mượn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(58, 36, 30);
            label4.Location = new Point(90, 15);
            label4.Name = "label4";
            label4.Size = new Size(69, 54);
            label4.TabIndex = 1;
            label4.Text = "32";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlTotalReaders
            // 
            pnlTotalReaders.BackColor = Color.FromArgb(255, 252, 250);
            pnlTotalReaders.Controls.Add(label1);
            pnlTotalReaders.Controls.Add(label2);
            pnlTotalReaders.Controls.Add(pictureBox1);
            pnlTotalReaders.Location = new Point(255, 130);
            pnlTotalReaders.Name = "pnlTotalReaders";
            pnlTotalReaders.Size = new Size(220, 110);
            pnlTotalReaders.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(73, 52, 45);
            label1.Location = new Point(90, 65);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 2;
            label1.Text = "Độc Giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(58, 36, 30);
            label2.Location = new Point(90, 15);
            label2.Name = "label2";
            label2.Size = new Size(69, 54);
            label2.TabIndex = 1;
            label2.Text = "48";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTotalBooks
            // 
            pnlTotalBooks.BackColor = Color.FromArgb(255, 252, 250);
            pnlTotalBooks.Controls.Add(lblBooksTitle);
            pnlTotalBooks.Controls.Add(lblTotalBooks);
            pnlTotalBooks.Controls.Add(picTotalBooks);
            pnlTotalBooks.Location = new Point(20, 130);
            pnlTotalBooks.Name = "pnlTotalBooks";
            pnlTotalBooks.Size = new Size(220, 110);
            pnlTotalBooks.TabIndex = 4;
            // 
            // lblBooksTitle
            // 
            lblBooksTitle.AutoSize = true;
            lblBooksTitle.ForeColor = Color.FromArgb(73, 52, 45);
            lblBooksTitle.Location = new Point(90, 65);
            lblBooksTitle.Name = "lblBooksTitle";
            lblBooksTitle.Size = new Size(90, 23);
            lblBooksTitle.TabIndex = 2;
            lblBooksTitle.Text = "Tổng Sách";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooks.ForeColor = Color.FromArgb(58, 36, 30);
            lblTotalBooks.Location = new Point(90, 15);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(92, 54);
            lblTotalBooks.TabIndex = 1;
            lblTotalBooks.Text = "125";
            // 
            // picTotalBooks
            // 
            picTotalBooks.Image = (Image)resources.GetObject("picTotalBooks.Image");
            picTotalBooks.Location = new Point(15, 25);
            picTotalBooks.Name = "picTotalBooks";
            picTotalBooks.Size = new Size(60, 60);
            picTotalBooks.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalBooks.TabIndex = 0;
            picTotalBooks.TabStop = false;
            // 
            // pnlDateTime
            // 
            pnlDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDateTime.BackColor = Color.FromArgb(251, 209, 203);
            pnlDateTime.Controls.Add(lblTime);
            pnlDateTime.Controls.Add(lblDate);
            pnlDateTime.Location = new Point(755, 20);
            pnlDateTime.Name = "pnlDateTime";
            pnlDateTime.Size = new Size(195, 80);
            pnlDateTime.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.FromArgb(73, 52, 45);
            lblTime.Location = new Point(15, 43);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(80, 25);
            lblTime.TabIndex = 1;
            lblTime.Text = "21:30:45";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(73, 52, 45);
            lblDate.Location = new Point(15, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(160, 25);
            lblDate.TabIndex = 0;
            lblDate.Text = "Thứ 4, 25/11/2026";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = Color.FromArgb(73, 52, 45);
            lblWelcome.Location = new Point(105, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(403, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "\tChào mừng bạn đến với hệ thống quản lý thư viện!";
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.BackColor = Color.Transparent;
            lblAdminTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.ForeColor = Color.FromArgb(235, 96, 80);
            lblAdminTitle.Location = new Point(105, 17);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(333, 60);
            lblAdminTitle.TabIndex = 1;
            lblAdminTitle.Text = "Trang Quản Trị";
            // 
            // picAdmin
            // 
            picAdmin.BackColor = Color.Transparent;
            picAdmin.Image = (Image)resources.GetObject("picAdmin.Image");
            picAdmin.Location = new Point(25, 25);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(65, 65);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 0;
            picAdmin.TabStop = false;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1162, 653);
            Controls.Add(pnlMain);
            Controls.Add(rdoNavSettings);
            Controls.Add(rdoNavReports);
            Controls.Add(rdoNavBorrow);
            Controls.Add(rdoNavBooks);
            Controls.Add(rdoNavReaders);
            Controls.Add(btnLogout);
            Controls.Add(pnlSidebar);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(58, 46, 43);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyThuVien(Admin)";
            Load += FormAdmin_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMain.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            pnlNotification.ResumeLayout(false);
            pnlNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBell).EndInit();
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTotalBorrow.ResumeLayout(false);
            pnlTotalBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTotalReaders.ResumeLayout(false);
            pnlTotalReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTotalBooks.ResumeLayout(false);
            pnlTotalBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalBooks).EndInit();
            pnlDateTime.ResumeLayout(false);
            pnlDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private TextBox textBox2;
        private Panel pnlSidebar;
        private Label lblAdminTitle;
        private PictureBox picLogo;
        private RadioButton rdoNavHome;
        private Panel pnlDateTime;
        private Button button1;
        private Label lblLogo;
        private RadioButton radioButton1;
        private RadioButton rdo30Days;
        private RadioButton rdoNavBorrow;
        private RadioButton rdoNavReports;
        private RadioButton rdoNavSettings;
        private Panel pnlLine;
        private Button btnLogout;
        private RadioButton rdoNavReaders;
        private RadioButton rdoNavBooks;
        private Panel pnlMain;
        private Panel pnlHome;
        private Label lblWelcome;
        private PictureBox picAdmin;
        private Label lblTime;
        private Label lblDate;
        private Panel pnlTotalBooks;
        private Label lblBooksTitle;
        private Label lblTotalBooks;
        private PictureBox picTotalBooks;
        private Panel pnlLowStock;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel pnlTotalBorrow;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel pnlTotalReaders;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel pnlChart;
        private Label lblChartTitle;
        private RadioButton rdoYear;
        private PictureBox picChart;
        private RadioButton rdo7Days;
        private Panel pnlNotification;
        private Label lblNotification;
        private PictureBox picBell;
        private Label lblNotice4;
        private Label lblNotice3;
        private Label lblNotice2;
        private Label lblNotice1;
        private Panel pnlChartArea;
        private System.Windows.Forms.Timer timerClock;
    }
}