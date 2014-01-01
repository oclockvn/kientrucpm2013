namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    partial class frmBaoCaoTonReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerTon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTon
            // 
            this.reportViewerTon.ActiveViewIndex = -1;
            this.reportViewerTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewerTon.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewerTon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTon.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTon.Name = "reportViewerTon";
            this.reportViewerTon.Size = new System.Drawing.Size(784, 441);
            this.reportViewerTon.TabIndex = 0;
            // 
            // frmBaoCaoTonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.reportViewerTon);
            this.Name = "frmBaoCaoTonReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoTonReport";
            this.Load += new System.EventHandler(this.frmBaoCaoTonReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewerTon;
    }
}