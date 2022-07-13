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
    public partial class uc_Sudungdichvu : UserControl
    {
        string str = @"data source=DESKTOP-B87RR5R\SQLEXPRESS;initial catalog=QuanLyKhachSan;integrated security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql;

        public uc_Sudungdichvu()
        {
            InitializeComponent();
        }
        private void uc_Sudungdichvu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = str;
            conn.Open();
            loadsudungdichvu();
            bindingsudungdichvu();
        }
        void bindingsudungdichvu()
        {
            Binding bdtendichvu = new Binding("Text", dtgvsudungdichvu.DataSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxbdtendv.DataBindings.Add(bdtendichvu);
            Binding bdgiadichvu = new Binding("Text", dtgvsudungdichvu.DataSource, "Gia", true, DataSourceUpdateMode.OnPropertyChanged);
            tbxbdgiadichvu.DataBindings.Add(bdgiadichvu);

        }
        void sudungdichvu()
        {
            if (tbxbdtendv.Text != "" && cbxsophong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    sql = "INSERT INTO dbo.sudungdichvu(iddichvu, idphong, soluong )VALUES"
                         + "((SELECT ID FROM dbo.dichvu WHERE ten=N'"+tbxbdtendv.Text+"'),(SELECT ID FROM dbo.phong WHERE ten = '" + cbxsophong.Text + "'),'" + tbxbdsoluong.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    tbxbdtendv.Text = "";
                    tbxbdgiadichvu.Text = "";
                    cbxsophong.Text = "";
                    tbxbdsoluong.Text = "";
                }
                MessageBox.Show("Chọn dịch vụ thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void loadsudungdichvu()
        {
            dt.Clear();
            sql = "SELECT * FROM dbo.dichvu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgvsudungdichvu.DataSource = dt;
            dtgvsudungdichvu.Refresh();

            sql = "SELECT Ten FROM dbo.phong";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            cbxsophong.DataSource = dt1;
            cbxsophong.DisplayMember = "Ten";

        }

        private void btnchondichvu_Click(object sender, EventArgs e)
        {
            sudungdichvu();
        }

        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM dbo.dichvu WHERE Ten LIKE N'%" + tbxsearch.Text + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dtgvsudungdichvu.DataSource = dt;
            dtgvsudungdichvu.Refresh();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sudungdichvu();
            loadsudungdichvu();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sudungdichvu();//
            loadsudungdichvu();
        }
        void LoadPhong(ComboBox cb)
        {
            using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
            {
                cb.DataSource = db.Phongs.ToList();
                cb.DisplayMember = "Ten";
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            LoadPhong(cbxsophong);
        }
    }
}
