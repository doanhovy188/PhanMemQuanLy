﻿
namespace ProjectMonHoc
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHeThong = new System.Windows.Forms.MenuStrip();
            this.columnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMain = new System.Windows.Forms.Panel();
            this.ptbTienThua = new System.Windows.Forms.PictureBox();
            this.ptbTienDua = new System.Windows.Forms.PictureBox();
            this.ptbTongTien = new System.Windows.Forms.PictureBox();
            this.ptbDiscount = new System.Windows.Forms.PictureBox();
            this.pnDropDownMenuAvatar = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnXemHoSo = new System.Windows.Forms.Button();
            this.lbFullName = new System.Windows.Forms.Label();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.tabDoUong = new System.Windows.Forms.TabControl();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTienThua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTienKhachDua = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyBill = new System.Windows.Forms.Button();
            this.cbbGiamGia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlBan = new System.Windows.Forms.TabControl();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmTabBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmrDropdownMenu = new System.Windows.Forms.Timer(this.components);
            this.menuStripHeThong.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTienThua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTienDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscount)).BeginInit();
            this.pnDropDownMenuAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabControlBan.SuspendLayout();
            this.ctmTabBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDangNhap,
            this.menuItemDangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // menuItemDangNhap
            // 
            this.menuItemDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemDangNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemDangNhap.Name = "menuItemDangNhap";
            this.menuItemDangNhap.Size = new System.Drawing.Size(165, 28);
            this.menuItemDangNhap.Text = "Đăng Nhập";
            this.menuItemDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuItemDangNhap.Click += new System.EventHandler(this.menuItemDangNhap_Click);
            // 
            // menuItemDangXuat
            // 
            this.menuItemDangXuat.Enabled = false;
            this.menuItemDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuItemDangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemDangXuat.Name = "menuItemDangXuat";
            this.menuItemDangXuat.Size = new System.Drawing.Size(165, 28);
            this.menuItemDangXuat.Text = "Đăng Xuất";
            this.menuItemDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuItemDangXuat.Click += new System.EventHandler(this.menuItemDangXuat_Click);
            // 
            // menuItemAdmin
            // 
            this.menuItemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemThemUser,
            this.xemHóaĐơnToolStripMenuItem});
            this.menuItemAdmin.Enabled = false;
            this.menuItemAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemAdmin.Name = "menuItemAdmin";
            this.menuItemAdmin.Size = new System.Drawing.Size(72, 27);
            this.menuItemAdmin.Text = "Admin";
            // 
            // menuItemThemUser
            // 
            this.menuItemThemUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemThemUser.Name = "menuItemThemUser";
            this.menuItemThemUser.Size = new System.Drawing.Size(225, 28);
            this.menuItemThemUser.Text = "Quản Lý Nhân Viên";
            this.menuItemThemUser.Click += new System.EventHandler(this.menuItemThemUser_Click);
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn";
            this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemHóaĐơnToolStripMenuItem_Click);
            // 
            // menuItemDanhMuc
            // 
            this.menuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMónĂnToolStripMenuItem,
            this.chỉnhSửaDanhMụcToolStripMenuItem});
            this.menuItemDanhMuc.Enabled = false;
            this.menuItemDanhMuc.Name = "menuItemDanhMuc";
            this.menuItemDanhMuc.Size = new System.Drawing.Size(100, 27);
            this.menuItemDanhMuc.Text = "Danh mục";
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            this.quảnLýMónĂnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            this.quảnLýMónĂnToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.quảnLýMónĂnToolStripMenuItem.Text = "Quản Lý Món Ăn";
            this.quảnLýMónĂnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMónĂnToolStripMenuItem_Click);
            // 
            // chỉnhSửaDanhMụcToolStripMenuItem
            // 
            this.chỉnhSửaDanhMụcToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chỉnhSửaDanhMụcToolStripMenuItem.Name = "chỉnhSửaDanhMụcToolStripMenuItem";
            this.chỉnhSửaDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.chỉnhSửaDanhMụcToolStripMenuItem.Text = "Chỉnh Sửa Danh Mục";
            this.chỉnhSửaDanhMụcToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaDanhMụcToolStripMenuItem_Click);
            // 
            // menuStripHeThong
            // 
            this.menuStripHeThong.Font = new System.Drawing.Font("Calibri", 14F);
            this.menuStripHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.menuItemAdmin,
            this.menuItemDanhMuc});
            this.menuStripHeThong.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeThong.Name = "menuStripHeThong";
            this.menuStripHeThong.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripHeThong.Size = new System.Drawing.Size(1582, 33);
            this.menuStripHeThong.TabIndex = 0;
            this.menuStripHeThong.Text = "menuStrip1";
            // 
            // columnThanhTien
            // 
            this.columnThanhTien.DataPropertyName = "ThanhTien";
            this.columnThanhTien.FillWeight = 90F;
            this.columnThanhTien.HeaderText = "T.tiền";
            this.columnThanhTien.Name = "columnThanhTien";
            this.columnThanhTien.ReadOnly = true;
            this.columnThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnThanhTien.Width = 97;
            // 
            // columnSoLuong
            // 
            this.columnSoLuong.DataPropertyName = "SoLuong";
            this.columnSoLuong.FillWeight = 35F;
            this.columnSoLuong.HeaderText = "SL";
            this.columnSoLuong.Name = "columnSoLuong";
            this.columnSoLuong.ReadOnly = true;
            this.columnSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSoLuong.Width = 35;
            // 
            // columnGia
            // 
            this.columnGia.DataPropertyName = "GiaTien";
            this.columnGia.FillWeight = 80F;
            this.columnGia.HeaderText = "Đơn giá";
            this.columnGia.Name = "columnGia";
            this.columnGia.ReadOnly = true;
            this.columnGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnGia.Width = 90;
            // 
            // columnTen
            // 
            this.columnTen.DataPropertyName = "TenMon";
            this.columnTen.FillWeight = 150F;
            this.columnTen.HeaderText = "Tên";
            this.columnTen.Name = "columnTen";
            this.columnTen.ReadOnly = true;
            this.columnTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnTen.Width = 163;
            // 
            // columnSTT
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnSTT.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnSTT.FillWeight = 35F;
            this.columnSTT.HeaderText = "   ";
            this.columnSTT.Name = "columnSTT";
            this.columnSTT.ReadOnly = true;
            this.columnSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSTT.Width = 35;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.ptbTienThua);
            this.pnMain.Controls.Add(this.ptbTienDua);
            this.pnMain.Controls.Add(this.ptbTongTien);
            this.pnMain.Controls.Add(this.ptbDiscount);
            this.pnMain.Controls.Add(this.pnDropDownMenuAvatar);
            this.pnMain.Controls.Add(this.lbFullName);
            this.pnMain.Controls.Add(this.ptbAvatar);
            this.pnMain.Controls.Add(this.tabDoUong);
            this.pnMain.Controls.Add(this.btnAddBill);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.tbxTienThua);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.tbxTienKhachDua);
            this.pnMain.Controls.Add(this.btnThanhToan);
            this.pnMain.Controls.Add(this.btnHuyBill);
            this.pnMain.Controls.Add(this.cbbGiamGia);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.tbxTongTien);
            this.pnMain.Controls.Add(this.tabControl2);
            this.pnMain.Controls.Add(this.tabControlBan);
            this.pnMain.Controls.Add(this.textBox1);
            this.pnMain.Location = new System.Drawing.Point(12, 32);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1560, 817);
            this.pnMain.TabIndex = 1;
            // 
            // ptbTienThua
            // 
            this.ptbTienThua.Location = new System.Drawing.Point(1158, 691);
            this.ptbTienThua.Name = "ptbTienThua";
            this.ptbTienThua.Size = new System.Drawing.Size(38, 33);
            this.ptbTienThua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTienThua.TabIndex = 40;
            this.ptbTienThua.TabStop = false;
            // 
            // ptbTienDua
            // 
            this.ptbTienDua.Location = new System.Drawing.Point(1158, 640);
            this.ptbTienDua.Name = "ptbTienDua";
            this.ptbTienDua.Size = new System.Drawing.Size(38, 33);
            this.ptbTienDua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTienDua.TabIndex = 39;
            this.ptbTienDua.TabStop = false;
            // 
            // ptbTongTien
            // 
            this.ptbTongTien.Location = new System.Drawing.Point(1158, 591);
            this.ptbTongTien.Name = "ptbTongTien";
            this.ptbTongTien.Size = new System.Drawing.Size(38, 33);
            this.ptbTongTien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTongTien.TabIndex = 38;
            this.ptbTongTien.TabStop = false;
            // 
            // ptbDiscount
            // 
            this.ptbDiscount.Location = new System.Drawing.Point(1158, 544);
            this.ptbDiscount.Name = "ptbDiscount";
            this.ptbDiscount.Size = new System.Drawing.Size(38, 33);
            this.ptbDiscount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDiscount.TabIndex = 37;
            this.ptbDiscount.TabStop = false;
            // 
            // pnDropDownMenuAvatar
            // 
            this.pnDropDownMenuAvatar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnDropDownMenuAvatar.Controls.Add(this.btnChangePass);
            this.pnDropDownMenuAvatar.Controls.Add(this.btnXemHoSo);
            this.pnDropDownMenuAvatar.Location = new System.Drawing.Point(1369, 3);
            this.pnDropDownMenuAvatar.Name = "pnDropDownMenuAvatar";
            this.pnDropDownMenuAvatar.Size = new System.Drawing.Size(134, 137);
            this.pnDropDownMenuAvatar.TabIndex = 36;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(4, 35);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(126, 31);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "Đổi Mật Khẩu";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnXemHoSo
            // 
            this.btnXemHoSo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXemHoSo.FlatAppearance.BorderSize = 0;
            this.btnXemHoSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHoSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHoSo.Location = new System.Drawing.Point(3, 3);
            this.btnXemHoSo.Name = "btnXemHoSo";
            this.btnXemHoSo.Size = new System.Drawing.Size(127, 31);
            this.btnXemHoSo.TabIndex = 0;
            this.btnXemHoSo.Text = "Xem Hồ Sơ";
            this.btnXemHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemHoSo.UseVisualStyleBackColor = true;
            this.btnXemHoSo.Click += new System.EventHandler(this.btnXemHoSo_Click);
            // 
            // lbFullName
            // 
            this.lbFullName.Location = new System.Drawing.Point(1351, 3);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbFullName.Size = new System.Drawing.Size(152, 37);
            this.lbFullName.TabIndex = 35;
            this.lbFullName.Text = "Hello";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(1509, 0);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(42, 42);
            this.ptbAvatar.TabIndex = 34;
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbAvatar_MouseClick);
            // 
            // tabDoUong
            // 
            this.tabDoUong.Location = new System.Drawing.Point(335, 0);
            this.tabDoUong.Name = "tabDoUong";
            this.tabDoUong.SelectedIndex = 0;
            this.tabDoUong.Size = new System.Drawing.Size(781, 716);
            this.tabDoUong.TabIndex = 33;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddBill.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnAddBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBill.Location = new System.Drawing.Point(1118, 491);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnAddBill.Size = new System.Drawing.Size(123, 37);
            this.btnAddBill.TabIndex = 32;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(1218, 699);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tiền thừa :";
            // 
            // tbxTienThua
            // 
            this.tbxTienThua.BackColor = System.Drawing.Color.White;
            this.tbxTienThua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTienThua.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxTienThua.Enabled = false;
            this.tbxTienThua.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbxTienThua.Location = new System.Drawing.Point(1361, 699);
            this.tbxTienThua.Name = "tbxTienThua";
            this.tbxTienThua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTienThua.Size = new System.Drawing.Size(157, 27);
            this.tbxTienThua.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(1218, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tiền khách đưa :";
            // 
            // tbxTienKhachDua
            // 
            this.tbxTienKhachDua.BackColor = System.Drawing.Color.White;
            this.tbxTienKhachDua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTienKhachDua.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxTienKhachDua.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbxTienKhachDua.Location = new System.Drawing.Point(1361, 648);
            this.tbxTienKhachDua.Name = "tbxTienKhachDua";
            this.tbxTienKhachDua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTienKhachDua.Size = new System.Drawing.Size(146, 27);
            this.tbxTienKhachDua.TabIndex = 28;
            this.tbxTienKhachDua.Text = "0";
            this.tbxTienKhachDua.TextChanged += new System.EventHandler(this.tbxTienKhachDua_TextChanged);
            this.tbxTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTienKhachDua_KeyPress_1);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(1144, 760);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(180, 53);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyBill
            // 
            this.btnHuyBill.BackColor = System.Drawing.Color.Tomato;
            this.btnHuyBill.Font = new System.Drawing.Font("Calibri", 16F);
            this.btnHuyBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBill.Location = new System.Drawing.Point(1351, 760);
            this.btnHuyBill.Name = "btnHuyBill";
            this.btnHuyBill.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.btnHuyBill.Size = new System.Drawing.Size(180, 53);
            this.btnHuyBill.TabIndex = 26;
            this.btnHuyBill.Text = "Hủy bill";
            this.btnHuyBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBill.UseVisualStyleBackColor = false;
            this.btnHuyBill.Click += new System.EventHandler(this.btnHuyBill_Click);
            // 
            // cbbGiamGia
            // 
            this.cbbGiamGia.BackColor = System.Drawing.Color.White;
            this.cbbGiamGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGiamGia.Font = new System.Drawing.Font("Calibri", 16F);
            this.cbbGiamGia.FormattingEnabled = true;
            this.cbbGiamGia.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%"});
            this.cbbGiamGia.Location = new System.Drawing.Point(1361, 545);
            this.cbbGiamGia.Name = "cbbGiamGia";
            this.cbbGiamGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbbGiamGia.Size = new System.Drawing.Size(157, 34);
            this.cbbGiamGia.TabIndex = 25;
            this.cbbGiamGia.SelectedIndexChanged += new System.EventHandler(this.cbbGiamGia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(1218, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giảm giá (%) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1217, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tổng tiền :";
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.BackColor = System.Drawing.Color.White;
            this.tbxTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTongTien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxTongTien.Enabled = false;
            this.tbxTongTien.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.tbxTongTien.Location = new System.Drawing.Point(1361, 599);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxTongTien.Size = new System.Drawing.Size(157, 27);
            this.tbxTongTien.TabIndex = 22;
            this.tbxTongTien.Text = "0$";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Font = new System.Drawing.Font("Calibri", 14F);
            this.tabControl2.ItemSize = new System.Drawing.Size(70, 40);
            this.tabControl2.Location = new System.Drawing.Point(1118, 43);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(6, 6);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(440, 442);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBill);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bill";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBill.ColumnHeadersHeight = 40;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.GiaTien,
            this.ThanhTien});
            this.dgvBill.GridColor = System.Drawing.Color.White;
            this.dgvBill.Location = new System.Drawing.Point(6, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.Size = new System.Drawing.Size(423, 383);
            this.dgvBill.TabIndex = 0;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // tabControlBan
            // 
            this.tabControlBan.Controls.Add(this.tabBan);
            this.tabControlBan.Font = new System.Drawing.Font("Calibri", 14F);
            this.tabControlBan.ItemSize = new System.Drawing.Size(70, 40);
            this.tabControlBan.Location = new System.Drawing.Point(2, 0);
            this.tabControlBan.Multiline = true;
            this.tabControlBan.Name = "tabControlBan";
            this.tabControlBan.Padding = new System.Drawing.Point(6, 6);
            this.tabControlBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlBan.SelectedIndex = 0;
            this.tabControlBan.Size = new System.Drawing.Size(327, 817);
            this.tabControlBan.TabIndex = 20;
            // 
            // tabBan
            // 
            this.tabBan.AutoScroll = true;
            this.tabBan.Location = new System.Drawing.Point(4, 44);
            this.tabBan.Name = "tabBan";
            this.tabBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBan.Size = new System.Drawing.Size(319, 769);
            this.tabBan.TabIndex = 0;
            this.tabBan.Text = "Bàn";
            this.tabBan.UseVisualStyleBackColor = true;
            this.tabBan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabBan_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 16F);
            this.textBox1.Location = new System.Drawing.Point(1485, 648);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(33, 27);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "$";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // ctmTabBan
            // 
            this.ctmTabBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.thêmToolStripMenuItem});
            this.ctmTabBan.Name = "ctmCRUDBan";
            this.ctmTabBan.Size = new System.Drawing.Size(114, 48);
            // 
            // tmrDropdownMenu
            // 
            this.tmrDropdownMenu.Tick += new System.EventHandler(this.tmrDropdownMenu_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 856);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStripHeThong);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripHeThong;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripHeThong.ResumeLayout(false);
            this.menuStripHeThong.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTienThua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTienDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscount)).EndInit();
            this.pnDropDownMenuAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabControlBan.ResumeLayout(false);
            this.ctmTabBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuItemThemUser;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaDanhMụcToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmTabBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.TabControl tabDoUong;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTienThua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTienKhachDua;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyBill;
        private System.Windows.Forms.ComboBox cbbGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabControl tabControlBan;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Panel pnDropDownMenuAvatar;
        private System.Windows.Forms.Button btnXemHoSo;
        private System.Windows.Forms.Timer tmrDropdownMenu;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.PictureBox ptbTienThua;
        private System.Windows.Forms.PictureBox ptbTienDua;
        private System.Windows.Forms.PictureBox ptbTongTien;
        private System.Windows.Forms.PictureBox ptbDiscount;
        private System.Windows.Forms.TextBox textBox1;
    }
}

