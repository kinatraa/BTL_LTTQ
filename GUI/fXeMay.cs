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
using BLL;
using DTO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fXeMay : Form
    {
        private XeMayBLL _xeMayBLL;
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private bool addNewClicked = false;
        private Point posA = new Point(19, 80), posB = new Point(19, 227);
        public fXeMay()
        {
            InitializeComponent();

            _xeMayBLL = new XeMayBLL();

            panelAddNew.Visible = false;
            dgvXeMay.Location = posA;

            SetupAddPanel();
            dgvXeMay.Height += (227 - 80);

            

            cmbOrder.SelectedIndex = 0;
        }
        private void fXeMay_Load(object sender, EventArgs e)
        {
            ShowXeMayList();
        }
        private void ShowXeMayList()
        {
            List<XeMayDTO> dsXeMay = _xeMayBLL.LayDanhSachXeMay();
            SetupDataGridView(dsXeMay);
            lblShowResult.Text = dsXeMay.Count.ToString();
        }
        private void SetupAddPanel()
        {
            /*panelAddNew.Controls.Add(label2);
            panelAddNew.Controls.Add(label3);
            panelAddNew.Controls.Add(label4);
            panelAddNew.Controls.Add(label5);
            panelAddNew.Controls.Add(label6);
            panelAddNew.Controls.Add(panel7);
            panelAddNew.Controls.Add(panel8);
            panelAddNew.Controls.Add(panel9);
            panelAddNew.Controls.Add(panel10);
            panelAddNew.Controls.Add(panel11);
            panelAddNew.Controls.Add(panel12);
            panelAddNew.Controls.Add(panel14);
            panelAddNew.Controls.Add(txtTenKH);
            panelAddNew.Controls.Add(txtSDT);
            panelAddNew.Controls.Add(txtDiaChi);
            panelAddNew.Controls.Add(txtMaXe);
            panelAddNew.Controls.Add(txtNguyenNhan);
            panelAddNew.Controls.Add(txtNgaySua);
            panelAddNew.Controls.Add(btnAdd);*/
            dtpNgaySua.ValueChanged += (s, ev) =>
            {
                txtNgaySua.Text = dtpNgaySua.Value.ToString("dddd, dd/MM/yyyy");
            };
        }

        private void SetupDataGridView(List<XeMayDTO> dsXeMay)
        {

            dgvXeMay.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvXeMay.EnableHeadersVisualStyles = false;
            dgvXeMay.GridColor = Color.LightGray;
            dgvXeMay.ColumnHeadersDefaultCellStyle.BackColor = dgvXeMay.BackColor;
            dgvXeMay.ColumnHeadersDefaultCellStyle.ForeColor = dgvXeMay.ForeColor;

            dgvXeMay.DefaultCellStyle.SelectionBackColor = dgvXeMay.DefaultCellStyle.BackColor;
            dgvXeMay.DefaultCellStyle.SelectionForeColor = dgvXeMay.DefaultCellStyle.ForeColor;

            dgvXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvXeMay.Columns.Add(actionsColumn);


            dgvXeMay.Columns["TenXe"].FillWeight = 20;
            dgvXeMay.Columns["MaXe"].FillWeight = 10;
            dgvXeMay.Columns["MaLoai"].FillWeight = 10;
            dgvXeMay.Columns["SoKhung"].FillWeight = 15;
            dgvXeMay.Columns["SoMay"].FillWeight = 15;
            dgvXeMay.Columns["BienSo"].FillWeight = 15;
            dgvXeMay.Columns["MaMau"].FillWeight = 10;
            dgvXeMay.Columns["Actions"].FillWeight = 5;

            dgvXeMay.RowTemplate.Height = 60;
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvXeMay.ColumnHeadersHeight = 60;

            dgvXeMay.Rows.Clear();

            foreach (var xe in dsXeMay)
            {
                dgvXeMay.Rows.Add(xe.TenXe, xe.MaXe, xe.LoaiXe, xe.SoKhung, xe.SoMay, xe.BienSo, xe.MaMau);
            }

            //dgvXeMay.Rows.Add("Honda Civic", "HC123", "L01", "KH123456", "M123456", "29A-123.45", "MM01");
            //dgvXeMay.Rows.Add("Yamaha R15", "YR456", "L02", "KH654321", "M654321", "29A-456.78", "MM02");
            //dgvXeMay.Rows.Add("Suzuki Hayabusa", "SH789", "L01", "KH987654", "M987654", "29A-789.01", "MM03");
            //dgvXeMay.Rows.Add("Kawasaki Ninja", "KN012", "L03", "KH111222", "M111222", "29A-012.34", "MM04");
            //dgvXeMay.Rows.Add("BMW S1000RR", "BS345", "L01", "KH333444", "M333444", "29A-345.67", "MM05");
            //dgvXeMay.Rows.Add("Ducati Panigale", "DP678", "L02", "KH555666", "M555666", "29A-678.90", "MM06");
            //dgvXeMay.Rows.Add("Harley Davidson", "HD901", "L03", "KH777888", "M777888", "29A-901.12", "MM07");
            //dgvXeMay.Rows.Add("Triumph Bonneville", "TB234", "L01", "KH999000", "M999000", "29A-234.56", "MM08");
            //dgvXeMay.Rows.Add("Aprilia RS660", "AR567", "L02", "KH123456", "M123456", "29A-567.89", "MM09");
            //dgvXeMay.Rows.Add("KTM RC390", "KT890", "L03", "KH789012", "M789012", "29A-890.23", "MM10");

        }

        private void dgvXeMay_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private async void ToggleAddNew()
        {
            if (!addNewClicked)
            {
                panelAddNew.Visible = true;
                await AnimateDataGridView(posB, dgvXeMay.Height - (227 - 80));
                
                addNewClicked = true;
            }
            else
            {
                
                await AnimateDataGridView(posA, dgvXeMay.Height + (227 - 80));
                panelAddNew.Visible = false;
                addNewClicked = false;
            }
        }

        private async Task AnimateDataGridView(Point targetPosition, int targetHeight)
        {
            int steps = 20;
            int stepX = (targetPosition.X - dgvXeMay.Location.X) / steps;
            int stepY = (targetPosition.Y - dgvXeMay.Location.Y) / steps;
            int stepHeight = (targetHeight - dgvXeMay.Height) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvXeMay.Location = new Point(dgvXeMay.Location.X + stepX, dgvXeMay.Location.Y + stepY);

                dgvXeMay.Height += stepHeight;

                await Task.Delay(5);
            }

            dgvXeMay.Location = targetPosition;
            dgvXeMay.Height = targetHeight;

			btnAddNew.Enabled = true;
		}


        private void btnAddNew_Click(object sender, EventArgs e)
        {
			btnAddNew.Enabled = false;
			ToggleAddNew();
        }

        private void dtpNgaySua_DropDown(object sender, EventArgs e)
        {

        }

        private void yourDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvXeMay.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvXeMay.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsXeMay.Show(dgvXeMay, cellRectangle.Left, cellRectangle.Bottom - 20);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel6, 15, BorderColor, BorderThickness, e);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel7, 15, BorderColor, BorderThickness, e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel8, 15, BorderColor, BorderThickness, e);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel3, 15, BorderColor, BorderThickness, e);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel14, 15, BorderColor, BorderThickness, e);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(pnRes, 15, BorderColor, BorderThickness, e);
        }

        private void txtNguyenNhan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNguyenNhan.Text))
            {
                txtNguyenNhan.Text = "Nguyên nhân sửa chữa";
            }
        }

        private void txtNguyenNhan_Enter(object sender, EventArgs e)
        {
            if (txtNguyenNhan.Text == "Nguyên nhân sửa chữa")
            {
                txtNguyenNhan.Text = string.Empty;
            }
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Search by name, email, or orthers ...")
            {
                txtSearchBar.Text = string.Empty;
            }
        }

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text))
            {
                txtSearchBar.Text = "Search by name, email, or orthers ...";
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //format
            txtTenKH.Text = string.Empty;
            txtMaXe.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtNgaySua.Text = string.Empty;
            txtNguyenNhan.Text= "Nguyên nhân sửa chữa";
            txtSDT.Text = string.Empty;
            //

        }
    }
}
