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

namespace QLKSNew.UI
{
    public partial class uc_Quanlykhachhang : UserControl
    {
        public uc_Quanlykhachhang()
        {
            InitializeComponent();
        }
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql;
        private void uc_Quanlykhachhang_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadKhachHang(dtgvkhachhang);
            BindingKhachHang(dtgvkhachhang);
        }
        void ThemKhachHang()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try {
                    int id = int.Parse(tbxidkhachhang.Text);
                    string ten = tbxtenkhachhang.Text;
                    DateTime ngaysinh = DateTime.Parse(dtimengaysinh.Text);
                    string gioitinh = cbxgioitinh.Text;
                    string email = tbxemail.Text;
                    string sdt = tbxsodienthoai.Text;
                    string cmnd = tbxcmnd.Text;
                    string quoctich = tbxquoctich.Text;
                    if (db.KhachHangs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("ID khách hàng đã tồn tại!");
                        return;
                    }
                    if (db.KhachHangs.Select(m => m.CMND).Contains(cmnd))
                    {
                        MessageBox.Show("Số CMND đã tồn tại!");
                        return;
                    }
                    if (db.KhachHangs.Select(m => m.Email).Contains(email))
                    {
                        MessageBox.Show("Email đã tồn tại!");
                        return;
                    }
                    if (db.KhachHangs.Select(m => m.SDT).Contains(sdt))
                    {
                        MessageBox.Show("SDT đã tồn tại!");
                        return;
                    }
                    KhachHang p = new KhachHang()
                    {
                        ID = id,
                        Ten = ten,
                        NgaySinh = ngaysinh,
                        GioiTinh = gioitinh,
                        Email = email,
                        SDT = sdt,
                        CMND = cmnd,
                        QuocTich = quoctich

                    };
                    db.KhachHangs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadKhachHang(dtgvkhachhang);
                }
                catch { MessageBox.Show("Vui lòng nhập đúng thông tin!"); }
            }
            BindingKhachHang(dtgvkhachhang);
        }

        void LoadKhachHang(DataGridView dtgvkhachhang)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from p in db.KhachHangs
                             select new
                             {
                                 ID = p.ID,
                                 Tên = p.Ten,
                                 Ngày_Sinh = p.NgaySinh,
                                 Giới_Tính = p.GioiTinh,
                                 Email = p.Email,
                                 SDT = p.SDT,
                                 CMND = p.CMND,
                                 Quốc_Tịch = p.QuocTich
                             };
                dtgvkhachhang.DataSource = source.ToList();
            }
        }
        void BindingKhachHang(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgvkhachhang.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxidkhachhang.DataBindings.Clear();
            tbxidkhachhang.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgvkhachhang.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxtenkhachhang.DataBindings.Clear();
            tbxtenkhachhang.DataBindings.Add(bdTen);
            Binding bdNS = new Binding("Text", dtgvkhachhang.DataSource, "Ngày_Sinh", true, DataSourceUpdateMode.OnPropertyChanged);
            dtimengaysinh.DataBindings.Clear();
            dtimengaysinh.DataBindings.Add(bdNS);
            Binding bdGT = new Binding("Text", dtgvkhachhang.DataSource, "Giới_Tính", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxgioitinh.DataBindings.Clear();
            cbxgioitinh.DataBindings.Add(bdGT);
            Binding bdE = new Binding("Text", dtgvkhachhang.DataSource, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxemail.DataBindings.Clear();
            tbxemail.DataBindings.Add(bdE);
            Binding bdSDT = new Binding("Text", dtgvkhachhang.DataSource, "SDT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxsodienthoai.DataBindings.Clear();
            tbxsodienthoai.DataBindings.Add(bdSDT);
            Binding bdCMND = new Binding("Text", dtgvkhachhang.DataSource, "CMND", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxcmnd.DataBindings.Clear();
            tbxcmnd.DataBindings.Add(bdCMND);
            Binding bdQT = new Binding("Text", dtgvkhachhang.DataSource, "Quốc_Tịch", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxquoctich.DataBindings.Clear();
            tbxquoctich.DataBindings.Add(bdQT);
        }

        void Sua()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidkhachhang.Text);
                    KhachHang kh = db.KhachHangs.Find(id);
                    string ten = tbxtenkhachhang.Text;
                    string gt = cbxgioitinh.Text;
                    string sdt = tbxsodienthoai.Text;
                    DateTime ns = DateTime.Parse(dtimengaysinh.Text);
                    string cmnd = tbxcmnd.Text;
                    string email = tbxemail.Text;
                    string qt = tbxquoctich.Text;

                    kh.Ten = ten;
                    kh.GioiTinh = gt;
                    kh.SDT = sdt;
                    kh.NgaySinh = ns;
                    kh.CMND = cmnd;
                    kh.Email = email;
                    kh.QuocTich = qt;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!");
                    LoadKhachHang(dtgvkhachhang);
                }
                catch { }
            }
            BindingKhachHang(dtgvkhachhang);
        }
        void Xoa()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidkhachhang.Text);
                    db.KhachHangs.Remove(db.KhachHangs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadKhachHang(dtgvkhachhang);
                }
                catch { }
            }
            BindingKhachHang(dtgvkhachhang);
        }

        private void tbxtimkhachhang_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ID as ID,Ten as Tên,NgaySinh as Ngày_Sinh,GioiTinh as Giới_Tính,Email as Email,SDT as SDT,CMND as CMND,QuocTich as Quốc_Tịch FROM dbo.KhachHang WHERE Ten LIKE N'%" + tbxtimkhachhang.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvkhachhang.DataSource = dt;
            dtgvkhachhang.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Sua();
        }
    }
}
