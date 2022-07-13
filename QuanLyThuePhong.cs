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
    public partial class QuanLyThuePhong : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        uc_ThuePhong ucThuePhong;
        uc_Sudungdichvu ucSudungdichvu;
        uc_Traphong ucTraphong;
        uc_Quanlykhachhang ucQuanlykhachhang;
        uc_Quanlyloaiphong ucQuanlyloaiphong;
        uc_Quanlyphong ucQuanlyphong;
        uc_Doimatkhau ucDoimatkhau;
        uc_Tennhanvien ucTennhanvien;
        uc_Khachsan ucKhachsan;
        public QuanLyThuePhong()
        {
            InitializeComponent();
        }
       
        private void mnThuephong_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnThuephong.Text;
            if (ucThuePhong == null)
            {
                ucThuePhong = new uc_ThuePhong();
                ucThuePhong.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThuePhong);
                ucThuePhong.BringToFront();
            }
            else
            {
                ucThuePhong.BringToFront();
            }
        }

        private void mnSudungdichvu_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnSudungdichvu.Text;
            if (ucSudungdichvu == null)
            {
                ucSudungdichvu = new uc_Sudungdichvu();
                ucSudungdichvu.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucSudungdichvu);
                ucSudungdichvu.BringToFront();
            }
            else
            {
                ucSudungdichvu.BringToFront();
            }
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnTraPhong.Text;
            if (ucTraphong == null)
            {
                ucTraphong = new uc_Traphong();
                ucTraphong.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucTraphong);
                ucTraphong.BringToFront();
            }
            else
            {
                ucTraphong.BringToFront();
            }
        }

        private void mnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnQuanLyKhachHang.Text;
            if (ucQuanlykhachhang == null)
            {
                ucQuanlykhachhang = new uc_Quanlykhachhang();
                ucQuanlykhachhang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucQuanlykhachhang);
                ucQuanlykhachhang.BringToFront();
            }
            else
            {
                ucQuanlykhachhang.BringToFront();
            }
        }

        private void QuanLyThuePhong_Load(object sender, EventArgs e)
        {
            mnTennhanvien.Text = cons.cons.loginnhanvien.Ten;
            if (ucKhachsan == null)
            {
                ucKhachsan = new uc_Khachsan();
                ucKhachsan.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucKhachsan);
                ucKhachsan.BringToFront();
            }
            else
            {
                ucKhachsan.BringToFront();
            }
        }

        private void mnQuanlyphong_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnQuanlyphong.Text;
            if (ucQuanlyphong == null)
            {
                ucQuanlyphong = new uc_Quanlyphong();
                ucQuanlyphong.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucQuanlyphong);
                ucQuanlyphong.BringToFront();
            }
            else
            {
                ucQuanlyphong.BringToFront();
            }
        }

        private void mnQuanlyloaiphong_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnQuanlyloaiphong.Text;
            if (ucQuanlyloaiphong == null)
            {
                ucQuanlyloaiphong = new uc_Quanlyloaiphong();
                ucQuanlyloaiphong.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucQuanlyloaiphong);
                ucQuanlyloaiphong.BringToFront();
            }
            else
            {
                ucQuanlyloaiphong.BringToFront();
            }
        }

        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = mnDoimatkhau.Text;
            if (ucDoimatkhau == null)
            {
                ucDoimatkhau = new uc_Doimatkhau();
                ucDoimatkhau.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucDoimatkhau);
                ucDoimatkhau.BringToFront();
            }
            else
            {
                ucDoimatkhau.BringToFront();
            }
        }

        private void mndangxuat_Click(object sender, EventArgs e)
        {
            cons.cons.loginnhanvien = null;
            this.Close();
            if ((int)cons.Roll.QuanLy == cons.cons.a)
            {
                DangNhap f = new DangNhap();
                f.Show();
            }  

        }

        private void mnTennhanvien_Click(object sender, EventArgs e)
        {
            lblTieuDe.Caption = "Thông tin nhân viên";
            if (ucTennhanvien == null)
            {
                ucTennhanvien = new uc_Tennhanvien();
                ucTennhanvien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucTennhanvien);
                ucTennhanvien.BringToFront();
            }
            else
            {
                ucTennhanvien.BringToFront();
            }
        }

        private void QuanLyThuePhong_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void mainContainer_Click(object sender, EventArgs e)
        {

        }
    }
}
