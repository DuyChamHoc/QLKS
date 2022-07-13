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
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sparklineEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {

        }

        private void sparklineEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Form f = nextForm(username.Text, password.Text);
            if (f == null)
            {
                return;
            }
            else
            {
                f.FormClosed += F_FormClosed;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                this.Hide();
                cleartextbox();
            }
        }
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void cleartextbox()
        {
            username.Clear();
            password.Clear();
        }
        Form nextForm(string id, string pass)
        {
            Form f = new Form();
            int roll = (int)cons.Roll.TiepTan;
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var t = db.Users.Where(p => p.ID.Equals(id) && p.Pass.Equals(pass));
                User u = t.Count() == 1 ? t.Single() : null;
                if (u != null)
                {
                    NhanVien nv = db.NhanViens.Where(p => u.IDnhanvien.Equals(p.ID)).Single();
                    roll = (int)nv.ChucVu.Roll;
                    cons.cons.loginnhanvien = nv;
                    cons.cons.user = u;
                    cons.cons.a = roll;
                    cons.cons.bophan = nv.BoPhan.Ten;
                    cons.cons.chucvu = nv.ChucVu.Ten;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                    return null;
                }
            }
            switch (roll)
            {
                case (int)cons.Roll.TiepTan:
                    {
                        f = new QuanLyThuePhong();
                        break;
                    }
                case (int)cons.Roll.QuanLy:
                    {
                        f = new QuanLy();
                        break;
                    }
                case (int)cons.Roll.KeToan:
                    {
                        f = new Thongke();
                        break;
                    }
            }
            return f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text=="USERNAME")
            {
                username.Text = "";
                username.ForeColor = Color.LightGray;
            }    
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
                username.ForeColor = Color.DimGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text=="PASSWORD")
            {
                password.Text = "";
                password.ForeColor = Color.LightGray;
                password.UseSystemPasswordChar = true;
            }    
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if(password.Text=="")
            {
                password.Text = "PASSWORD";
                password.ForeColor = Color.DimGray;
                password.UseSystemPasswordChar = false;
            }    
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            TTDangKy f = new TTDangKy();
            f.Show();
            this.Hide();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* DialogResult ret = MessageBox.Show("" +
                 "Bạn có chắc chắn muốn thoát không?",
                 "Hỏi thoát",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
             if (ret == DialogResult.Yes)
             {
                 e.Cancel = false;
             }
             else
             {
                 e.Cancel = true;
             }*/
            Application.Exit();
        }
    }
}
