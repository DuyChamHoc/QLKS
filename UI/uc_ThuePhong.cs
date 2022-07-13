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
    public partial class uc_ThuePhong : UserControl
    {
        public uc_ThuePhong()
        {
            InitializeComponent();
        }
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        string sql;
        private void uc_ThuePhong_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            conn.Open();
            loadthuephong();
            LoadTrangThai(cbxtenphong);
            bindingthuephong();
        }
        void ThuePhong()
        {
            int t = 0;
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    t = 0;
                    int idthuephong = int.Parse(tbxidthuephong.Text);
                    int tenphong = (cbxtenphong.SelectedValue as Phong).ID;
                    int idkhachhang = int.Parse(tbxidkhachhang.Text);
                    DateTime ngaydat = DateTime.Parse(datetimethuephong.Text);
                    DateTime ngaytra = DateTime.Parse(datetimetraphong.Text);
                    BangThuePhong p = new BangThuePhong()
                    {
                        ID = idthuephong,
                        IDphong = tenphong,
                        IDkhachhang = idkhachhang,
                        NgayDat = ngaydat,
                        NgayTra = ngaytra,
                    };
                    if (db.BangThuePhongs.Select(m => m.IDphong).Contains(tenphong))
                    {
                        MessageBox.Show("Tên phòng đã tồn tại!");
                        return;
                    }
                    db.BangThuePhongs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Đặt phòng thành công!");
                    loadthuephong();
                }
                catch { MessageBox.Show("Đặt phòng thất bại!"); t = 1; }
            }
            if (t == 0)
            {
                sql = "UPDATE phong SET trangthai=N'Có Người' WHERE ten ='" + cbxtenphong.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
        void loadthuephong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var soure = from p in db.BangThuePhongs
                            from l in db.Phongs
                            from k in db.KhachHangs
                            where p.IDphong.Equals(l.ID) && p.IDkhachhang.Equals(k.ID)
                            select new
                            {
                                ID = p.ID,
                                Tên_Phòng = l.Ten,
                                ID_Khách_Hàng = p.IDkhachhang,
                                Tên_Khách_Hàng = k.Ten,
                                Ngày_Đặt = p.NgayDat,
                                Ngày_Trả = p.NgayTra
                            };
                dtgvthuephong.DataSource = soure.ToList();
            }
        }
        void bindingthuephong()
        {
            Binding bdID = new Binding("Text", dtgvthuephong.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxidthuephong.DataBindings.Add(bdID);
            Binding bdtenphong = new Binding("Text", dtgvthuephong.DataSource, "Tên_Phòng", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxtenphong.DataBindings.Add(bdtenphong);
            Binding bdidkhachhang = new Binding("Text", dtgvthuephong.DataSource, "ID_Khách_Hàng", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxidkhachhang.DataBindings.Add(bdidkhachhang);
            Binding bdngaydat = new Binding("Text", dtgvthuephong.DataSource, "Ngày_Đặt", true, DataSourceUpdateMode.OnPropertyChanged);
            datetimethuephong.DataBindings.Add(bdngaydat);
            Binding bdngaytra = new Binding("Text", dtgvthuephong.DataSource, "Ngày_Trả", true, DataSourceUpdateMode.OnPropertyChanged);
            datetimetraphong.DataBindings.Add(bdngaytra);
        }
        void LoadTrangThai(ComboBox cb)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                cb.DataSource = db.Phongs.ToList();
                cb.DisplayMember = "Ten";
            }
        }

        private void btndatphong_Click(object sender, EventArgs e)
        {
            ThuePhong();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThuePhong();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThuePhong();//
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            LoadTrangThai(cbxtenphong);
            loadthuephong();
        }
    }
}
