using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSNew.UI
{
    public partial class uc_TenNhanVien2 : UserControl
    {
        public uc_TenNhanVien2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        string sql;
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void uc_TenNhanVien2_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            sql = "SELECT NhanVien.Ten,FORMAT (ngaysinh,'dd/MM/yyyy'),gioitinh,diachi,sdt,bophan.ten,chucvu.ten " +
                "FROM NhanVien,ChucVu,BoPhan " +
                "WHERE NhanVien.IDChucVu=ChucVu.ID and NhanVien.IDBoPhan=BoPhan.Ma " +
                "and NhanVien.ID ='" + cons.cons.user.IDnhanvien + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            lblTen.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            lblNgaySinh.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            lblGioitinh.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
            lblDiaChi.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
            lblSdt.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
            lblBophan.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
            lblChucvu.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
            byte[] hinh = cons.cons.loginnhanvien.Hinh;
            if (hinh != null)
            {
                pictureBox1.Image = ByteArrayToImage(hinh);
            }
            else
                pictureBox1.Image = null;
        }
    }
}
