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
using System.IO;

namespace QLKSNew.UI
{
    public partial class uc_Quanlynhansu : UserControl
    {
        public uc_Quanlynhansu()
        {
            InitializeComponent();
        }
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        SqlCommand cmd;
        string sql;
        static int s = 0;
        public void uc_Quanlynhansu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            LoadNhanSu(dtgvns);
            BindingNhanSu(dtgvns);
            cv(cbxcv);
            bp(cbxbp);
        }
        void LoadNhanSu(DataGridView dtgv)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from ns in db.NhanViens
                             from cv in db.ChucVus
                             from bp in db.BoPhans
                             where ns.IDchucvu.Equals(cv.ID) && ns.IDbophan.Equals(bp.Ma)
                             select new
                             {
                                 ID = ns.ID,
                                 Tên = ns.Ten,
                                 Hinh =ns.Hinh,
                                 Ngày_Sinh = ns.NgaySinh,
                                 Giới_Tính = ns.GioiTinh,
                                 Địa_Chỉ = ns.DiaChi,
                                 Số_Điện_Thoại = ns.SDT,
                                 Chức_Vụ = cv.Ten,
                                 Bộ_Phận = bp.Ten
                             };
                dtgv.DataSource = source.ToList();
            }
        }
        private void dtgvns_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (txbtkten.Text == ""&&s==0)
            {
                int r = dtgvns.CurrentCell.RowIndex;
                byte[] b = (byte[])dtgvns.Rows[r].Cells[2].Value;
                pictureBox1.Image = ByteArrayToImage(b);
            }
            else
            {
                if (txbtkten.Text != "")
                {
                    int r = dtgvns.CurrentCell.RowIndex;
                    if (dtgvns.Rows[r].Cells[1].Value.ToString() != "")
                    {
                        byte[] b = (byte[])dtgvns.Rows[r].Cells[1].Value;
                        pictureBox1.Image = ByteArrayToImage(b);
                    }
                    else
                        pictureBox1.Image = null;
                    s++;
                }
                else
                { if (txbtkten.Text == "" && s != 0)
                    {
                        int r = dtgvns.CurrentCell.RowIndex;
                        if (dtgvns.Rows[r].Cells[1].Value.ToString() != "")
                        {
                            byte[] b = (byte[])dtgvns.Rows[r].Cells[1].Value;
                            pictureBox1.Image = ByteArrayToImage(b);
                        }
                        else
                            pictureBox1.Image = null;
                    } 
                }    
            }
        }
        void BindingNhanSu(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txbid.DataBindings.Clear();
            txbid.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            txbten.DataBindings.Clear();
            txbten.DataBindings.Add(bdTen);
            Binding bdNS = new Binding("Text", dtgv.DataSource, "Ngày_Sinh", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpns.DataBindings.Clear();
            dtpns.DataBindings.Add(bdNS);
            Binding bdGT = new Binding("Text", dtgv.DataSource, "Giới_Tính", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxgt.DataBindings.Clear();
            cbxgt.DataBindings.Add(bdGT);
            Binding bdDC = new Binding("Text", dtgv.DataSource, "Địa_Chỉ", true, DataSourceUpdateMode.OnPropertyChanged);
            txbdc.DataBindings.Clear();
            txbdc.DataBindings.Add(bdDC);
            Binding bdSDT = new Binding("Text", dtgv.DataSource, "Số_Điện_Thoại", true, DataSourceUpdateMode.OnPropertyChanged);
            txbsdt.DataBindings.Clear();
            txbsdt.DataBindings.Add(bdSDT);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Sua();
        }
        void Sua()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    string id = txbid.Text;
                    NhanVien nv = db.NhanViens.Find(id);
                    string ten = txbten.Text;
                    System.DateTime ns = System.DateTime.Parse(dtpns.Text);
                    string gt = cbxgt.Text;
                    string dc = txbdc.Text;
                    string sdt = txbsdt.Text;
                    nv.Ten = ten;
                    nv.NgaySinh = ns;
                    nv.GioiTinh = gt;
                    nv.DiaChi = dc;
                    nv.SDT = sdt;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                    LoadNhanSu(dtgvns);
                }
                catch { }
            }
            BindingNhanSu(dtgvns);
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
        void Xoa()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    string id = txbid.Text;
                    db.BangLuongs.Remove(db.BangLuongs.Find(id));
                    db.Users.Remove(db.Users.Find(id));
                    db.NhanViens.Remove(db.NhanViens.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadNhanSu(dtgvns);
                }
                catch { }
            }
            BindingNhanSu(dtgvns);
        }
        void cv(ComboBox cb)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                cb.DataSource = db.ChucVus.ToList();
                cb.DisplayMember = "Ten";
            }
        }
        void bp(ComboBox cb)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                cb.DataSource = db.BoPhans.ToList();
                cb.DisplayMember = "Ten";
            }
        }
        private void txbtkten_TextChanged_1(object sender, EventArgs e)
        {
            s++;
            sql = "SELECT nhanvien.id as ID,nhanvien.hinh as Hình,nhanvien.ten as Tên,ngaysinh as Ngày_Sinh,gioitinh as Giới_Tính,diachi as Địa_Chỉ,sdt as SDT,chucvu.ten as Chức_Vụ,bophan.ten as Bộ_Phận FROM dbo.NhanVien,dbo.ChucVu,dbo.BoPhan WHERE Nhanvien.idchucvu =chucvu.id and nhanvien.idbophan = bophan.ma and nhanvien.Ten LIKE N'%" + txbtkten.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvns.DataSource = dt;
            dtgvns.Refresh();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            Sua();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }    
        }
        [Obsolete]
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pictureBox1.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update NhanVien set hinh = (@Hinh) where id='" + txbid.Text + "'", conn);
                cmd.Parameters.Add("@Hinh", b);
                cmd.ExecuteNonQuery();
                LoadNhanSu(dtgvns);
                BindingNhanSu(dtgvns);
                cv(cbxcv);
                bp(cbxbp);
                conn.Close();
            }
            catch { }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] b)
        {
            if (b != null)  
            {
                MemoryStream m = new MemoryStream(b);
                return Image.FromStream(m);
            }
            return null;
        }

        private void dtgvns_SelectionChanged_1(object sender, EventArgs e)
        {
            if (cbxcv.DataSource == null || dtgvns.SelectedCells.Count == 0)
            {
                return;
            }
            string loai = dtgvns.SelectedCells[0].OwningRow.Cells["Chức_Vụ"].Value.ToString();
            int index = 0;
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                index = db.ChucVus.Select(p => p.Ten).ToList().IndexOf(loai);
            }
            cbxcv.SelectedIndex = index;

            if (cbxbp.DataSource == null || dtgvns.SelectedCells.Count == 0)
            {
                return;
            }
            string loai1 = dtgvns.SelectedCells[0].OwningRow.Cells["Bộ_Phận"].Value.ToString();
            int index1 = 0;
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                index1 = db.BoPhans.Select(p => p.Ten).ToList().IndexOf(loai1);
            }
            cbxbp.SelectedIndex = index1;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pictureBox1.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update NhanVien set hinh = (@Hinh) where id='" + txbid.Text + "'", conn);
                cmd.Parameters.Add("@Hinh", b);
                cmd.ExecuteNonQuery();
                LoadNhanSu(dtgvns);
                BindingNhanSu(dtgvns);
                cv(cbxcv);
                bp(cbxbp);
                conn.Close();
            }
            catch { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sua();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pictureBox1.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update NhanVien set hinh = (@Hinh) where id='" + txbid.Text + "'", conn);
                cmd.Parameters.Add("@Hinh", b);
                cmd.ExecuteNonQuery();
                LoadNhanSu(dtgvns);
                BindingNhanSu(dtgvns);
                cv(cbxcv);
                bp(cbxbp);
                conn.Close();
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Xoa();
        }
    }
}
