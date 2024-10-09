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
using DAL;
using DTO;
using BLL;
namespace GUI
{
    public partial class fKho : Form
    {
        private string idLogin;
        private PhuTungBLL _phuTungBLL;
        private HoaDonNhapBLL _hoaDonNhapBLL;
        private ChiTietHoaDonNhapBLL _chiTietHoaDonNhapBLL;

        private int countHdn;

        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private int whatIsRunning = 1; // 0 là ds hđn, 1 là ds phụ tùng
        public fKho(string idLogin)
        {
            InitializeComponent();
            _phuTungBLL = new PhuTungBLL();
            _hoaDonNhapBLL = new HoaDonNhapBLL();
            _chiTietHoaDonNhapBLL = new ChiTietHoaDonNhapBLL();
            this.idLogin = idLogin;


        }
        public void HienThiDSHoaDon()
        {
            List<HoaDonNhapDTO> listHoaDon = _hoaDonNhapBLL.LayHoaDonNhap();
            ThemDuLieuHoaDon(listHoaDon);
            countHdn = listHoaDon.Count;
        }
        private void HienThiDSPhuTung()
        {
            List<PhuTungDTO> listPhuTung = _phuTungBLL.LayDsPhuTung();
            ThemDuLieuPhuTung(listPhuTung);
        }
        private void fKho_Load(object sender, EventArgs e)
        {

            SetupDGVPhuTung();
            SetupDGVHDN();

            HienThiDSHoaDon();
            HienThiDSPhuTung();

            SetupPanelHDN();

            btnPhuTung_Click(this, EventArgs.Empty);
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
        private void ThemDuLieuPhuTung(List<PhuTungDTO> dsPhuTung)
        {
            dgvPhuTung.Rows.Clear();

            foreach (var phuTung in dsPhuTung)
            {
                dgvPhuTung.Rows.Add(phuTung.MaPhuTung, phuTung.TenPhuTung, phuTung.SoLuong, phuTung.DonGiaNhap, phuTung.DonGiaBan);
            }
        }
        private void ThemDuLieuHoaDon(List<HoaDonNhapDTO> dsHoaDonNhap)
        {
            dgvHDN.Rows.Clear();

            foreach (var hdn in dsHoaDonNhap)
            {
                // Định dạng ngày theo kiểu "dd/MM/yyyy"
                string formattedDate = hdn.NgayNhap.ToString("dd/MM/yyyy");

                dgvHDN.Rows.Add(hdn.MaHDN, hdn.MaNV, formattedDate, hdn.TongTien);
            }
        }
        // tìm bị nhảy nhảy
        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (whatIsRunning == 1)
            {
                if (txtSearchBar.Text != "")
                {
                    List<PhuTungDTO> listPhuTung = _phuTungBLL.TimDsTheoTen(txtSearchBar.Text);
                    ThemDuLieuPhuTung(listPhuTung);
                }
                else
                {
                    HienThiDSPhuTung();
                }
            }

        }
        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Search...")
            {
                txtSearchBar.Text = "";
            }
        }


        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "")
            {
                txtSearchBar.Text = "Search...";
            }
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


            dgvPhuTung.Columns["MaPhuTung_PhuTung"].FillWeight = 17;
            dgvPhuTung.Columns["TenPhuTung"].FillWeight = 23;
            dgvPhuTung.Columns["DonGiaNhap_PhuTung"].FillWeight = 17;
            dgvPhuTung.Columns["DonGiaBan"].FillWeight = 17;
            dgvPhuTung.Columns["SoLuong"].FillWeight = 15;
            dgvPhuTung.Columns["Actions"].FillWeight = 5;

            dgvPhuTung.RowTemplate.Height = 60;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhuTung.ColumnHeadersHeight = 60;



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


            dgvHDN.Columns["MaHDN"].FillWeight = 15;
            dgvHDN.Columns["MaNV"].FillWeight = 15;
            dgvHDN.Columns["NgayNhap"].FillWeight = 15;
            dgvHDN.Columns["Tien"].FillWeight = 15;
            dgvHDN.Columns["Actions"].FillWeight = 5;

            dgvHDN.RowTemplate.Height = 60;
            dgvHDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHDN.ColumnHeadersHeight = 60;



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
        private void txtMaPhuTung_Leave(object sender, EventArgs e)
        {
            if (txtMaPhuTung.Text != "")
            {
                string maPt = txtMaPhuTung.Text;
                bool kiemtraPt = _phuTungBLL.TimPhuTung(maPt);
                if (kiemtraPt)
                {
                    MessageBox.Show("Phu tung da co roi");
                    coPhuTung = true;
                    PhuTungDTO phuTung = _phuTungBLL.LayPhuTung(maPt);

                    if (phuTung != null)
                    {
                        // Gán giá trị vào các TextBox
                        txtTenPhuTung.Text = phuTung.TenPhuTung;
                        // txtSoLuong.Text = phuTung.SoLuong.ToString();
                        txtDonGiaNhap.Text = phuTung.DonGiaNhap.ToString("N0"); // Định dạng số nếu cần
                        txtDonGiaBan.Text = phuTung.DonGiaBan.ToString("N0"); // Định dạng số nếu cần
                    }
                    else
                    {
                        // Nếu không tìm thấy, làm sạch các TextBox
                        txtTenPhuTung.Text = string.Empty;
                        txtSoLuong.Text = string.Empty;
                        txtDonGiaNhap.Text = string.Empty;
                        txtDonGiaBan.Text = string.Empty;
                    }
                }
                else
                {
                    coPhuTung = false;
                }
            }
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
            whatIsRunning = 0;
        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {

            if (panelDS.Visible == false)
            {
                panelDS.Visible = true;
            }

            if (panelHDN.Visible == true)
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
            whatIsRunning = 1; // sao thêm cái này vào bị lỗi nhỉ ( để đầu thì lỗi, đề cuối thì không)
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
            txtManv.Text = idLogin;
            txtHdn.Text = "MDN" + countHdn.ToString();
            txtNgayNhap.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            thanhTien = 0;

            txtMaPhuTung.Clear();
            txtTenPhuTung.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();   
        }
        bool coPhuTung;
        private void txtMaPhuTung_MouseLeave(object sender, EventArgs e)
        {
            if (txtMaPhuTung.Text != "")
            {
                string maPt = txtMaPhuTung.Text;
                bool kiemtraPt = _phuTungBLL.TimPhuTung(maPt);
                if (kiemtraPt)
                {
                    MessageBox.Show("Phu tung da co roi");
                    coPhuTung = true;
                    PhuTungDTO phuTung = _phuTungBLL.LayPhuTung(maPt);

                    if (phuTung != null)
                    {
                        // Gán giá trị vào các TextBox
                        txtTenPhuTung.Text = phuTung.TenPhuTung;
                        // txtSoLuong.Text = phuTung.SoLuong.ToString();
                        txtDonGiaNhap.Text = phuTung.DonGiaNhap.ToString("N0"); // Định dạng số nếu cần
                        txtDonGiaBan.Text = phuTung.DonGiaBan.ToString("N0"); // Định dạng số nếu cần
                    }
                    else
                    {
                        // Nếu không tìm thấy, làm sạch các TextBox
                        txtTenPhuTung.Text = string.Empty;
                        txtSoLuong.Text = string.Empty;
                        txtDonGiaNhap.Text = string.Empty;
                        txtDonGiaBan.Text = string.Empty;
                    }
                }
                else
                {
                    coPhuTung = false;
                }
            }
        }
        decimal thanhTien;
        private void btnThemPhuTung_Click(object sender, EventArgs e)
        {
            // kiem tra xem co chua

            if (txtMaPhuTung.Text == "") { lbWarning2.Visible = true; return; }
            if (txtTenPhuTung.Text == "") { lbWarning3.Visible = true; return; }
            if (txtDonGiaNhap.Text == "") { lbWarning4.Visible = true; return; }
            if (txtSoLuong.Text == "") { lbWarning5.Visible = true; return; }
            if (txtDonGiaBan.Text == "") { lbWarning6.Visible = true; return; }
            if (txtNgayNhap.Text == "") { lbWarning7.Visible = true; return; }

            string mahdn = txtHdn.Text;
            string maPt = txtMaPhuTung.Text;
            string tenPt = txtTenPhuTung.Text;
            string dgNhap = txtDonGiaNhap.Text;
            string dgBan = txtDonGiaBan.Text;
            string ngayNhap = txtNgayNhap.Text;
            decimal donGiaNhap = decimal.Parse(txtDonGiaNhap.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            thanhTien += donGiaNhap * soLuong;
            txtThanhTien.Text = thanhTien.ToString();

            foreach (Control ct in panelHDN.Controls)
            {
                if (ct is Label lb)
                {
                    if (lb.Name.Contains("lbWarning"))
                    {
                        lb.Visible = false;
                    }
                }
            }

            // HDN -> PHUTUNG -> CHITIET
            // HIEN TAI LA THEM
            bool themHdn = _hoaDonNhapBLL.ThemHoaDonNhap(new HoaDonNhapDTO(mahdn, idLogin, DateTime.Parse(ngayNhap), thanhTien));



            if (themHdn)
            {
                MessageBox.Show("Them duoc HDN");
            }
            // ton tai phu tung roi
            if (coPhuTung)
            {

                bool suaPt = _phuTungBLL.SuaPhuTung(maPt, soLuong);
                if (suaPt)
                {
                    MessageBox.Show("Them so luong thanh cong");
                }
            }
            else
            {
                bool themPt = _phuTungBLL.ThemPhuTung(new PhuTungDTO(maPt, tenPt, soLuong, decimal.Parse(dgNhap), decimal.Parse(dgBan)));
                if (themPt)
                {
                    MessageBox.Show("Them duoc phu tung");
                }
            }

            bool themCt = _chiTietHoaDonNhapBLL.ThemHDN(new ChiTietHDNDTO(mahdn, maPt, soLuong));
            if (themCt)
            {
                MessageBox.Show("Them duoc chi tiet hdn");
            }

            //txtHdn.Clear();
            txtMaPhuTung.Clear();
            txtTenPhuTung.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtSoLuong.Clear();
            //txtNgayNhap.Clear();

            HienThiDSHoaDon();
            HienThiDSPhuTung();
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
