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

namespace QLKSNew
{
    public partial class TimKiemPhong : Form
    {
        public TimKiemPhong()
        {
            InitializeComponent();
        }
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        int i;
        public delegate void TruyenChoCha(string s);
        public TruyenChoCha TruyenData;
        private void btnchon_Click(object sender, EventArgs e)
        {
            i = dtgvtimphong.CurrentRow.Index;
            lbtimphong.Text = dtgvtimphong[0, i].Value.ToString();
            TruyenData(lbtimphong.Text);
            this.Close();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxtimphong_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * from phong where phong.ten LIKE N'%" + tbxtimphong.Text + "%' AND trangthai=N'Có Người' ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvtimphong.DataSource = dt;
            dtgvtimphong.Refresh();
        }

        private void TimKiemPhong_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            loadtimkiemphong();
        }
        private void loadtimkiemphong()
        {

            //sql = "SELECT phong.id,phong.ten,loaiphong.ten,gia,sogiuong FROM dbo.phong,db.loaiphong where phong.idloai=loaiphong.id";
            sql = "SELECT * FROM phong where trangthai=N'Có Người'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgvtimphong.DataSource = dt;
            dtgvtimphong.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                i = dtgvtimphong.CurrentRow.Index;
                lbtimphong.Text = dtgvtimphong[0, i].Value.ToString();
                TruyenData(lbtimphong.Text);
                this.Close();
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
