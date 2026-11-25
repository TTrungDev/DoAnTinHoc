using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagement
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            timerClock_Tick(null, EventArgs.Empty);

        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        private void rdoNavBorrow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlChartArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int[] data = { 5, 12, 8, 16, 10, 13, 11 };

            string[] days = {
        "T2", "T3", "T4", "T5", "T6", "T7", "CN"
    };

            int left = 35;
            int top = 15;
            int right = pnlChartArea.Width - 20;
            int bottom = pnlChartArea.Height - 30;

            if (right <= left || bottom <= top)
                return;

            float stepX = (right - left) / 6f;
            float stepY = (bottom - top) / 20f;

            using Pen gridPen = new Pen(
                Color.FromArgb(230, 220, 215));

            using Pen linePen = new Pen(
                Color.FromArgb(235, 96, 80), 3);

            using SolidBrush textBrush = new SolidBrush(
                Color.FromArgb(73, 52, 45));

            using SolidBrush areaBrush = new SolidBrush(
                Color.FromArgb(80, 235, 96, 80));

            using SolidBrush pointBrush = new SolidBrush(
                Color.FromArgb(235, 96, 80));

            using Font font = new Font("Segoe UI", 9);

            // Vẽ đường kẻ ngang
            for (int i = 0; i <= 20; i += 5)
            {
                float y = bottom - i * stepY;

                g.DrawLine(gridPen, left, y, right, y);

                g.DrawString(i.ToString(), font,
                    textBrush, 5, y - 8);
            }

            PointF[] points = new PointF[data.Length];

            // Tính vị trí các điểm
            for (int i = 0; i < data.Length; i++)
            {
                float x = left + i * stepX;
                float y = bottom - data[i] * stepY;

                points[i] = new PointF(x, y);

                g.DrawLine(gridPen, x, top, x, bottom);

                g.DrawString(days[i], font,
                    textBrush, x - 10, bottom + 8);
            }

            // Tô màu bên dưới biểu đồ
            using GraphicsPath area = new GraphicsPath();

            area.AddLines(points);
            area.AddLine(points[6].X, points[6].Y,
                points[6].X, bottom);

            area.AddLine(points[6].X, bottom,
                points[0].X, bottom);

            area.CloseFigure();

            g.FillPath(areaBrush, area);

            // Vẽ đường biểu đồ
            g.DrawLines(linePen, points);

            // Vẽ các chấm tròn
            foreach (PointF p in points)
            {
                g.FillEllipse(pointBrush,
                    p.X - 4, p.Y - 4, 8, 8);
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy",new System.Globalization.CultureInfo("vi-VN"));

            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
