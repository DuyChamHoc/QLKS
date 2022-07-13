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
    public partial class uc_Quanlyloaiphong : UserControl
    {
        public uc_Quanlyloaiphong()
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


        private void uc_Quanlyloaiphong_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadLoaiPhong1(dtgvloaiphong);
            BindingLoaiPhong(dtgvloaiphong);
        }
        void ThemLoaiPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidloaiphong.Text);
                    string ten = tbxloaiphong.Text;
                    decimal gia = decimal.Parse(tbgiaphong.Text);
                    decimal tienphuthu = decimal.Parse(tbxtienphuthu.Text);
                    int sogiuong = Int32.Parse(tbsogiuong.Text);
                    LoaiPhong p = new LoaiPhong()
                    {
                        ID = id,
                        Ten = ten,
                        Gia = gia,
                        TienPhuThu = tienphuthu,
                        SoGiuong = sogiuong
                    };
                    db.LoaiPhongs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Thêm loại phòng thành công!");
                    LoadLoaiPhong1(dtgvloaiphong);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin!");
                }
            }
            BindingLoaiPhong(dtgvloaiphong);
        }
        void XoaLoaiPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidloaiphong.Text);
                    db.LoaiPhongs.Remove(db.LoaiPhongs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Xóa loại phòng thành công!");
                    LoadLoaiPhong1(dtgvloaiphong);
                }
                catch { }
            }
            BindingLoaiPhong(dtgvloaiphong);
        }

        void SuaLoaiPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidloaiphong.Text);
                    string loaiphong = tbxloaiphong.Text;
                    LoaiPhong lphong = db.LoaiPhongs.Find(id);
                    decimal gia = decimal.Parse(tbgiaphong.Text);
                    decimal tienphuthu = decimal.Parse(tbxtienphuthu.Text);
                    int sogiuong = Int32.Parse(tbsogiuong.Text);
                    lphong.ID = id;
                    lphong.Ten = loaiphong;
                    lphong.Gia = gia;
                    lphong.TienPhuThu = tienphuthu;
                    lphong.SoGiuong = sogiuong;
                    db.SaveChanges();
                    MessageBox.Show("Sửa loại phòng thành công!");
                    LoadLoaiPhong1(dtgvloaiphong);
                }
                catch { }
            }
            BindingLoaiPhong(dtgvloaiphong);
        }

        void LoadLoaiPhong1(DataGridView dtgvloaiphong)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from p in db.LoaiPhongs
                             select new
                             {
                                 ID = p.ID,
                                 Loại_Phòng = p.Ten,
                                 Giá = p.Gia,
                                 Tiền_Phụ_Thu = p.TienPhuThu,
                                 Số_Giường = p.SoGiuong
                             };
                dtgvloaiphong.DataSource = source.ToList();
            }
        }

        void BindingLoaiPhong(DataGridView dtgvloaiphong)
        {
            Binding bdID = new Binding("Text", dtgvloaiphong.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxidloaiphong.DataBindings.Clear();
            tbxidloaiphong.DataBindings.Add(bdID);
            Binding bdLoaiPhong = new Binding("Text", dtgvloaiphong.DataSource, "Loại_Phòng", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxloaiphong.DataBindings.Clear();
            tbxloaiphong.DataBindings.Add(bdLoaiPhong);
            Binding bdGia = new Binding("Text", dtgvloaiphong.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            tbgiaphong.DataBindings.Clear();
            tbgiaphong.DataBindings.Add(bdGia);
            Binding bdTienPhuThu = new Binding("Text", dtgvloaiphong.DataSource, "Tiền_Phụ_Thu", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxtienphuthu.DataBindings.Clear();
            tbxtienphuthu.DataBindings.Add(bdTienPhuThu);
            Binding bdSoGiuong = new Binding("Text", dtgvloaiphong.DataSource, "Số_Giường", true, DataSourceUpdateMode.OnPropertyChanged);
            tbsogiuong.DataBindings.Clear();
            tbsogiuong.DataBindings.Add(bdSoGiuong);
        }
        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ID as ID,Ten as Loại_Phòng,Gia as Giá,Tienphuthu as Tiền_Phụ_Thu,Sogiuong as Số_Giường FROM dbo.LoaiPhong WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvloaiphong.DataSource = dt;
            dtgvloaiphong.Refresh();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemLoaiPhong();//
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XoaLoaiPhong();//
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SuaLoaiPhong();//
        }
    }
}
