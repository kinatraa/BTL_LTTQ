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
using DTO;

namespace GUI
{
    public partial class fKho : Form
    {
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private int whatIsRunning = 1;
        public fKho()
        {
            InitializeComponent();

            SetupDGVPhuTung();
            SetupDGVHDN();
            SetupPanelHDN();

            btnHDN_Click(this, EventArgs.Empty);

            cmbOrder.SelectedIndex = 0;
        }

        private void SetupPanelHDN()
        {
            panelHDN.Location = new Point(48, 118);

            dtpNgayNhap.ValueChanged += (s, ev) =>
            {
                txtNgayNhap.Text = dtpNgayNhap.Value.ToString("dddd, dd/MM/yyyy");
            };

            panelHDN.Visible = false;
        }

        private void SetupDGVPhuTung()
        {

            dgvPhuTung.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvPhuTung.EnableHeadersVisualStyles = false;
            dgvPhuTung.GridColor = Color.LightGray;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.BackColor = dgvPhuTung.BackColor;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.ForeColor = dgvPhuTung.ForeColor;

            dgvPhuTung.DefaultCellStyle.SelectionBackColor = dgvPhuTung.DefaultCellStyle.BackColor;
            dgvPhuTung.DefaultCellStyle.SelectionForeColor = dgvPhuTung.DefaultCellStyle.ForeColor;

            dgvPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvPhuTung.Columns.Add(actionsColumn);


            dgvPhuTung.Columns["MaPhuTung_PhuTung"].FillWeight = 15;
            dgvPhuTung.Columns["TenPhuTung"].FillWeight = 23;
            dgvPhuTung.Columns["DonGiaNhap_PhuTung"].FillWeight = 17;
            dgvPhuTung.Columns["DonGiaBan"].FillWeight = 17;
            dgvPhuTung.Columns["GhiChu"].FillWeight = 23;
            dgvPhuTung.Columns["Actions"].FillWeight = 5;

            dgvPhuTung.RowTemplate.Height = 60;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhuTung.ColumnHeadersHeight = 60;

            dgvPhuTung.Rows.Add("PT001", "Lốp xe", "1,000,000 VND", "1,200,000 VND", "Chính hãng");
            dgvPhuTung.Rows.Add("PT002", "Bộ phanh", "800,000 VND", "1,000,000 VND", "Chính hãng");
            dgvPhuTung.Rows.Add("PT003", "Đèn pha", "500,000 VND", "700,000 VND", "Hàng nhập khẩu");
            dgvPhuTung.Rows.Add("PT004", "Gương chiếu hậu", "300,000 VND", "500,000 VND", "Chính hãng");
            dgvPhuTung.Rows.Add("PT005", "Lọc gió", "200,000 VND", "350,000 VND", "Hàng nội địa");
            dgvPhuTung.Rows.Add("PT006", "Bộ giảm xóc", "1,500,000 VND", "1,800,000 VND", "Chính hãng");
            dgvPhuTung.Rows.Add("PT007", "Bình ắc quy", "1,200,000 VND", "1,500,000 VND", "Hàng nhập khẩu");
            dgvPhuTung.Rows.Add("PT008", "Động cơ", "5,000,000 VND", "5,500,000 VND", "Hàng mới");
            dgvPhuTung.Rows.Add("PT009", "Hệ thống điều hòa", "3,000,000 VND", "3,500,000 VND", "Chính hãng");
            dgvPhuTung.Rows.Add("PT010", "Bộ đề xe", "900,000 VND", "1,100,000 VND", "Hàng nội địa");

            //dgvPhuTung.Rows.Clear();

            //foreach(var phuTung  in dsPhuTung)
            //{
            //    dgvPhuTung.Rows.Add(phuTung.MaPhuTung, phuTung.TenPhuTung);
            //}

        }

