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
    public partial class TTDangKy : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection;
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public TTDangKy()
        {
            InitializeComponent();
        }
        private void TTDangKy_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
        }

        private void TTDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new DangNhap();
            f.Show();
        }
        void ThemTTNV()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                string id = idnhanvien.Text;
                string name = Ten.Text;
                System.DateTime time = System.DateTime.Parse(NgaySinh.Text);
                string address = DiaChi.Text;
                string phone = SDT.Text;
                int idcv = 1, idbp = 1;
                if (cmbidcv.Text == "Tiếp Tân") idcv = 1;
                else if (cmbidcv.Text == "Quản Lý") idcv = 2;
                else if (cmbidcv.Text == "Kế Toán") idcv = 3;
                if (cmbidbp.Text == "Chăm Sóc Khách Hàng") idbp = 1;
                else if (cmbidbp.Text == "Nhân Sự") idbp = 2;
                string sex = GioiTinh.Text;
                var t = db.NhanViens.Where(p => p.ID.Equals(id));
                NhanVien u = t.Count() == 1 ? t.Single() : null;
                if (u != null)
                {
                    MessageBox.Show("ID nhân viên đã tồn tại!");
                }
                else
                {
                    NhanVien nv = new NhanVien()
                    {
                        ID = id,
                        Ten = name,
                        NgaySinh = time,
                        DiaChi = address,
                        GioiTinh = sex,
                        SDT = phone,
                        IDchucvu = idcv,
                        IDbophan = idbp
                    };
                    db.NhanViens.Add(nv);
                    DialogResult dialogResult = MessageBox.Show("Đăng ký thành công!");
                    decimal luong = 0;
                    if (idcv == 1) luong = 2000000;
                    else if (idcv == 2) luong = 3500000;
                    else if (idcv == 3) luong = 2500000;
                    BangLuong bl = new BangLuong()
                    {
                        IDnhanvien = id,
                        Ngay = 0,
                        LuongCB = luong,
                        Trocap = 0,

                    };
                    db.BangLuongs.Add(bl);
                    db.SaveChanges();
                    DangKy f = new DangKy();
                    f.Show();
                    this.Hide();
                }
            }
        }
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (Ten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");
                Ten.Focus();
            }
            else if (GioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!");
                GioiTinh.Focus();
            }
            else if (idnhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ID nhân viên!");
                idnhanvien.Focus();
            }
            else if (NgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh!");
                NgaySinh.Focus();
            }
            else ThemTTNV();
        }
    }
}