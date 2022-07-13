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
    public partial class uc_Quanlydichvu : UserControl
    {
        public uc_Quanlydichvu()
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
        private void uc_Quanlydichvu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadDichVu(dtgvdv);
            BindingDichVu(dtgvdv);
        }
        void LoadDichVu(DataGridView dtgv)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from dv in db.DichVus
                             select new
                             {
                                 Mã_Dịch_Vụ = dv.ID,
                                 Tên_Dịch_Vụ = dv.Ten,
                                 Giá = dv.Gia
                             };
                dtgv.DataSource = source.ToList();
            }
        }
        void BindingDichVu(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "Mã_Dịch_Vụ", true, DataSourceUpdateMode.OnPropertyChanged);
            txbiddv.DataBindings.Clear();
            txbiddv.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Tên_Dịch_Vụ", true, DataSourceUpdateMode.OnPropertyChanged);
            txbtendv.DataBindings.Clear();
            txbtendv.DataBindings.Add(bdTen);
            Binding bdGia = new Binding("Text", dtgv.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            txbgiagv.DataBindings.Clear();
            txbgiagv.DataBindings.Add(bdGia);

        }
        void ThemDV()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try {
                    int id = int.Parse(txbiddv.Text);
                    string ten = txbtendv.Text;
                    if (db.DichVus.Select(m => m.Ten).Contains(ten))
                    {
                        MessageBox.Show("Dịch Vụ Này Đã Tồn Tại!");
                        return;
                    }
                    string tendv = txbtendv.Text;
                    decimal giadv = decimal.Parse(txbgiagv.Text);

                    DichVu p = new DichVu()
                    {
                        ID = id,
                        Ten = tendv,
                        Gia = giadv
                    };
                    db.DichVus.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    LoadDichVu(dtgvdv);
                }
                catch { MessageBox.Show("Vui lòng nhập đúng thông tin!"); }
            }
            BindingDichVu(dtgvdv);
        }
        void SuaDV()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(txbiddv.Text);
                    DichVu dv = db.DichVus.Find(id);
                    string tendv = txbtendv.Text;
                    decimal giadv = decimal.Parse(txbgiagv.Text);
                    dv.ID = id;
                    dv.Ten = tendv;
                    dv.Gia = giadv;
                    db.SaveChanges();
                    MessageBox.Show("Sửa dịch vụ thành công!");
                    LoadDichVu(dtgvdv);
                }
                catch { }
            }
            BindingDichVu(dtgvdv);
        }


        void XoaDV()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(txbiddv.Text);
                    db.DichVus.Remove(db.DichVus.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Xóa dịch vụ thành công!");
                    LoadDichVu(dtgvdv);
                }
                catch { }
            }
            BindingDichVu(dtgvdv);
        }


        private void txbtimkiem_TextChanged_1(object sender, EventArgs e)
        {
            sql = "SELECT ID as Mã_Dịch_Vụ,Ten as Tên_Dịch_Vụ,Gia as Giá FROM dbo.dichvu WHERE Ten LIKE N'%" + txbtimkiem.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvdv.DataSource = dt;
            dtgvdv.Refresh();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemDV();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XoaDV();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SuaDV();
        }
    }
}
