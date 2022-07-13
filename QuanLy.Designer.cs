
namespace QLKSNew
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.mainContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnQuanlynhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlynhansu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlybangluong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlydichvu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyhethong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyThongke = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlythuephong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTenNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoiMatKhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieude1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer1
            // 
            this.mainContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer1.Location = new System.Drawing.Point(227, 31);
            this.mainContainer1.Name = "mainContainer1";
            this.mainContainer1.Size = new System.Drawing.Size(675, 533);
            this.mainContainer1.TabIndex = 0;
            this.mainContainer1.Click += new System.EventHandler(this.mainContainer1_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlynhanvien,
            this.mnQuanlyhethong,
            this.mnThongtincanhan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(227, 533);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnQuanlynhanvien
            // 
            this.mnQuanlynhanvien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlynhansu,
            this.mnQuanlybangluong,
            this.mnQuanlydichvu});
            this.mnQuanlynhanvien.Expanded = true;
            this.mnQuanlynhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlynhanvien.ImageOptions.Image")));
            this.mnQuanlynhanvien.Name = "mnQuanlynhanvien";
            this.mnQuanlynhanvien.Text = "Quản lý nhân viên";
            // 
            // mnQuanlynhansu
            // 
            this.mnQuanlynhansu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlynhansu.ImageOptions.Image")));
            this.mnQuanlynhansu.Name = "mnQuanlynhansu";
            this.mnQuanlynhansu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlynhansu.Text = "Quản lý nhân sự";
            this.mnQuanlynhansu.Click += new System.EventHandler(this.mnQuanlynhansu_Click);
            // 
            // mnQuanlybangluong
            // 
            this.mnQuanlybangluong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlybangluong.ImageOptions.Image")));
            this.mnQuanlybangluong.Name = "mnQuanlybangluong";
            this.mnQuanlybangluong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlybangluong.Text = "Quản lý bảng lương";
            this.mnQuanlybangluong.Click += new System.EventHandler(this.mnQuanlybangluong_Click);
            // 
            // mnQuanlydichvu
            // 
            this.mnQuanlydichvu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlydichvu.ImageOptions.Image")));
            this.mnQuanlydichvu.Name = "mnQuanlydichvu";
            this.mnQuanlydichvu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlydichvu.Text = "Quản lý dịch vụ";
            this.mnQuanlydichvu.Click += new System.EventHandler(this.mnQuanlydichvu_Click);
            // 
            // mnQuanlyhethong
            // 
            this.mnQuanlyhethong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlyThongke,
            this.mnQuanlythuephong});
            this.mnQuanlyhethong.Expanded = true;
            this.mnQuanlyhethong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlyhethong.ImageOptions.Image")));
            this.mnQuanlyhethong.Name = "mnQuanlyhethong";
            this.mnQuanlyhethong.Text = "Quản lý hệ thống";
            // 
            // mnQuanlyThongke
            // 
            this.mnQuanlyThongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlyThongke.ImageOptions.Image")));
            this.mnQuanlyThongke.Name = "mnQuanlyThongke";
            this.mnQuanlyThongke.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyThongke.Text = "Quản lý thống kê";
            this.mnQuanlyThongke.Click += new System.EventHandler(this.mnQuanlyThongke_Click);
            // 
            // mnQuanlythuephong
            // 
            this.mnQuanlythuephong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlythuephong.ImageOptions.Image")));
            this.mnQuanlythuephong.Name = "mnQuanlythuephong";
            this.mnQuanlythuephong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlythuephong.Text = "Quản lý thuê phòng";
            this.mnQuanlythuephong.Click += new System.EventHandler(this.mnQuanlythuephong_Click);
            // 
            // mnThongtincanhan
            // 
            this.mnThongtincanhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTenNhanVien,
            this.mnDoiMatKhau,
            this.mnDangxuat});
            this.mnThongtincanhan.Expanded = true;
            this.mnThongtincanhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnThongtincanhan.ImageOptions.Image")));
            this.mnThongtincanhan.Name = "mnThongtincanhan";
            this.mnThongtincanhan.Text = "Thông tin cá nhân";
            // 
            // mnTenNhanVien
            // 
            this.mnTenNhanVien.Name = "mnTenNhanVien";
            this.mnTenNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTenNhanVien.Text = "Tên nhân viên";
            this.mnTenNhanVien.Click += new System.EventHandler(this.mnTenNhanVien_Click);
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDoiMatKhau.ImageOptions.Image")));
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnDoiMatKhau.Click += new System.EventHandler(this.mnDoiMatKhau_Click);
            // 
            // mnDangxuat
            // 
            this.mnDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDangxuat.ImageOptions.Image")));
            this.mnDangxuat.Name = "mnDangxuat";
            this.mnDangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDangxuat.Text = "Đăng xuất";
            this.mnDangxuat.Click += new System.EventHandler(this.mnDangxuat_Click_1);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieude1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(902, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieude1);
            // 
            // lblTieude1
            // 
            this.lblTieude1.Caption = "Quản lý";
            this.lblTieude1.Id = 2;
            this.lblTieude1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTieude1.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieude1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieude1.Name = "lblTieude1";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 564);
            this.ControlContainer = this.mainContainer1;
            this.Controls.Add(this.mainContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "QuanLy";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlynhanvien;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlynhansu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlybangluong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlydichvu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyThongke;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlythuephong;
        private DevExpress.XtraBars.BarStaticItem lblTieude1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyhethong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDangxuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTenNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoiMatKhau;
    }
}