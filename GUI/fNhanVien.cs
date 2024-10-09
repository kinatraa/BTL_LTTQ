using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fNhanVien : Form
    {
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private Image[] avatars = new Image[5];
        public fNhanVien()
        {
            InitializeComponent();

            ImportAvatar();

            SetupDataGridView();
        }

        private void ImportAvatar()
        {
            avatars[0] = Properties.Resources.Avatar;
            avatars[1] = Properties.Resources.Avatar_1_;
            avatars[2] = Properties.Resources.Avatar_2_;
            avatars[3] = Properties.Resources.Avatar_3_;
            avatars[4] = Properties.Resources.Avatar_4_;
        }

        public int RandId(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void SetupDataGridView()
        {

            /*dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;*/
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = SystemColors.Window;
            /*            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = dgvNhanVien.BackColor;
                        dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = dgvNhanVien.ForeColor;*/

            dgvNhanVien.DefaultCellStyle.SelectionBackColor = dgvNhanVien.DefaultCellStyle.BackColor;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = dgvNhanVien.DefaultCellStyle.ForeColor;

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvNhanVien.Columns["TenNV"].FillWeight = 40;
            dgvNhanVien.Columns["NgayBatDau"].FillWeight = 40;
            dgvNhanVien.Columns["Luong"].FillWeight = 20;

            /*dgvNhanVien.Columns["Luong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
*/
            dgvNhanVien.RowTemplate.Height = 60;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.ColumnHeadersHeight = 60;

            dgvNhanVien.Rows.Add("Arlene McCoy\nWorker", "Mar 1, 2022\nJoined from 235 days", "$1,546\n1 Jun 2022");
            dgvNhanVien.Rows.Add("John Doe\nManager", "Feb 15, 2021\nJoined from 600 days", "$2,345\n5 Mar 2022");
            dgvNhanVien.Rows.Add("Jane Smith\nEngineer", "Jul 10, 2020\nJoined from 800 days", "$3,250\n12 Dec 2021");
            dgvNhanVien.Rows.Add("Michael Johnson\nTechnician", "Apr 23, 2021\nJoined from 500 days", "$1,850\n10 May 2022");
            dgvNhanVien.Rows.Add("Emily Davis\nDesigner", "Oct 5, 2022\nJoined from 180 days", "$1,750\n15 Nov 2022");
            dgvNhanVien.Rows.Add("Sarah Lee\nMarketing", "Jan 10, 2023\nJoined from 90 days", "$1,400\n1 Apr 2023");
            dgvNhanVien.Rows.Add("David Brown\nHR", "Dec 15, 2021\nJoined from 400 days", "$2,100\n20 Jan 2022");
            dgvNhanVien.Rows.Add("Laura Wilson\nSales", "Jun 17, 2020\nJoined from 950 days", "$2,800\n7 Feb 2021");
            dgvNhanVien.Rows.Add("Chris White\nSupport", "Sep 3, 2022\nJoined from 200 days", "$1,500\n22 Sep 2022");
            dgvNhanVien.Rows.Add("Megan Thompson\nAnalyst", "May 25, 2021\nJoined from 480 days", "$2,050\n1 Jul 2021");
            dgvNhanVien.Rows.Add("Paul Walker\nSupervisor", "Nov 15, 2020\nJoined from 750 days", "$3,500\n25 Jan 2021");
            dgvNhanVien.Rows.Add("Sophia Martinez\nAccountant", "Dec 1, 2019\nJoined from 1000 days", "$2,900\n10 Dec 2019");
            dgvNhanVien.Rows.Add("Alexander Kim\nConsultant", "Mar 18, 2022\nJoined from 230 days", "$3,200\n15 Mar 2022");
            dgvNhanVien.Rows.Add("Olivia Hernandez\nDeveloper", "Jul 27, 2021\nJoined from 400 days", "$2,600\n22 Sep 2021");
            dgvNhanVien.Rows.Add("Benjamin Carter\nArchitect", "Jan 5, 2020\nJoined from 900 days", "$4,100\n10 Feb 2020");
            dgvNhanVien.Rows.Add("Victoria Evans\nNurse", "May 22, 2022\nJoined from 160 days", "$1,950\n1 Jun 2022");
            dgvNhanVien.Rows.Add("James Russell\nScientist", "Aug 14, 2019\nJoined from 1100 days", "$5,200\n15 Sep 2019");
            dgvNhanVien.Rows.Add("Ella Murphy\nReceptionist", "Oct 3, 2021\nJoined from 365 days", "$1,300\n20 Oct 2021");
            dgvNhanVien.Rows.Add("Henry Rodriguez\nTeacher", "Feb 25, 2021\nJoined from 600 days", "$2,450\n5 Mar 2021");
            dgvNhanVien.Rows.Add("Ava Bennett\nLawyer", "Apr 18, 2020\nJoined from 820 days", "$3,750\n22 Apr 2020");


        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*if (dgvNhanVien.Columns[e.ColumnIndex].Name == "Luong")
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }*/
        }

        private void dgvNhanVien_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                // Cuộn lên
                if (dgvNhanVien.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgvNhanVien.FirstDisplayedScrollingRowIndex--;
                }
            }
            else if (e.Delta < 0)
            {
                // Cuộn xuống
                if (dgvNhanVien.FirstDisplayedScrollingRowIndex < dgvNhanVien.RowCount - 1)
                {
                    dgvNhanVien.FirstDisplayedScrollingRowIndex++;
                }
            }
        }


        private void dgvNhanVien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                if (e.ColumnIndex == dgvNhanVien.Columns["TenNV"].Index &&
                    dgvNhanVien.Rows[e.RowIndex].Cells["TenNV"].Value != null)
                {
                    Rectangle rect = e.CellBounds;

                    Image img = avatars[RandId(0, 5)];
                    Rectangle imgRect = new Rectangle(rect.X + 5, rect.Y + 5, 40, 40);
                    e.Graphics.DrawImage(img, imgRect);

                    string[] parts = ((string)dgvNhanVien.Rows[e.RowIndex].Cells["TenNV"].Value).Split('\n');
                    string p1 = parts[0];
                    string p2 = parts[1];


                    e.Graphics.DrawString(p1, font, Brushes.Black, rect.X + 50, rect.Y + 5);
                    e.Graphics.DrawString(p2, fontSub, Brushes.Gray, rect.X + 50, rect.Y + 25);
                }
                else if (e.ColumnIndex == dgvNhanVien.Columns["NgayBatDau"].Index &&
                    dgvNhanVien.Rows[e.RowIndex].Cells["NgayBatDau"].Value != null)
                {
                    Rectangle rect = e.CellBounds;

                    string[] parts = ((string)dgvNhanVien.Rows[e.RowIndex].Cells["NgayBatDau"].Value).Split('\n');
                    string p1 = parts[0];
                    string p2 = parts[1];

                    e.Graphics.DrawString(p1, font, Brushes.Black, rect.X, rect.Y + 5);
                    e.Graphics.DrawString(p2, fontSub, Brushes.Gray, rect.X, rect.Y + 25);
                }
                else if (e.ColumnIndex == dgvNhanVien.Columns["Luong"].Index &&
                    dgvNhanVien.Rows[e.RowIndex].Cells["Luong"].Value != null)
                {
                    Rectangle rect = e.CellBounds;

                    string[] parts = ((string)dgvNhanVien.Rows[e.RowIndex].Cells["Luong"].Value).Split('\n');
                    string p1 = parts[0];
                    string p2 = parts[1];

                    e.Graphics.DrawString(p1, font, Brushes.Black, rect.X, rect.Y + 5);
                    e.Graphics.DrawString(p2, fontSub, Brushes.Gray, rect.X, rect.Y + 25);
                }
            }
        }
    }
}
