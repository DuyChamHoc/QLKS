
namespace QLKSNew
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.mainContainer2 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnQuanlythuchi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQuanlythu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnThongtincanhan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnTennhanvien1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDoimatkhau1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieude2 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer2
            // 
            this.mainContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer2.Location = new System.Drawing.Point(271, 39);
            this.mainContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainContainer2.Name = "mainContainer2";
            this.mainContainer2.Size = new System.Drawing.Size(700, 606);
            this.mainContainer2.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlythuchi,
            this.mnThongtincanhan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(271, 606);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnQuanlythuchi
            // 
            this.mnQuanlythuchi.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQuanlythu});
            this.mnQuanlythuchi.Expanded = true;
            this.mnQuanlythuchi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlythuchi.ImageOptions.Image")));
            this.mnQuanlythuchi.Name = "mnQuanlythuchi";
            this.mnQuanlythuchi.Text = "Quản lý thu chi";
            // 
            // mnQuanlythu
            // 
            this.mnQuanlythu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQuanlythu.ImageOptions.Image")));
            this.mnQuanlythu.Name = "mnQuanlythu";
            this.mnQuanlythu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQuanlythu.Text = "Quản lý doanh thu";
            this.mnQuanlythu.Click += new System.EventHandler(this.mnQuanlythu_Click);
            // 
            // mnThongtincanhan
            // 
            this.mnThongtincanhan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnTennhanvien1,
            this.mnDoimatkhau1,
            this.mnDangxuat});
            this.mnThongtincanhan.Expanded = true;
            this.mnThongtincanhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnThongtincanhan.ImageOptions.Image")));
            this.mnThongtincanhan.Name = "mnThongtincanhan";
            this.mnThongtincanhan.Text = "Thông tin cá nhân";
            // 
            // mnTennhanvien1
            // 
            this.mnTennhanvien1.Name = "mnTennhanvien1";
            this.mnTennhanvien1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnTennhanvien1.Text = "Tên nhân viên";
            this.mnTennhanvien1.Click += new System.EventHandler(this.mnTennhanvien_Click);
            // 
            // mnDoimatkhau1
            // 
            this.mnDoimatkhau1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDoimatkhau1.ImageOptions.Image")));
            this.mnDoimatkhau1.Name = "mnDoimatkhau1";
            this.mnDoimatkhau1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDoimatkhau1.Text = "Đổi mật khẩu";
            this.mnDoimatkhau1.Click += new System.EventHandler(this.mnDoimatkhau1_Click);
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
            this.lblTieude2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(971, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieude2);
            // 
            // lblTieude2
            // 
            this.lblTieude2.Caption = "Quản lý thống kê";
            this.lblTieude2.Id = 0;
            this.lblTieude2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTieude2.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieude2.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieude2.Name = "lblTieude2";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 645);
            this.ControlContainer = this.mainContainer2;
            this.Controls.Add(this.mainContainer2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Thongke";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Thongke_FormClosed);
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlythuchi;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQuanlythu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnThongtincanhan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnTennhanvien1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDoimatkhau1;
        private DevExpress.XtraBars.BarStaticItem lblTieude2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDangxuat;
    }
}