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
    public partial class uc_Quanlythu : UserControl
    {
        public uc_Quanlythu()
        {
            InitializeComponent();
        }
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string sql;
        private void uc_Quanlythu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            LoadBaoCao();
        }
        void LoadBaoCao()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from bc in db.HoaDonThus
                             from kh in db.KhachHangs
                             from p in db.Phongs
                             where bc.IDphong.Equals(p.ID) && bc.IDkhachhang.Equals(kh.ID)
                             select new
                             {
                                 ID = kh.ID,
                                 Tên = kh.Ten,
                                 Phòng = p.Ten,
                                 Ngày_Đặt = bc.NgayDat,
                                 Ngày_Trả = bc.NgayTra,
                                 Tiền_Phòng = bc.TienPhong,
                                 Tiền_DV = bc.TienDichVu,
                                 Phương_Thức_Thanh_Toán = bc.phuongthuctt,
                                 Tổng = bc.TongTien
                             };
                dtgvthongke.DataSource = source.ToList();
            }
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            RpThu rp = new RpThu();
            rp.Show();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT KhachHang.ID as ID,KhachHang.Ten as Tên,Phong.Ten as Phòng,NgayDat as Ngày_Đặt,NgayTra as Ngày_Trả,tienphong as Tiền_Phòng,tiendichvu as Tiền_DV,phuongthuctt as Phương_Thức_Thanh_Toán,tongtien as Tổng"
    + "                 FROM KhachHang, HoaDonThu, Phong"
    + "                 WHERE hoadonthu.idkhachhang = khachhang.id and hoadonthu.idphong = phong.id and ngaydat>='" + DateTime.Parse(timedat.Text) + "' and ngaytra <='" + DateTime.Parse(timetra.Text) + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                dtgvthongke.DataSource = dt;
                dtgvthongke.Refresh();
            }
            catch { }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT KhachHang.ID as ID,KhachHang.Ten as Tên,Phong.Ten as Phòng,NgayDat as Ngày_Đặt,NgayTra as Ngày_Trả,tienphong as Tiền_Phòng,tiendichvu as Tiền_DV,phuongthuctt as Phương_Thức_Thanh_Toán,tongtien as Tổng"
    + "                 FROM KhachHang, HoaDonThu, Phong"
    + "                 WHERE hoadonthu.idkhachhang = khachhang.id and hoadonthu.idphong = phong.id and ngaydat>='" + DateTime.Parse(timedat.Text) + "' and ngaytra <='" + DateTime.Parse(timetra.Text) + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                dtgvthongke.DataSource = dt;
                dtgvthongke.Refresh();
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            RpThu rp = new RpThu();
            rp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
