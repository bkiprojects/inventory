﻿namespace BKI_KHO
{
    partial class f604_phieu_xuat_kho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f604_phieu_xuat_kho));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_cmd_delete_detail = new System.Windows.Forms.ToolStripMenuItem();
            this.m_txt_nguoi_thu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_lbl_ten_phieu = new System.Windows.Forms.Label();
            this.m_dat_ngay_lap = new C1.Win.C1Input.C1TextBox();
            this.m_txt_ten_kho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_xem = new SIS.Controls.Button.SiSButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_chon_kho = new SIS.Controls.Button.SiSButton();
            this.m_lab_ngay = new System.Windows.Forms.Label();
            this.m_txt_so_phieu_thu_chi = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_lab_so_phieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_noi_dung = new System.Windows.Forms.TextBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_group_lap_phieu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_tong_tien = new C1.Win.C1Input.C1TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_group_lap_phieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tong_tien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_fg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu";
            // 
            // m_fg
            // 
            this.m_fg.AllowAddNew = true;
            this.m_fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.ContextMenuStrip = this.m_context;
            this.m_fg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(3, 16);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(829, 245);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 0;
            // 
            // m_context
            // 
            this.m_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_cmd_delete_detail});
            this.m_context.Name = "m_context";
            this.m_context.Size = new System.Drawing.Size(95, 26);
            // 
            // m_cmd_delete_detail
            // 
            this.m_cmd_delete_detail.Name = "m_cmd_delete_detail";
            this.m_cmd_delete_detail.Size = new System.Drawing.Size(94, 22);
            this.m_cmd_delete_detail.Text = "Xóa";
            // 
            // m_txt_nguoi_thu
            // 
            this.m_txt_nguoi_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_nguoi_thu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_nguoi_thu.Location = new System.Drawing.Point(107, 137);
            this.m_txt_nguoi_thu.MaxLength = 10;
            this.m_txt_nguoi_thu.Name = "m_txt_nguoi_thu";
            this.m_txt_nguoi_thu.Size = new System.Drawing.Size(167, 20);
            this.m_txt_nguoi_thu.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tên nhân viên";
            // 
            // m_lbl_ten_phieu
            // 
            this.m_lbl_ten_phieu.AutoSize = true;
            this.m_lbl_ten_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_phieu.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_ten_phieu.Location = new System.Drawing.Point(6, 12);
            this.m_lbl_ten_phieu.Name = "m_lbl_ten_phieu";
            this.m_lbl_ten_phieu.Size = new System.Drawing.Size(209, 24);
            this.m_lbl_ten_phieu.TabIndex = 0;
            this.m_lbl_ten_phieu.Text = "LẬP PHIẾU XUẤT KHO";
            // 
            // m_dat_ngay_lap
            // 
            this.m_dat_ngay_lap.EditMask = "##/##/####";
            this.m_dat_ngay_lap.Location = new System.Drawing.Point(389, 48);
            this.m_dat_ngay_lap.Name = "m_dat_ngay_lap";
            this.m_dat_ngay_lap.Size = new System.Drawing.Size(166, 19);
            this.m_dat_ngay_lap.TabIndex = 3;
            this.m_dat_ngay_lap.Tag = null;
            // 
            // m_txt_ten_kho
            // 
            this.m_txt_ten_kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ten_kho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ten_kho.Enabled = false;
            this.m_txt_ten_kho.Location = new System.Drawing.Point(107, 172);
            this.m_txt_ten_kho.MaxLength = 10;
            this.m_txt_ten_kho.Name = "m_txt_ten_kho";
            this.m_txt_ten_kho.Size = new System.Drawing.Size(167, 20);
            this.m_txt_ten_kho.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kho";
            this.toolTip1.SetToolTip(this.label2, "Kho");
            // 
            // m_cmd_xem
            // 
            this.m_cmd_xem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xem.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xem.ImageIndex = 10;
            this.m_cmd_xem.ImageList = this.imageList1;
            this.m_cmd_xem.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xem.Name = "m_cmd_xem";
            this.m_cmd_xem.Size = new System.Drawing.Size(157, 26);
            this.m_cmd_xem.TabIndex = 2;
            this.m_cmd_xem.Text = "Xem danh sách phiếu";
            this.toolTip1.SetToolTip(this.m_cmd_xem, "In phiếu thu / chi cho học viên");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // m_cmd_chon_kho
            // 
            this.m_cmd_chon_kho.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_kho.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_kho.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_kho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_kho.ImageIndex = 14;
            this.m_cmd_chon_kho.ImageList = this.imageList1;
            this.m_cmd_chon_kho.Location = new System.Drawing.Point(280, 132);
            this.m_cmd_chon_kho.Name = "m_cmd_chon_kho";
            this.m_cmd_chon_kho.Size = new System.Drawing.Size(32, 28);
            this.m_cmd_chon_kho.TabIndex = 14;
            this.toolTip1.SetToolTip(this.m_cmd_chon_kho, "Chọn kho");
            // 
            // m_lab_ngay
            // 
            this.m_lab_ngay.AutoSize = true;
            this.m_lab_ngay.Location = new System.Drawing.Point(338, 52);
            this.m_lab_ngay.Name = "m_lab_ngay";
            this.m_lab_ngay.Size = new System.Drawing.Size(49, 13);
            this.m_lab_ngay.TabIndex = 2;
            this.m_lab_ngay.Text = "Ngày lập";
            // 
            // m_txt_so_phieu_thu_chi
            // 
            this.m_txt_so_phieu_thu_chi.BackColor = System.Drawing.SystemColors.Window;
            this.m_txt_so_phieu_thu_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_so_phieu_thu_chi.Location = new System.Drawing.Point(108, 48);
            this.m_txt_so_phieu_thu_chi.MaxLength = 20;
            this.m_txt_so_phieu_thu_chi.Name = "m_txt_so_phieu_thu_chi";
            this.m_txt_so_phieu_thu_chi.Size = new System.Drawing.Size(167, 20);
            this.m_txt_so_phieu_thu_chi.TabIndex = 1;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xem);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 476);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(835, 34);
            this.m_pnl_out_place_dm.TabIndex = 5;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.imageList1;
            this.m_cmd_exit.Location = new System.Drawing.Point(257, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 26);
            this.m_cmd_exit.TabIndex = 6;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 3;
            this.m_cmd_insert.ImageList = this.imageList1;
            this.m_cmd_insert.Location = new System.Drawing.Point(161, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(96, 26);
            this.m_cmd_insert.TabIndex = 5;
            this.m_cmd_insert.Text = "Lập phiếu ";
            this.toolTip1.SetToolTip(this.m_cmd_insert, "Lập phiếu thu / chi cho học viên này");
            // 
            // m_lab_so_phieu
            // 
            this.m_lab_so_phieu.AutoSize = true;
            this.m_lab_so_phieu.Location = new System.Drawing.Point(12, 52);
            this.m_lab_so_phieu.Name = "m_lab_so_phieu";
            this.m_lab_so_phieu.Size = new System.Drawing.Size(65, 13);
            this.m_lab_so_phieu.TabIndex = 0;
            this.m_lab_so_phieu.Text = "Số chứng từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nội dung";
            // 
            // m_txt_noi_dung
            // 
            this.m_txt_noi_dung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_noi_dung.Location = new System.Drawing.Point(107, 87);
            this.m_txt_noi_dung.Multiline = true;
            this.m_txt_noi_dung.Name = "m_txt_noi_dung";
            this.m_txt_noi_dung.Size = new System.Drawing.Size(471, 35);
            this.m_txt_noi_dung.TabIndex = 9;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_group_lap_phieu
            // 
            this.m_group_lap_phieu.Controls.Add(this.m_txt_nguoi_thu);
            this.m_group_lap_phieu.Controls.Add(this.label9);
            this.m_group_lap_phieu.Controls.Add(this.m_lbl_ten_phieu);
            this.m_group_lap_phieu.Controls.Add(this.m_dat_ngay_lap);
            this.m_group_lap_phieu.Controls.Add(this.m_txt_ten_kho);
            this.m_group_lap_phieu.Controls.Add(this.label2);
            this.m_group_lap_phieu.Controls.Add(this.m_cmd_chon_kho);
            this.m_group_lap_phieu.Controls.Add(this.m_lab_ngay);
            this.m_group_lap_phieu.Controls.Add(this.m_txt_so_phieu_thu_chi);
            this.m_group_lap_phieu.Controls.Add(this.m_lab_so_phieu);
            this.m_group_lap_phieu.Controls.Add(this.label4);
            this.m_group_lap_phieu.Controls.Add(this.m_txt_noi_dung);
            this.m_group_lap_phieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_group_lap_phieu.Location = new System.Drawing.Point(0, 0);
            this.m_group_lap_phieu.Name = "m_group_lap_phieu";
            this.m_group_lap_phieu.Size = new System.Drawing.Size(835, 212);
            this.m_group_lap_phieu.TabIndex = 3;
            this.m_group_lap_phieu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "VNĐ";
            // 
            // m_txt_tong_tien
            // 
            this.m_txt_tong_tien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.m_txt_tong_tien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_tong_tien.CustomFormat = "###,###,###,###0";
            this.m_txt_tong_tien.DataType = typeof(decimal);
            this.m_txt_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_tong_tien.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.m_txt_tong_tien.Location = new System.Drawing.Point(572, 8);
            this.m_txt_tong_tien.Name = "m_txt_tong_tien";
            this.m_txt_tong_tien.NullText = "0";
            this.m_txt_tong_tien.Size = new System.Drawing.Size(140, 17);
            this.m_txt_tong_tien.TabIndex = 17;
            this.m_txt_tong_tien.Tag = null;
            this.m_txt_tong_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng tiền nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_txt_tong_tien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 34);
            this.panel1.TabIndex = 15;
            // 
            // f604_phieu_xuat_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_group_lap_phieu);
            this.Name = "f604_phieu_xuat_kho";
            this.Text = "PHIẾU XUẤT KHO";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_context.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_group_lap_phieu.ResumeLayout(false);
            this.m_group_lap_phieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tong_tien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.ContextMenuStrip m_context;
        private System.Windows.Forms.ToolStripMenuItem m_cmd_delete_detail;
        private System.Windows.Forms.TextBox m_txt_nguoi_thu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label m_lbl_ten_phieu;
        private C1.Win.C1Input.C1TextBox m_dat_ngay_lap;
        private System.Windows.Forms.TextBox m_txt_ten_kho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        internal SIS.Controls.Button.SiSButton m_cmd_xem;
        internal System.Windows.Forms.ImageList imageList1;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_kho;
        private System.Windows.Forms.Label m_lab_ngay;
        private System.Windows.Forms.TextBox m_txt_so_phieu_thu_chi;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private System.Windows.Forms.Label m_lab_so_phieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_noi_dung;
        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.GroupBox m_group_lap_phieu;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox m_txt_tong_tien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
    }
}