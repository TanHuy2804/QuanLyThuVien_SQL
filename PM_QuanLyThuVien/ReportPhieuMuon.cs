using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyThuVien
{
    public partial class ReportPhieuMuon : Form
    {
        Connect dt = new Connect();
        public ReportPhieuMuon()
        {
            InitializeComponent();
        }
        private void ReportPhieuMuon_Load(object sender, EventArgs e)
        {
            cboMaPN.DataSource = dt.LoadPN();
            cboMaPN.DisplayMember = "MaSach";
            cboMaPN.ValueMember = "MaPM";
        }
        private void cboMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapm = cboMaPN.SelectedValue.ToString();
            DataTable DL = dt.LoadDuLieuPN(mapm);
            CrystalReportPhieuMuon MYRP = new CrystalReportPhieuMuon();
            MYRP.SetDataSource(DL);
            crystalReportViewer1.ReportSource = MYRP;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
