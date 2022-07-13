using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSNew
{
    public partial class RpThu : DevExpress.XtraEditors.XtraForm
    {
        public RpThu()
        {
            InitializeComponent();
        }

        private void RpThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Report.DataTable1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLKSNew.RpThu.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "Report";
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}