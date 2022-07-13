using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSNew
{
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection;
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn hủy đăng ký", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxidnhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void idnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ThemTKMK()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    string user = username.Text;
                    string pass = password.Text;
                    string id = tbxidnhanvien.Text;

                    User us = new User()
                    {
                        ID = user,
                        Pass = pass,
                        IDnhanvien = id,
                    };
                    db.Users.Add(us);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                    DangNhap a = new DangNhap();
                    a.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng điền đúng thông tin!");
                }
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                username.Focus();// Đưa trỏ chuột về lại
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                password.Focus();
            }
            else if (idnhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID nhân viên đã được cấp");
                idnhanvien.Focus();
            }
            else
            {
                ThemTKMK();
            }
        }
        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new DangNhap();
            f.Show();
        }
    }
}