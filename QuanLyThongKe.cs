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
    public partial class Thongke : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Thongke()
        {
            InitializeComponent();
        }
        uc_Quanlythu ucQuanlythu;
        uc_Tennhanvien1 ucTennhanvien1;
        uc_Doimatkhau1 ucDoimatkhau1;
        uc_Khachsan ucKhachsan;
        private void mnQuanlythu_Click(object sender, EventArgs e)
        {
            if (ucQuanlythu == null)
            {
                ucQuanlythu = new uc_Quanlythu();
                ucQuanlythu.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucQuanlythu);
                ucQuanlythu.BringToFront();
            }
            else
                ucQuanlythu.BringToFront();
            lblTieude2.Caption = mnQuanlythu.Text;
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            mnTennhanvien1.Text = cons.cons.loginnhanvien.Ten;
            if (ucKhachsan == null)
            {
                ucKhachsan = new uc_Khachsan();
                ucKhachsan.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucKhachsan);
                ucKhachsan.BringToFront();
            }
            else
                ucKhachsan.BringToFront();
        }

        private void mnQuanlychi_Click(object sender, EventArgs e)
        {
           
        }

        private void mnTennhanvien_Click(object sender, EventArgs e)
        {
            if (ucTennhanvien1 == null)
            {
                ucTennhanvien1 = new uc_Tennhanvien1();
                ucTennhanvien1.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucTennhanvien1);
                ucTennhanvien1.BringToFront();
            }
            else
                ucTennhanvien1.BringToFront();
            lblTieude2.Caption = mnTennhanvien1.Text;
        }

        private void mnDoimatkhau1_Click(object sender, EventArgs e)
        {
            if (ucDoimatkhau1 == null)
            {
                ucDoimatkhau1 = new uc_Doimatkhau1();
                ucDoimatkhau1.Dock = DockStyle.Fill;
                mainContainer2.Controls.Add(ucDoimatkhau1);
                ucDoimatkhau1.BringToFront();
            }
            else
                ucDoimatkhau1.BringToFront();
            lblTieude2.Caption = mnDoimatkhau1.Text;
        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            
        }

        private void mnDangxuat_Click_1(object sender, EventArgs e)
        {
            cons.cons.loginnhanvien = null;
            this.Close();
            if((int)cons.Roll.QuanLy==cons.cons.a)
            {
                DangNhap f = new DangNhap();
                f.Show();
            }    
        }
        private void Thongke_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
