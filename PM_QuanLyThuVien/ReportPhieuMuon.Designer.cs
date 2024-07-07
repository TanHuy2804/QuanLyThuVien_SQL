namespace PM_QuanLyThuVien
{
    partial class ReportPhieuMuon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaPN = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 96);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1335, 594);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // cboMaPN
            // 
            this.cboMaPN.FormattingEnabled = true;
            this.cboMaPN.Location = new System.Drawing.Point(563, 38);
            this.cboMaPN.Name = "cboMaPN";
            this.cboMaPN.Size = new System.Drawing.Size(278, 24);
            this.cboMaPN.TabIndex = 3;
            this.cboMaPN.SelectedIndexChanged += new System.EventHandler(this.cboMaPN_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(907, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ReportPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 702);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboMaPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportPhieuMuon";
            this.Text = "ReportPhieuMuon";
            this.Load += new System.EventHandler(this.ReportPhieuMuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaPN;
        private System.Windows.Forms.Button btnThoat;
    }
}