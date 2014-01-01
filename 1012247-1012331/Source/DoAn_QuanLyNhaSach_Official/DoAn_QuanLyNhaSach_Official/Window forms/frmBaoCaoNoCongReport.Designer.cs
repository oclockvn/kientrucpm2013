namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    partial class frmBaoCaoNoCongReport
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
            this.reportViewerNoCong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerNoCong
            // 
            this.reportViewerNoCong.ActiveViewIndex = -1;
            this.reportViewerNoCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewerNoCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewerNoCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerNoCong.Location = new System.Drawing.Point(0, 0);
            this.reportViewerNoCong.Name = "reportViewerNoCong";
            this.reportViewerNoCong.Size = new System.Drawing.Size(784, 441);
            this.reportViewerNoCong.TabIndex = 0;
            // 
            // frmBaoCaoNoCongReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.reportViewerNoCong);
            this.Name = "frmBaoCaoNoCongReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoNoCongReport";
            this.Load += new System.EventHandler(this.frmBaoCaoNoCongReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewerNoCong;
    }
}