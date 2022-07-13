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
    public partial class uc_Doimatkhau1 : UserControl
    {
        public uc_Doimatkhau1()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string passold = txtpassold.Text;
                string passnew1 = txtpassnew1.Text;
                string passnew2 = txtpassnew2.Text;
                if (passold != cons.cons.user.Pass)
                {
                    MessageBox.Show("Hãy nhập mật khẩu hiện tại hợp lệ rồi thử lại.");
                }
                else
                {
                    if (passnew1 != passnew2)
                        MessageBox.Show("Mật khẩu mới không khớp");
                    using (QuanLyKhachSanEntities1 db = new QuanLyKhachSanEntities1())
                    {
                        User user = db.Users.Find(cons.cons.user.IDnhanvien);
                        user.Pass = passnew1;
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        txtpassold.Text = "";
                        txtpassnew1.Text = "";
                        txtpassnew2.Text = "";
                    }
                }
            }
            catch
            {

            }
        }

        private void uc_Doimatkhau1_Load(object sender, EventArgs e)
        {

        }
    }
}
