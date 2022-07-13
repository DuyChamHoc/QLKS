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
    public partial class uc_Quanlybangluong : UserControl
    {
        public uc_Quanlybangluong()
        {
            InitializeComponent();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            ThemLuong();
        }
        void ThemLuong()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try
                {
                    string id = txbid.Text;
                    if (db.NhanViens.Select(m => m.ID).Contains(id))
                    {
                        if (db.BangLuongs.Select(m => m.IDnhanvien).Contains(id))
                        {
                            MessageBox.Show("Nhân viên này đã tồn tại!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại nhân viên này!");
                        return;
                    }
                    decimal luong = decimal.Parse(txbluong.Text);
                    decimal tc = decimal.Parse(txbtrocap.Text);

                    int ngay = int.Parse(txbngaylam.Text);
                    BangLuong p = new BangLuong()
                    {
                        IDnhanvien = id,
                        LuongCB = luong,
                        Ngay = ngay,
                        Trocap = tc
                    };
                    db.BangLuongs.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Thêm lương nhân viên thành công!");
                    LoadLuong(dtgvluong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin!");
                }  
            }
            BindingLuong(dtgvluong);       
        }
            private void btnsua_Click(object sender, EventArgs e)
        {
            Sua();
        }
        void Sua()
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                try {
                    string id = txbid.Text;
                    BangLuong l = db.BangLuongs.Find(id);
                    decimal luong = decimal.Parse(txbluong.Text);
                    decimal tc = decimal.Parse(txbtrocap.Text);
                    int ngay = int.Parse(txbngaylam.Text);

                    l.LuongCB = luong;
                    l.Trocap = tc;
                    l.Ngay = ngay;
                    db.SaveChanges();
                    MessageBox.Show("Sửa lương thành công!");
                    LoadLuong(dtgvluong);
                }
                catch { }
            }
            BindingLuong(dtgvluong);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double luong = double.Parse(txbluong.Text);
            int ngay = int.Parse(txbngaylam.Text);
            double tc = double.Parse(txbtrocap.Text);
            txbtongluong.Text = ((int)(luong * ngay / GetDay() + tc)).ToString() + "  VND";
        }
        int GetDay()
        {
            DateTime date = DateTime.Now;
            int year = date.Year;
            int mon = date.Month;
            int day = 0;
            switch (mon)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) day = 29;
                    else day = 28;
                    break;
            }
            return day;
        }
        private void uc_Quanlybangluong_Load(object sender, EventArgs e)
        {
            LoadLuong(dtgvluong);
            BindingLuong(dtgvluong);
            txbid.Text = "";
            txbluong.Text = "";
            txbngaylam.Text = "0";
            txbten.Text = "";
            txbtrocap.Text = "";
            txbtongluong.Text = "0";
        }
        void LoadLuong(DataGridView dtgv)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                var source = from l in db.BangLuongs
                             from nv in db.NhanViens
                             where l.IDnhanvien.Equals(nv.ID)
                             select new
                             {
                                 ID = l.IDnhanvien,
                                 Tên = nv.Ten,
                                 Lương = l.LuongCB,
                                 Trợ_Cấp = l.Trocap,
                                 Ngày_Làm = l.Ngay

                             };
                dtgv.DataSource = source.ToList();
            }
        }
        void BindingLuong(DataGridView dtgv)
        {
            Binding bdID = new Binding("Text", dtgv.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            txbid.DataBindings.Clear();
            txbid.DataBindings.Add(bdID);
            Binding bdTen = new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.OnPropertyChanged);
            txbten.DataBindings.Clear();
            txbten.DataBindings.Add(bdTen);
            Binding bdLuong = new Binding("Text", dtgv.DataSource, "Lương", true, DataSourceUpdateMode.OnPropertyChanged);
            txbluong.DataBindings.Clear();
            txbluong.DataBindings.Add(bdLuong);
            Binding bdTC = new Binding("Text", dtgv.DataSource, "Trợ_Cấp", true, DataSourceUpdateMode.OnPropertyChanged);
            txbtrocap.DataBindings.Clear();
            txbtrocap.DataBindings.Add(bdTC);
            Binding bdNgay = new Binding("Text", dtgv.DataSource, "Ngày_Làm", true, DataSourceUpdateMode.OnPropertyChanged);
            txbngaylam.DataBindings.Clear();
            txbngaylam.DataBindings.Add(bdNgay);
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            LoadLuong(dtgvluong);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadLuong(dtgvluong);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            double luong = double.Parse(txbluong.Text);
            int ngay = int.Parse(txbngaylam.Text);
            double tc = double.Parse(txbtrocap.Text);
            txbtongluong.Text = ((int)(luong * ngay / GetDay() + tc)).ToString() + "  VND";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemLuong();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadLuong(dtgvluong);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            double luong = double.Parse(txbluong.Text);
            int ngay = int.Parse(txbngaylam.Text);
            double tc = double.Parse(txbtrocap.Text);
            txbtongluong.Text = ((int)(luong * ngay / GetDay() + tc)).ToString() + "  VND";
        }
    }
}
