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
    public partial class TTCaNhan : Form
    {
        public TTCaNhan()
        {
            InitializeComponent();
        }
        Connect dt = new PM_QuanLyThuVien.Connect();

        private void HienThi()
        {

            dt.LoadData2DataGridView(dgv_TTCN, "select TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh from NHANVIEN where TAIKHOAN = '" + MainForm.tendn + "'");
        }
        private void TTCaNhan_Load(object sender, EventArgs e)
        {
            dt.KetNoi();
            HienThi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text.Length - 1 <= 0)
                MessageBox.Show("Số điện thoại không được nhỏ hơn 0!");
            else if (txt_SoDienThoai.Text.ToString().Trim().Length - 1 >= 12)
            {
                MessageBox.Show("Số điện thoại không được lớn hơn 10 ");

            }
            else
            {

                string s = dtt_ns.Value.Year + "/" + dtt_ns.Value.Month + "/" + dtt_ns.Value.Day;
                string cmd = "update NHANVIEN set TenNV=N'" + txt_ten.Text + "',GioiTinh=N'" + txt_GIOITINH.Text + "',DiaChi=N'" + txt_DiaChi.Text + "',NgaySinh=N'" + s + "',SDT_EMAIL=N'" + txt_SoDienThoai.Text + "' where TAIKHOAN='" + MainForm.tendn + "'";
                //    cmd.ExecuteNonQuery();
                dt.ThucThiSQLTheoKetNoi(cmd);
                HienThi();
                MessageBox.Show("Sưa thành công!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgv_TTCN.CurrentRow.Index;
            txt_ten.Text = dgv_TTCN.Rows[a].Cells[1].Value.ToString();
            txt_GIOITINH.Text = dgv_TTCN.Rows[a].Cells[2].Value.ToString();
            txt_DiaChi.Text = dgv_TTCN.Rows[a].Cells[3].Value.ToString();
            txt_SoDienThoai.Text = dgv_TTCN.Rows[a].Cells[4].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(dgv_TTCN.Rows[a].Cells[5].Value.ToString());
            dtt_ns.Value = dt1;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