        private void SetupDGVHDN()
        {

            dgvHDN.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvHDN.EnableHeadersVisualStyles = false;
            dgvHDN.GridColor = Color.LightGray;
            dgvHDN.ColumnHeadersDefaultCellStyle.BackColor = dgvHDN.BackColor;
            dgvHDN.ColumnHeadersDefaultCellStyle.ForeColor = dgvHDN.ForeColor;

            dgvHDN.DefaultCellStyle.SelectionBackColor = dgvHDN.DefaultCellStyle.BackColor;
            dgvHDN.DefaultCellStyle.SelectionForeColor = dgvHDN.DefaultCellStyle.ForeColor;

            dgvHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvHDN.Columns.Add(actionsColumn);


            dgvHDN.Columns["MaHDN"].FillWeight = 12;
            dgvHDN.Columns["MaPhuTung_HDN"].FillWeight = 12;
            dgvHDN.Columns["MaNV"].FillWeight = 13;
            dgvHDN.Columns["NgayNhap"].FillWeight = 15;
            dgvHDN.Columns["DonGiaNhap_HDN"].FillWeight = 15;
            dgvHDN.Columns["SoLuong"].FillWeight = 10;
            dgvHDN.Columns["ThanhTien"].FillWeight = 18;
            dgvHDN.Columns["Actions"].FillWeight = 5;

            dgvHDN.RowTemplate.Height = 60;
            dgvHDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHDN.ColumnHeadersHeight = 60;

            dgvHDN.Rows.Add("HDN001", "PT001", "NV001", "2024-10-01", "1,000,000", 10, "10,000,000");
            dgvHDN.Rows.Add("HDN002", "PT002", "NV002", "2024-09-28", "800,000", 5, "4,000,000");
            dgvHDN.Rows.Add("HDN003", "PT003", "NV003", "2024-09-30", "500,000", 7, "3,500,000");
            dgvHDN.Rows.Add("HDN004", "PT004", "NV001", "2024-09-29", "300,000", 12, "3,600,000");
            dgvHDN.Rows.Add("HDN005", "PT005", "NV002", "2024-10-02", "200,000", 20, "4,000,000");
            dgvHDN.Rows.Add("HDN006", "PT006", "NV003", "2024-10-01", "1,500,000", 6, "9,000,000");
            dgvHDN.Rows.Add("HDN007", "PT007", "NV001", "2024-09-25", "1,200,000", 4, "4,800,000");
            dgvHDN.Rows.Add("HDN008", "PT008", "NV002", "2024-09-27", "5,000,000", 2, "10,000,000");
            dgvHDN.Rows.Add("HDN009", "PT009", "NV003", "2024-09-26", "3,000,000", 3, "9,000,000");
            dgvHDN.Rows.Add("HDN010", "PT010", "NV001", "2024-10-01", "900,000", 8, "7,200,000");


        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                string cellValue = e.Value?.ToString() ?? string.Empty;
                if (cellValue != string.Empty)
                {
                    Rectangle rect = e.CellBounds;
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, rect.X, rect.Y + 15);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhuTung.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvPhuTung.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsKho.Show(dgvPhuTung, cellRectangle.Left, cellRectangle.Bottom - 20);
            }
            else if (e.ColumnIndex == dgvHDN.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvHDN.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsKho.Show(dgvHDN, cellRectangle.Left, cellRectangle.Bottom - 20);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update selected!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete selected!");
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            if (panelDS.Visible == false)
            {
                panelDS.Visible = true;
            }

            if (panelHDN.Visible == true)
            {
                panelHDN.Visible = false;
            }

            dgvHDN.FirstDisplayedScrollingRowIndex = 0;

            foreach (DataGridViewColumn column in dgvHDN.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvPhuTung.Visible = false;

            dgvHDN.Visible = true;

            btnHDN.BackgroundColor = Color.Black;
            btnHDN.ForeColor = Color.White;
            panel4.BackColor = Color.Black;

            btnPhuTung.BackgroundColor = SystemColors.GradientActiveCaption;
            btnPhuTung.ForeColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.GradientActiveCaption;

            btnAddHDN.BackgroundColor = SystemColors.GradientActiveCaption;
            btnAddHDN.ForeColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.GradientActiveCaption;
        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            if(panelDS.Visible == false)
            {
                panelDS.Visible = true;
            }

            if(panelHDN.Visible == true)
            {
                panelHDN.Visible = false;
            }

            dgvPhuTung.FirstDisplayedScrollingRowIndex = 0;

            foreach (DataGridViewColumn column in dgvPhuTung.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvHDN.Visible = false;

            dgvPhuTung.Visible = true;

            btnPhuTung.BackgroundColor = Color.Black;
            btnPhuTung.ForeColor = Color.White;
            panel1.BackColor = Color.Black;

            btnHDN.BackgroundColor = SystemColors.GradientActiveCaption;
            btnHDN.ForeColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.GradientActiveCaption;

            btnAddHDN.BackgroundColor = SystemColors.GradientActiveCaption;
            btnAddHDN.ForeColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.GradientActiveCaption;
        }


        private void btnAddHDN_Click(object sender, EventArgs e)
        {
            panelDS.Visible = false;

            panelHDN.Visible = true;

            btnAddHDN.BackgroundColor = Color.Black;
            btnAddHDN.ForeColor = Color.White;
            panel14.BackColor = Color.Black;

            btnHDN.BackgroundColor = SystemColors.GradientActiveCaption;
            btnHDN.ForeColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.GradientActiveCaption;

            btnPhuTung.BackgroundColor = SystemColors.GradientActiveCaption;
            btnPhuTung.ForeColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.GradientActiveCaption;
        }

        private void btnThemPhuTung_Click(object sender, EventArgs e)
        {

        }

        private void DrawRoundedPanel(Panel panel, int radius, Color borderColor, float borderThickness, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                g.DrawPath(pen, path);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel14, 15, BorderColor, BorderThickness, e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel18, 15, BorderColor, BorderThickness, e);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel9, 15, BorderColor, BorderThickness, e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel10, 15, BorderColor, BorderThickness, e);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel11, 15, BorderColor, BorderThickness, e);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel12, 15, BorderColor, BorderThickness, e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel13, 15, BorderColor, BorderThickness, e);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel17, 15, BorderColor, BorderThickness, e);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel18, 15, BorderColor, BorderThickness, e);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel19, 15, BorderColor, BorderThickness, e);
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel20, 15, BorderColor, BorderThickness, e);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel21, 15, BorderColor, BorderThickness, e);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel6, 15, BorderColor, BorderThickness, e);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel16, 15, BorderColor, BorderThickness, e);
        }
    }
}
