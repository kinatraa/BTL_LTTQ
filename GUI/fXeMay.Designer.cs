﻿using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class fXeMay
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnRes = new System.Windows.Forms.Panel();
            this.lbAmountResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAddNew = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpNgaySua = new System.Windows.Forms.DateTimePicker();
            this.txtNgaySua = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtNguyenNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvXeMay = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmsXeMay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new GUI.CustomDesign.CustomButton();
            this.btnAddNew = new GUI.CustomDesign.CustomButton();
            this.btnAdd = new GUI.CustomDesign.CustomButton();
            this.btnFilter = new GUI.CustomDesign.CustomButton();
            this.panel1.SuspendLayout();
            this.pnRes.SuspendLayout();
            this.panelAddNew.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeMay)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cmsXeMay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblShowResult);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.pnRes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panelAddNew);
            this.panel1.Controls.Add(this.dgvXeMay);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(48, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 725);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblShowResult
            // 
            this.lblShowResult.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowResult.Location = new System.Drawing.Point(937, 662);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(96, 40);
            this.lblShowResult.TabIndex = 0;
            this.lblShowResult.Text = "6";
            this.lblShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnNext.Location = new System.Drawing.Point(900, 665);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = ">";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPrevious.Location = new System.Drawing.Point(880, 665);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "<";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnRes
            // 
            this.pnRes.BackColor = System.Drawing.SystemColors.Control;
            this.pnRes.Controls.Add(this.lbAmountResult);
            this.pnRes.Location = new System.Drawing.Point(100, 656);
            this.pnRes.Name = "pnRes";
            this.pnRes.Size = new System.Drawing.Size(68, 38);
            this.pnRes.TabIndex = 13;
            this.pnRes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // lbAmountResult
            // 
            this.lbAmountResult.AutoSize = true;
            this.lbAmountResult.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountResult.Location = new System.Drawing.Point(23, 9);
            this.lbAmountResult.Name = "lbAmountResult";
            this.lbAmountResult.Size = new System.Drawing.Size(23, 20);
            this.lbAmountResult.TabIndex = 1;
            this.lbAmountResult.Text = "10";
            this.lbAmountResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(16, 667);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Show result:";
            // 
            // panelAddNew
            // 
            this.panelAddNew.Controls.Add(this.panel9);
            this.panelAddNew.Controls.Add(this.panel14);
            this.panelAddNew.Controls.Add(this.label2);
            this.panelAddNew.Controls.Add(this.panel12);
            this.panelAddNew.Controls.Add(this.panel7);
            this.panelAddNew.Controls.Add(this.label6);
            this.panelAddNew.Controls.Add(this.label3);
            this.panelAddNew.Controls.Add(this.panel11);
            this.panelAddNew.Controls.Add(this.label4);
            this.panelAddNew.Controls.Add(this.panel10);
            this.panelAddNew.Controls.Add(this.panel8);
            this.panelAddNew.Controls.Add(this.label5);
            this.panelAddNew.Location = new System.Drawing.Point(0, 77);
            this.panelAddNew.Name = "panelAddNew";
            this.panelAddNew.Size = new System.Drawing.Size(1088, 144);
            this.panelAddNew.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.txtDiaChi);
            this.panel9.Location = new System.Drawing.Point(895, 17);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(176, 40);
            this.panel9.TabIndex = 8;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(15, 8);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(158, 22);
            this.txtDiaChi.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel14.Controls.Add(this.btnAdd);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(1005, 85);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(66, 40);
            this.panel14.TabIndex = 10;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.Control;
            this.panel15.Location = new System.Drawing.Point(255, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(64, 40);
            this.panel15.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Controls.Add(this.pictureBox2);
            this.panel12.Controls.Add(this.dtpNgaySua);
            this.panel12.Controls.Add(this.txtNgaySua);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(747, 85);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(217, 40);
            this.panel12.TabIndex = 8;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::GUI.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(181, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // dtpNgaySua
            // 
            this.dtpNgaySua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySua.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySua.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpNgaySua.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpNgaySua.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgaySua.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpNgaySua.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaySua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySua.Location = new System.Drawing.Point(181, 4);
            this.dtpNgaySua.Name = "dtpNgaySua";
            this.dtpNgaySua.Size = new System.Drawing.Size(32, 29);
            this.dtpNgaySua.TabIndex = 11;
            this.dtpNgaySua.DropDown += new System.EventHandler(this.dtpNgaySua_DropDown);
            // 
            // txtNgaySua
            // 
            this.txtNgaySua.BackColor = System.Drawing.SystemColors.Control;
            this.txtNgaySua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgaySua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySua.Location = new System.Drawing.Point(14, 10);
            this.txtNgaySua.Name = "txtNgaySua";
            this.txtNgaySua.Size = new System.Drawing.Size(172, 22);
            this.txtNgaySua.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Location = new System.Drawing.Point(255, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(64, 40);
            this.panel13.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.txtTenKH);
            this.panel7.Location = new System.Drawing.Point(126, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(303, 40);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(14, 8);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(285, 22);
            this.txtTenKH.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày sửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "SĐT";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.txtNguyenNhan);
            this.panel11.Location = new System.Drawing.Point(256, 85);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(368, 40);
            this.panel11.TabIndex = 7;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // txtNguyenNhan
            // 
            this.txtNguyenNhan.BackColor = System.Drawing.SystemColors.Control;
            this.txtNguyenNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNguyenNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguyenNhan.Location = new System.Drawing.Point(14, 9);
            this.txtNguyenNhan.Name = "txtNguyenNhan";
            this.txtNguyenNhan.Size = new System.Drawing.Size(351, 22);
            this.txtNguyenNhan.TabIndex = 4;
            this.txtNguyenNhan.Text = "Nguyên nhân sửa chữa";
            this.txtNguyenNhan.Enter += new System.EventHandler(this.txtNguyenNhan_Enter);
            this.txtNguyenNhan.Leave += new System.EventHandler(this.txtNguyenNhan_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.txtMaXe);
            this.panel10.Location = new System.Drawing.Point(67, 85);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(128, 40);
            this.panel10.TabIndex = 6;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // txtMaXe
            // 
            this.txtMaXe.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.Location = new System.Drawing.Point(14, 9);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(111, 22);
            this.txtMaXe.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.txtSDT);
            this.panel8.Location = new System.Drawing.Point(563, 17);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(176, 40);
            this.panel8.TabIndex = 6;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(14, 8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(159, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã xe";
            // 
            // dgvXeMay
            // 
            this.dgvXeMay.AllowUserToAddRows = false;
            this.dgvXeMay.AllowUserToDeleteRows = false;
            this.dgvXeMay.AllowUserToResizeColumns = false;
            this.dgvXeMay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXeMay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXeMay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvXeMay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXeMay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvXeMay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXeMay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.TenXe,
            this.MaXe,
            this.MaLoai,
            this.SoKhung,
            this.SoMay,
            this.BienSo,
            this.MaMau});
            this.dgvXeMay.GridColor = System.Drawing.SystemColors.Control;
            this.dgvXeMay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvXeMay.Location = new System.Drawing.Point(19, 227);
            this.dgvXeMay.MultiSelect = false;
            this.dgvXeMay.Name = "dgvXeMay";
            this.dgvXeMay.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXeMay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXeMay.RowHeadersVisible = false;
            this.dgvXeMay.RowHeadersWidth = 51;
            this.dgvXeMay.RowTemplate.Height = 30;
            this.dgvXeMay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvXeMay.Size = new System.Drawing.Size(1060, 402);
            this.dgvXeMay.TabIndex = 2;
            this.dgvXeMay.TabStop = false;
            this.dgvXeMay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yourDataGridView_CellClick);
            this.dgvXeMay.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvXeMay_CellPainting);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            this.TenXe.Width = 125;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            this.MaXe.ReadOnly = true;
            this.MaXe.Width = 125;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 125;
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SoKhung";
            this.SoKhung.HeaderText = "Số khung";
            this.SoKhung.MinimumWidth = 6;
            this.SoKhung.Name = "SoKhung";
            this.SoKhung.ReadOnly = true;
            this.SoKhung.Width = 125;
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.HeaderText = "Số máy";
            this.SoMay.MinimumWidth = 6;
            this.SoMay.Name = "SoMay";
            this.SoMay.ReadOnly = true;
            this.SoMay.Width = 125;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // MaMau
            // 
            this.MaMau.DataPropertyName = "MaMau";
            this.MaMau.HeaderText = "Mã màu";
            this.MaMau.Name = "MaMau";
            this.MaMau.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.btnFilter);
            this.panel6.Location = new System.Drawing.Point(961, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 56);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.txtSearchBar);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(19, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(914, 56);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearchBar.Location = new System.Drawing.Point(45, 17);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(843, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Text = "Search by name, email, or orthers ...";
            this.txtSearchBar.WordWrap = false;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
            this.txtSearchBar.Leave += new System.EventHandler(this.txtSearchBar_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_search_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbOrder);
            this.panel2.Location = new System.Drawing.Point(48, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 56);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.AllowDrop = true;
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "All Orders",
            "Order1",
            "Order2"});
            this.cmbOrder.Location = new System.Drawing.Point(64, 16);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(108, 25);
            this.cmbOrder.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.btnAddNew);
            this.panel3.Location = new System.Drawing.Point(973, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 56);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::GUI.Properties.Resources.address_book;
            this.pictureBox4.Location = new System.Drawing.Point(15, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.btnImport);
            this.panel4.Location = new System.Drawing.Point(792, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 56);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::GUI.Properties.Resources.file_download;
            this.pictureBox3.Location = new System.Drawing.Point(17, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // cmsXeMay
            // 
            this.cmsXeMay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmsXeMay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsXeMay.Name = "cmsXeMay";
            this.cmsXeMay.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsXeMay.Size = new System.Drawing.Size(119, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "Update";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Update_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Window;
            this.btnImport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnImport.BorderColor = System.Drawing.Color.Empty;
            this.btnImport.BorderThickness = 1.5F;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(147, 50);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.BorderColor = System.Drawing.Color.Empty;
            this.btnAddNew.BorderThickness = 1.5F;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(157, 50);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.BorderColor = System.Drawing.Color.Empty;
            this.btnAdd.BorderThickness = 1.5F;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilter.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnFilter.BorderColor = System.Drawing.Color.Empty;
            this.btnFilter.BorderThickness = 1.5F;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnFilter.Location = new System.Drawing.Point(3, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 50);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filters";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // fXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 869);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fXeMay";
            this.Text = "fXeMay";
            this.Load += new System.EventHandler(this.fXeMay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnRes.ResumeLayout(false);
            this.pnRes.PerformLayout();
            this.panelAddNew.ResumeLayout(false);
            this.panelAddNew.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeMay)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cmsXeMay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchBar;
        private CustomDesign.CustomButton btnFilter;
        private System.Windows.Forms.DataGridView dgvXeMay;
        private CustomDesign.CustomButton btnImport;
        private CustomDesign.CustomButton btnAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtNguyenNhan;
        private CustomDesign.CustomButton btnAdd;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.ContextMenuStrip cmsXeMay;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DateTimePicker dtpNgaySua;
        private TextBox txtNgaySua;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label7;
        private Panel pnRes;
        private Label lblShowResult;
        private Button btnPrevious;
        private Button btnNext;
        private Label lbAmountResult;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn TenXe;
        private DataGridViewTextBoxColumn MaXe;
        private DataGridViewTextBoxColumn MaLoai;
        private DataGridViewTextBoxColumn SoKhung;
        private DataGridViewTextBoxColumn SoMay;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn MaMau;
    }
}