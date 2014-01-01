using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmBaoCaoNoCongReport : Form
    {
        public frmBaoCaoNoCongReport()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNoCongReport_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument doc = new ReportDocument();
                doc.Load("..\\..\\rptNoCong.rpt");
                reportViewerNoCong.ReportSource = doc;
                reportViewerNoCong.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
