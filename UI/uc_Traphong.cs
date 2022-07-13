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
    public partial class uc_Traphong : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtdv = new DataTable();
        DataTable dtrpt = new DataTable();
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        string sql;
        decimal tt, ttdv;
        decimal giaphong;
        decimal tienphong;

        private void uc_Traphong_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            conn.Open();
        }

        private void btndienthongtin_Click(object sender, EventArgs e)
        {
            sql = "SELECT phong.ten,loaiphong.ten,sogiuong, gia,FORMAT (ngaydat, 'dd/MM/yyyy '),khachhang.id,khachhang.ten,FORMAT (ngaysinh, 'dd/MM/yyyy '),gioitinh,email,sdt,cmnd,quoctich,DAY(ngaytra)-DAY(ngaydat),bangthuephong.id,FORMAT (ngaytra, 'dd/MM/yyyy '),ngaydat,ngaytra FROM dbo.phong, dbo.khachhang, dbo.bangthuephong,dbo.loaiphong "
                 + "WHERE phong.idloai=loaiphong.id and bangthuephong.idphong=phong.id and bangthuephong.idkhachhang=khachhang.id "
                 + "AND phong.id = '" + tbxtimidphong.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            lbtenphong.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            lbloaiphong.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            lbsogiuong.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
            lbgiaphong.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
            lbngaydatphong.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
            lbidkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
            lbtenkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
            lbngaysinh.Text = Convert.ToString(dt.Rows[0].ItemArray[7]);
            lbgioitinh.Text = Convert.ToString(dt.Rows[0].ItemArray[8]);
            lbemail.Text = Convert.ToString(dt.Rows[0].ItemArray[9]);
            lbsodienthoai.Text = Convert.ToString(dt.Rows[0].ItemArray[10]);
            lbcmnd.Text = Convert.ToString(dt.Rows[0].ItemArray[11]);
            lbquoctich.Text = Convert.ToString(dt.Rows[0].ItemArray[12]);
            lbsongaythue.Text = Convert.ToString(dt.Rows[0].ItemArray[13]);
            lbidbangthuephong.Text = Convert.ToString(dt.Rows[0].ItemArray[14]);
            lbtraphong.Text = Convert.ToString(dt.Rows[0].ItemArray[15]);
            lbdp.Text = Convert.ToString(dt.Rows[0].ItemArray[16]);
            lbtp.Text = Convert.ToString(dt.Rows[0].ItemArray[17]);
            sql = "SELECT ten as Tên, gia as Giá, soluong as SL,(gia*soluong) AS 'Tổng'"
                 + "FROM dbo.sudungdichvu, dbo.dichvu "
                 + "WHERE idphong IN (SELECT ID FROM dbo.phong WHERE id = '" + tbxtimidphong.Text + "') "
                 + "AND sudungdichvu.iddichvu = dichvu.id";
            da = new SqlDataAdapter(sql, conn);
            dtdv.Clear();
            da.Fill(dtdv);
            dtgvthongtindichvu.DataSource = dtdv;
            dtgvthongtindichvu.Refresh();
            if (lbsongaythue.Text == "0")
            {
                lbsongaythue.Text = "1";
            }
            giaphong = Convert.ToDecimal(lbgiaphong.Text);
            ttdv = 0;
            for (int i = 0; i <= dtgvthongtindichvu.RowCount - 2; i++)
            {
                ttdv = ttdv + decimal.Parse(dtgvthongtindichvu[3, i].Value.ToString());
            }
            tienphong = giaphong * (decimal.Parse(lbsongaythue.Text));
            tt = tienphong + ttdv;
            tbxtongtien.Text = tt.ToString();
            tbxkhachdua.Text = tbxtongtien.Text;
            tbxtralai.Text = "0";
        }

        private void btntimphong_Click(object sender, EventArgs e)
        {
            TimKiemPhong f = new TimKiemPhong();
            f.TruyenData = new TimKiemPhong.TruyenChoCha(LoadData);
            f.ShowDialog();
        }
        private void LoadData(string data)
        {
            tbxtimidphong.Text = "";
            tbxtimidphong.Text = data;
        }

        private void btntinhtoan_Click(object sender, EventArgs e)
        {
            tbxtralai.Text = (decimal.Parse(tbxkhachdua.Text) - decimal.Parse(tbxtongtien.Text)).ToString();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (tbxtongtien.Text != "" && tbxtralai.Text != "" && tbxkhachdua.Text != "")
            {
                if (Convert.ToInt32(tbxtralai.Text) >= 0)
                {
                    if (MessageBox.Show("Thanh toán và in hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        sql = "delete from dbo.bangthuephong WHERE idphong = '" + tbxtimidphong.Text + "';" +
                              "delete from dbo.sudungdichvu WHERE idphong = '" + tbxtimidphong.Text + "';" +
                              "UPDATE phong SET trangthai=N'Trống' WHERE id ='" + tbxtimidphong.Text + "'" +
                             "INSERT INTO dbo.hoadonthu VALUES" +
                             "('" + lbidkhachhang.Text + "','" + tbxtimidphong.Text + "','" + lbidbangthuephong.Text + "',N'" + cbxphuongthuc.Text + "','" + lbdp.Text + "','" + lbtp.Text + "','" + tienphong.ToString() + "','" + ttdv.ToString() + "','" + tbxtongtien.Text + "')";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        lbtenphong.Text = "";
                        lbloaiphong.Text = "";
                        lbsogiuong.Text = "";
                        lbgiaphong.Text = "";
                        lbngaydatphong.Text = "";
                        lbidkhachhang.Text = "";
                        lbtenkhachhang.Text = "";
                        lbngaysinh.Text = "";
                        lbgioitinh.Text = "";
                        lbemail.Text = "";
                        lbsodienthoai.Text = "";
                        lbcmnd.Text = "";
                        lbquoctich.Text = "";
                        lbsongaythue.Text = "";
                        lbidbangthuephong.Text = "";
                        lbtraphong.Text = "";
                        tbxtongtien.Text = "";
                        tbxkhachdua.Text = "";
                        cbxphuongthuc.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin thanh toán không chính xác hoặc không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TimKiemPhong f = new TimKiemPhong();
            f.TruyenData = new TimKiemPhong.TruyenChoCha(LoadData);
            f.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TimKiemPhong f = new TimKiemPhong();
            f.TruyenData = new TimKiemPhong.TruyenChoCha(LoadData);
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            sql = "SELECT phong.ten,loaiphong.ten,sogiuong, gia,FORMAT (ngaydat, 'dd/MM/yyyy '),khachhang.id,khachhang.ten,FORMAT (ngaysinh, 'dd/MM/yyyy '),gioitinh,email,sdt,cmnd,quoctich,DAY(ngaytra)-DAY(ngaydat),bangthuephong.id,FORMAT (ngaytra, 'dd/MM/yyyy '),ngaydat,ngaytra FROM dbo.phong, dbo.khachhang, dbo.bangthuephong,dbo.loaiphong "
                 + "WHERE phong.idloai=loaiphong.id and bangthuephong.idphong=phong.id and bangthuephong.idkhachhang=khachhang.id "
                 + "AND phong.id = '" + tbxtimidphong.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            lbtenphong.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            lbloaiphong.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            lbsogiuong.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
            lbgiaphong.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
            lbngaydatphong.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
            lbidkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
            lbtenkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
            lbngaysinh.Text = Convert.ToString(dt.Rows[0].ItemArray[7]);
            lbgioitinh.Text = Convert.ToString(dt.Rows[0].ItemArray[8]);
            lbemail.Text = Convert.ToString(dt.Rows[0].ItemArray[9]);
            lbsodienthoai.Text = Convert.ToString(dt.Rows[0].ItemArray[10]);
            lbcmnd.Text = Convert.ToString(dt.Rows[0].ItemArray[11]);
            lbquoctich.Text = Convert.ToString(dt.Rows[0].ItemArray[12]);
            lbsongaythue.Text = Convert.ToString(dt.Rows[0].ItemArray[13]);
            lbidbangthuephong.Text = Convert.ToString(dt.Rows[0].ItemArray[14]);
            lbtraphong.Text = Convert.ToString(dt.Rows[0].ItemArray[15]);
            lbdp.Text = Convert.ToString(dt.Rows[0].ItemArray[16]);
            lbtp.Text = Convert.ToString(dt.Rows[0].ItemArray[17]);
            sql = "SELECT ten, gia, soluong,(gia*soluong) AS 'tongtien'"
                 + "FROM dbo.sudungdichvu, dbo.dichvu "
                 + "WHERE idphong IN (SELECT ID FROM dbo.phong WHERE id = '" + tbxtimidphong.Text + "') "
                 + "AND sudungdichvu.iddichvu = dichvu.id";
            da = new SqlDataAdapter(sql, conn);
            dtdv.Clear();
            da.Fill(dtdv);
            dtgvthongtindichvu.DataSource = dtdv;
            dtgvthongtindichvu.Refresh();
            if (lbsongaythue.Text == "0")
            {
                lbsongaythue.Text = "1";
            }
            giaphong = Convert.ToDecimal(lbgiaphong.Text);
            ttdv = 0;
            for (int i = 0; i <= dtgvthongtindichvu.RowCount - 2; i++)
            {
                ttdv = ttdv + decimal.Parse(dtgvthongtindichvu[3, i].Value.ToString());
            }
            tienphong = giaphong * (decimal.Parse(lbsongaythue.Text));
            tt = tienphong + ttdv;
            tbxtongtien.Text = tt.ToString();
            tbxkhachdua.Text = tbxtongtien.Text;
            tbxtralai.Text = "0";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            sql = "SELECT phong.ten,loaiphong.ten,sogiuong, gia,FORMAT (ngaydat, 'dd/MM/yyyy '),khachhang.id,khachhang.ten,FORMAT (ngaysinh, 'dd/MM/yyyy '),gioitinh,email,sdt,cmnd,quoctich,DAY(ngaytra)-DAY(ngaydat),bangthuephong.id,FORMAT (ngaytra, 'dd/MM/yyyy '),ngaydat,ngaytra FROM dbo.phong, dbo.khachhang, dbo.bangthuephong,dbo.loaiphong "
                 + "WHERE phong.idloai=loaiphong.id and bangthuephong.idphong=phong.id and bangthuephong.idkhachhang=khachhang.id "
                 + "AND phong.id = '" + tbxtimidphong.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            lbtenphong.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            lbloaiphong.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            lbsogiuong.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
            lbgiaphong.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
            lbngaydatphong.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
            lbidkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
            lbtenkhachhang.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
            lbngaysinh.Text = Convert.ToString(dt.Rows[0].ItemArray[7]);
            lbgioitinh.Text = Convert.ToString(dt.Rows[0].ItemArray[8]);
            lbemail.Text = Convert.ToString(dt.Rows[0].ItemArray[9]);
            lbsodienthoai.Text = Convert.ToString(dt.Rows[0].ItemArray[10]);
            lbcmnd.Text = Convert.ToString(dt.Rows[0].ItemArray[11]);
            lbquoctich.Text = Convert.ToString(dt.Rows[0].ItemArray[12]);
            lbsongaythue.Text = Convert.ToString(dt.Rows[0].ItemArray[13]);
            lbidbangthuephong.Text = Convert.ToString(dt.Rows[0].ItemArray[14]);
            lbtraphong.Text = Convert.ToString(dt.Rows[0].ItemArray[15]);
            lbdp.Text = Convert.ToString(dt.Rows[0].ItemArray[16]);
            lbtp.Text = Convert.ToString(dt.Rows[0].ItemArray[17]);
            sql = "SELECT ten, gia, soluong,(gia*soluong) AS 'tongtien'"
                 + "FROM dbo.sudungdichvu, dbo.dichvu "
                 + "WHERE idphong IN (SELECT ID FROM dbo.phong WHERE id = '" + tbxtimidphong.Text + "') "
                 + "AND sudungdichvu.iddichvu = dichvu.id";
            da = new SqlDataAdapter(sql, conn);
            dtdv.Clear();
            da.Fill(dtdv);
            dtgvthongtindichvu.DataSource = dtdv;
            dtgvthongtindichvu.Refresh();
            if (lbsongaythue.Text == "0")
            {
                lbsongaythue.Text = "1";
            }
            giaphong = Convert.ToDecimal(lbgiaphong.Text);
            ttdv = 0;
            for (int i = 0; i <= dtgvthongtindichvu.RowCount - 2; i++)
            {
                ttdv = ttdv + decimal.Parse(dtgvthongtindichvu[3, i].Value.ToString());
            }
            tienphong = giaphong * (decimal.Parse(lbsongaythue.Text));
            tt = tienphong + ttdv;
            tbxtongtien.Text = tt.ToString();
            tbxkhachdua.Text = tbxtongtien.Text;
            tbxtralai.Text = "0";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbxtralai.Text = (decimal.Parse(tbxkhachdua.Text) - decimal.Parse(tbxtongtien.Text)).ToString();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbxtongtien.Text != "" && tbxtralai.Text != "" && tbxkhachdua.Text != "")
            {
                if (Convert.ToInt32(tbxtralai.Text) >= 0)
                {
                    if (MessageBox.Show("Thanh toán và in hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        sql = "delete from dbo.bangthuephong WHERE idphong = '" + tbxtimidphong.Text + "';" +
                             "delete from dbo.sudungdichvu WHERE idphong = '" + tbxtimidphong.Text + "';" +
                             "UPDATE phong SET trangthai=N'Trống' WHERE id ='" + tbxtimidphong.Text + "'" +
                            "INSERT INTO dbo.hoadonthu VALUES" +
                           "('" + lbidkhachhang.Text + "','" + tbxtimidphong.Text + "','" + lbidbangthuephong.Text + "',N'" + cbxphuongthuc.Text + "','" + lbdp.Text + "','" + lbtp.Text + "','" + tienphong.ToString() + "','" + ttdv.ToString() + "','" + tbxtongtien.Text + "')";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        lbtenphong.Text = "";
                        lbloaiphong.Text = "";
                        lbsogiuong.Text = "";
                        lbgiaphong.Text = "";
                        lbngaydatphong.Text = "";
                        lbidkhachhang.Text = "";
                        lbtenkhachhang.Text = "";
                        lbngaysinh.Text = "";
                        lbgioitinh.Text = "";
                        lbemail.Text = "";
                        lbsodienthoai.Text = "";
                        lbcmnd.Text = "";
                        lbquoctich.Text = "";
                        lbsongaythue.Text = "";
                        lbidbangthuephong.Text = "";
                        lbtraphong.Text = "";
                        tbxtongtien.Text = "";
                        tbxkhachdua.Text = "";
                        cbxphuongthuc.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin thanh toán không chính xác hoặc không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (tbxtongtien.Text != "" && tbxtralai.Text != "" && tbxkhachdua.Text != "")
            {
                if (Convert.ToDecimal(tbxtralai.Text) >= 0)
                {
                    if (MessageBox.Show("Thanh toán và in hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        sql = "delete from dbo.bangthuephong WHERE idphong = '" + tbxtimidphong.Text + "';" +
                            "delete from dbo.sudungdichvu WHERE idphong = '" + tbxtimidphong.Text + "';" +
                            "UPDATE phong SET trangthai=N'Trống' WHERE id ='" + tbxtimidphong.Text + "'" +
                           "INSERT INTO dbo.hoadonthu VALUES" +
                        "('" + lbidkhachhang.Text + "','" + tbxtimidphong.Text + "','" + lbidbangthuephong.Text + "',N'" + cbxphuongthuc.Text + "','" + lbdp.Text + "','" + lbtp.Text + "','" + tienphong.ToString() + "','" + ttdv.ToString() + "','" + tbxtongtien.Text + "')";
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        lbtenphong.Text = "";
                        lbloaiphong.Text = "";
                        lbsogiuong.Text = "";
                        lbgiaphong.Text = "";
                        lbngaydatphong.Text = "";
                        lbidkhachhang.Text = "";
                        lbtenkhachhang.Text = "";
                        lbngaysinh.Text = "";
                        lbgioitinh.Text = "";
                        lbemail.Text = "";
                        lbsodienthoai.Text = "";
                        lbcmnd.Text = "";
                        lbquoctich.Text = "";
                        lbsongaythue.Text = "";
                        lbidbangthuephong.Text = "";
                        lbtraphong.Text = "";
                        tbxtongtien.Text = "";
                        tbxkhachdua.Text = "";
                        cbxphuongthuc.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin thanh toán không chính xác hoặc không đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tbxtralai.Text = (decimal.Parse(tbxkhachdua.Text) - decimal.Parse(tbxtongtien.Text)).ToString();
        }
        public uc_Traphong()
        {
            InitializeComponent();
        }

    }
}
