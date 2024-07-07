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
    public partial class TTSach : Form
    {
        public TTSach()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();
        string matl, manxb;
        private void HienThi()
        {
            cls.LoadData2DataGridView(dgv_sach, "select *from sach");
        }

        private void loadmanxb()
        {
            cls.Load1Combo(cbo_NXB, "select * from NXB");
            cbo_NXB.DisplayMember = "TenNXB";
            cbo_NXB.ValueMember = "MaNXB";
        }
        private void loadtl()
        {
            cls.Load1Combo(cbo_TheLoai, "select*from theloai");
            cbo_TheLoai.DisplayMember = "TenTL";
            cbo_TheLoai.ValueMember = "MaTL";
        }

        private void update()
        {


            string cmd = "update SACH set TenSach=N'" + txtten.Text + "',Gia=" + txtgia.Text + ",MaNXB='" + manxb + "',MaTL=N'" + matl + "',SoLuong=" + txtSoluong.Text + ",SoTrang=" + txtSotrang.Text + ",SoSachHong=" + txthong.Text + " where MaSach='" + txtma.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void insert()
        {


            string sql = "insert into SACH values('" + txtma.Text + "',N'" + txtten.Text + "','" + txtgia.Text + "','" + manxb + "','" + matl + "','" + (txtSoluong.Text) + "','" + txtSotrang.Text + "','" + txthong.Text + "')";

            cls.ThucThiSQLTheoKetNoi(sql);


        }
        private void delete()
        {
            string sql = "delete from SACH where MaSach='" + txtma.Text + "'";
            cls.ThucThiSQLTheoKetNoi(sql);
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            if (btn_Thêm.Text == "Thêm")
            {
                cbo_TheLoai.Text = "";
                txtgia.Clear();
                txtma.Clear();
                txthong.Clear();
                txtSoluong.Clear();
                txtSotrang.Clear();
                cbo_NXB.Text = "";
                txtten.Clear();
                txtma.Focus();
                txtma.Enabled = true;
                btn_Thêm.Text = "OK";

            }
            else
            {
                int slg = cls.CheckID("select COUNT(masach) from sach WHERE masach='" + txtma.Text + "'");
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Mã sách đã tồn tại!");
                else if (txtma.Text == "")
                {
                    MessageBox.Show("Mã sách trống!");
                }
                else if (txtten.Text == "")
                {
                    MessageBox.Show("Tên sách trống!");
                }
                txtma.Enabled = false;
                insert();
                MessageBox.Show("Add book successully!");
                HienThi();
                btn_Thêm.Text = "Thêm";
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show("Edit book successfully!");
            HienThi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete1 = "DELETE TRASACH WHERE MASACH='" + txtma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                string delete2 = "DELETE QL_PHIEUMUON WHERE MASACH='" + txtma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete2);
                //   string delete3 = "delete from phieumuon where MaDG='" + txtma.Text + "'";
                //  cls.ThucThiSQLTheoKetNoi(delete3);
                delete();
                HienThi();
            }
        }

        private void dgv_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_sach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {

                txtma.Text = dgv_sach.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgv_sach.Rows[i].Cells[1].Value.ToString().Trim();
                txtgia.Text = dgv_sach.Rows[i].Cells[2].Value.ToString().Trim();
                cbo_NXB.SelectedValue = dgv_sach.Rows[i].Cells[3].Value.ToString().Trim();
                cbo_TheLoai.SelectedValue = dgv_sach.Rows[i].Cells[4].Value.ToString().Trim();

                txtSoluong.Text = dgv_sach.Rows[i].Cells[5].Value.ToString().Trim();
                txtSotrang.Text = dgv_sach.Rows[i].Cells[6].Value.ToString().Trim();
                txthong.Text = dgv_sach.Rows[i].Cells[7].Value.ToString().Trim();

            }
            catch (Exception) { }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_NXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            manxb = cbo_NXB.SelectedValue.ToString();
        }

        private void cbo_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            matl = cbo_TheLoai.SelectedValue.ToString();
        }

        private void TTSach_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
            HienThi();
            loadmanxb();

            loadtl();

            cbo_NXB_SelectedIndexChanged(sender, e);
            cbo_TheLoai_SelectedIndexChanged(sender, e);
        }
    }
}
