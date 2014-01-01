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
    public partial class frmBaoCaoTonReport : Form
    {
        public frmBaoCaoTonReport()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTonReport_Load(object sender, EventArgs e)
        {
            ReportDocument doc = new ReportDocument();
            doc.Load("..\\..\\rptTon.rpt");
            reportViewerTon.ReportSource = doc;
            reportViewerTon.Refresh();
        }
    }
}
