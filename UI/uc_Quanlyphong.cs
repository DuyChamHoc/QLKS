using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSNew.UI
{
    public partial class uc_Quanlyphong : UserControl
    {
        public uc_Quanlyphong()
        {
            InitializeComponent();
        }

        private void uc_Quanlyphong_Load(object sender, EventArgs e)
        {
            LoadPhong(dtgvPhong);
            BindingPhong(dtgvPhong);
            LoadLoaiPhong(cbxloaiphong);
        }
        void LoadLoaiPhong(ComboBox cb)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                cb.DataSource = db.LoaiPhongs.ToList();
                cb.DisplayMember = "Ten";
            }
        }
        void BindingPhong(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxidphong.DataBindings.Clear();
            tbxidphong.DataBindings.Add(bdID);
            Binding bdTenPhong = new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxtenphong.DataBindings.Clear();
            tbxtenphong.DataBindings.Add(bdTenPhong);
            Binding bdGia = new Binding("Text", dtgv.DataSource, "Giá", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxgiaphong.DataBindings.Clear();
            tbxgiaphong.DataBindings.Add(bdGia);
            Binding bdSoGiuong = new Binding("Text", dtgv.DataSource, "Giường", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxsogiuong.DataBindings.Clear();
            tbxsogiuong.DataBindings.Add(bdSoGiuong);
        }
        void ThemPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidphong.Text);
                    string ten = tbxtenphong.Text;
                    if (db.Phongs.Select(m => m.Ten).Contains(ten))
                    {
                        MessageBox.Show("Tên phòng đã tồn tại!");
                        return;
                    }
                    if (db.Phongs.Select(m => m.ID).Contains(id))
                    {
                        MessageBox.Show("ID phòng đã tồn tại!");
                        return;
                    }
                    int loai = (cbxloaiphong.SelectedValue as LoaiPhong).ID;

                    Phong p = new Phong()
                    {
                        ID = id,
                        Ten = ten,
                        IDloai = loai,
                    };

                    db.Phongs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Thêm phòng thành công!");
                    LoadPhong(dtgvPhong);
                }
                catch { MessageBox.Show("Vui lòng nhập đúng thông tin!"); }
            }
            BindingPhong(dtgvPhong);
        }

        void XoaPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidphong.Text);
                    db.Phongs.Remove(db.Phongs.Find(id));
                    db.SaveChanges();
                    MessageBox.Show("Xóa phòng thành công!");
                    LoadPhong(dtgvPhong);
                }
                catch { }
            }
            BindingPhong(dtgvPhong);
        }

        void SuaPhong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    int id = int.Parse(tbxidphong.Text);
                    string ten = tbxtenphong.Text;
                    Phong phong = db.Phongs.Find(id);
                    int loai = (cbxloaiphong.SelectedValue as LoaiPhong).ID;
                    phong.Ten = ten;
                    phong.IDloai = loai;
                    db.SaveChanges();
                    MessageBox.Show("Sửa phòng thành công!");
                    LoadPhong(dtgvPhong);
                }
                catch { }
            }
            BindingPhong(dtgvPhong);
        }

        void LoadPhong(DataGridView dtgv)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from p in db.Phongs
                             from l in db.LoaiPhongs
                             where p.IDloai.Equals(l.ID)
                             select new
                             {
                                 ID = p.ID,
                                 Tên = p.Ten,
                                 Loại = l.Ten,
                                 Giá = l.Gia,
                                 Giường = l.SoGiuong
                             };
                dtgv.DataSource = source.ToList();
            }
        }

        private void dtgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (cbxloaiphong.DataSource == null||dtgvPhong.SelectedCells.Count == 0)
            {
                return;
            }
            string loai = dtgvPhong.SelectedCells[0].OwningRow.Cells["Loại"].Value.ToString();
            int index = 0;
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                index = db.LoaiPhongs.Select(p => p.Ten).ToList().IndexOf(loai);
            }
            cbxloaiphong.SelectedIndex = index;

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemPhong();
        }
        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XoaPhong();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SuaPhong();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            LoadLoaiPhong(cbxloaiphong);
        }
    }
}
