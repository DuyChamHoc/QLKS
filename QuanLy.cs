using DevExpress.XtraBars;
using QLKSNew.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKSNew
{
    public partial class QuanLy : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        uc_Quanlynhansu ucQuanlynhansu;
        uc_Quanlybangluong ucQuanlybangluong;
        uc_Quanlydichvu ucQuanlydichvu;
        uc_Khachsan ucKhachsan;
        uc_Doimatkhau2 ucDoimatkhau2;
        uc_TenNhanVien2 ucTenNhanVien2;

        private void QuanLy_Load(object sender, EventArgs e)
        {
            mnTenNhanVien.Text= cons.cons.loginnhanvien.Ten;
            if (ucKhachsan == null)
            {
                ucKhachsan = new uc_Khachsan();
                ucKhachsan.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucKhachsan);
                ucKhachsan.BringToFront();
            }
            else
                ucKhachsan.BringToFront();
        }

        private void mnQuanlynhansu_Click(object sender, EventArgs e)
        {
            if (ucQuanlynhansu == null)
            {
                ucQuanlynhansu = new uc_Quanlynhansu();
                ucQuanlynhansu.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucQuanlynhansu);
                ucQuanlynhansu.BringToFront();
            }
            else
                ucQuanlynhansu.BringToFront();
            lblTieude1.Caption = mnQuanlynhansu.Text;
        }

        private void mnQuanlybangluong_Click(object sender, EventArgs e)
        {
            if (ucQuanlybangluong == null)
            {
                ucQuanlybangluong = new uc_Quanlybangluong();
                ucQuanlybangluong.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucQuanlybangluong);
                ucQuanlybangluong.BringToFront();
            }
            else
                ucQuanlybangluong.BringToFront();
            lblTieude1.Caption = mnQuanlybangluong.Text;
        }

        private void mnQuanlydichvu_Click(object sender, EventArgs e)
        {
            if (ucQuanlydichvu == null)
            {
                ucQuanlydichvu = new uc_Quanlydichvu();
                ucQuanlydichvu.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucQuanlydichvu);
                ucQuanlydichvu.BringToFront();
            }
            else
                ucQuanlydichvu.BringToFront();
            lblTieude1.Caption = mnQuanlydichvu.Text;
        }
        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            cons.cons.loginnhanvien = null;
            this.Close();
        }

        private void mnQuanlythuephong_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyThuePhong f = new QuanLyThuePhong();
            f.Show();
        }

        private void mnQuanlyThongke_Click(object sender, EventArgs e)
        {
            this.Close();
            Thongke f = new Thongke();
            f.Show();
        }
        private void mnDangxuat_Click_1(object sender, EventArgs e)
        {
            cons.cons.loginnhanvien = null;
            this.Close();
            mnTenNhanVien.Text = "";
        }

        private void mnTenNhanVien_Click(object sender, EventArgs e)
        {
            lblTieude1.Caption = "Thông tin nhân viên";
            if (ucTenNhanVien2 == null)
            {
                ucTenNhanVien2 = new uc_TenNhanVien2();
                ucTenNhanVien2.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucTenNhanVien2);
                ucTenNhanVien2.BringToFront();
            }
            else
                ucTenNhanVien2.BringToFront();
        }

        private void mnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (ucDoimatkhau2 == null)
            {
                ucDoimatkhau2 = new uc_Doimatkhau2();
                ucDoimatkhau2.Dock = DockStyle.Fill;
                mainContainer1.Controls.Add(ucDoimatkhau2);
                ucDoimatkhau2.BringToFront();
            }
            else
                ucDoimatkhau2.BringToFront();
            lblTieude1.Caption = mnDoiMatKhau.Text;
        }

        private void mainContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
