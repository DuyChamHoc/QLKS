
namespace QLKSNew
{
    partial class QuanLyThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuePhong));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnQuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanLyThuePhong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThuephong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnSudungdichvu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTraPhong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanLyKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyphong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlyloaiphong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTennhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoimatkhau = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mndangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(232, 31);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(765, 478);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanLy,
            this.mnThongtincanhan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(232, 478);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnQuanLy
            // 
            this.mnQuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanLyThuePhong,
            this.mnQuanLyKhachHang,
            this.mnQuanlyphong,
            this.mnQuanlyloaiphong});
            this.mnQuanLy.Expanded = true;
            this.mnQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLy.ImageOptions.Image")));
            this.mnQuanLy.Name = "mnQuanLy";
            this.mnQuanLy.Text = "Quản lý";
            // 
            // mnQuanLyThuePhong
            // 
            this.mnQuanLyThuePhong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnThuephong,
            this.mnSudungdichvu,
            this.mnTraPhong});
            this.mnQuanLyThuePhong.Expanded = true;
            this.mnQuanLyThuePhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyThuePhong.ImageOptions.Image")));
            this.mnQuanLyThuePhong.Name = "mnQuanLyThuePhong";
            this.mnQuanLyThuePhong.Text = "Quản lý thuê phòng";
            // 
            // mnThuephong
            // 
            this.mnThuephong.Name = "mnThuephong";
            this.mnThuephong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnThuephong.Text = "Thuê phòng";
            this.mnThuephong.Click += new System.EventHandler(this.mnThuephong_Click);
            // 
            // mnSudungdichvu
            // 
            this.mnSudungdichvu.Name = "mnSudungdichvu";
            this.mnSudungdichvu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnSudungdichvu.Text = "Sử dụng dịch vụ";
            this.mnSudungdichvu.Click += new System.EventHandler(this.mnSudungdichvu_Click);
            // 
            // mnTraPhong
            // 
            this.mnTraPhong.Name = "mnTraPhong";
            this.mnTraPhong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTraPhong.Text = "Trả phòng";
            this.mnTraPhong.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // mnQuanLyKhachHang
            // 
            this.mnQuanLyKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanLyKhachHang.ImageOptions.Image")));
            this.mnQuanLyKhachHang.Name = "mnQuanLyKhachHang";
            this.mnQuanLyKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.mnQuanLyKhachHang.Click += new System.EventHandler(this.mnQuanLyKhachHang_Click);
            // 
            // mnQuanlyphong
            // 
            this.mnQuanlyphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlyphong.ImageOptions.Image")));
            this.mnQuanlyphong.Name = "mnQuanlyphong";
            this.mnQuanlyphong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyphong.Text = "Quản lý phòng";
            this.mnQuanlyphong.Click += new System.EventHandler(this.mnQuanlyphong_Click);
            // 
            // mnQuanlyloaiphong
            // 
            this.mnQuanlyloaiphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlyloaiphong.ImageOptions.Image")));
            this.mnQuanlyloaiphong.Name = "mnQuanlyloaiphong";
            this.mnQuanlyloaiphong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlyloaiphong.Text = "Quản lý loại phòng";
            this.mnQuanlyloaiphong.Click += new System.EventHandler(this.mnQuanlyloaiphong_Click);
            // 
            // mnThongtincanhan
            // 
            this.mnThongtincanhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTennhanvien,
            this.mnDoimatkhau,
            this.mndangxuat});
            this.mnThongtincanhan.Expanded = true;
            this.mnThongtincanhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnThongtincanhan.ImageOptions.Image")));
            this.mnThongtincanhan.Name = "mnThongtincanhan";
            this.mnThongtincanhan.Text = "Thông tin cá nhân";
            // 
            // mnTennhanvien
            // 
            this.mnTennhanvien.Name = "mnTennhanvien";
            this.mnTennhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTennhanvien.Text = "Tên nhân viên";
            this.mnTennhanvien.Click += new System.EventHandler(this.mnTennhanvien_Click);
            // 
            // mnDoimatkhau
            // 
            this.mnDoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDoimatkhau.ImageOptions.Image")));
            this.mnDoimatkhau.Name = "mnDoimatkhau";
            this.mnDoimatkhau.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDoimatkhau.Text = "Đổi mật khẩu";
            this.mnDoimatkhau.Click += new System.EventHandler(this.mnDoimatkhau_Click);
            // 
            // mndangxuat
            // 
            this.mndangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mndangxuat.ImageOptions.Image")));
            this.mndangxuat.Name = "mndangxuat";
            this.mndangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mndangxuat.Text = "Đăng xuất";
            this.mndangxuat.Click += new System.EventHandler(this.mndangxuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(997, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Caption = "Quản lý thuê phòng";
            this.lblTieuDe.Id = 0;
            this.lblTieuDe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTieuDe.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // QuanLyThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 509);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyThuePhong";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuê phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyThuePhong_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanLy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanLyThuePhong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThuephong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnSudungdichvu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTraPhong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanLyKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mndangxuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyphong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlyloaiphong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTennhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoimatkhau;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
    }
}