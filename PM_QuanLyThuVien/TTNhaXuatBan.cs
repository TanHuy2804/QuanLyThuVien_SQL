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
    public partial class TTNhaXuatBan : Form
    {
        public TTNhaXuatBan()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();

        private void HienThi()
        {

            cls.LoadData2DataGridView(dgv_nxb, "select*from NXB");

        }


        private void insert()
        {

            string sql = "insert into NXB values('" + txt_ma.Text + "',N'" + txt_ten.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "')";
            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void delete()
        {
            string sql = "EXEC DEL_NXB @manxb = '" + txt_ma.Text + "'";
            //   SqlCommand cmd = new SqlCommand(sql, cnn);
            // cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void update()
        {
            string cmd = "update NXB set TenNXB=N'" + txt_ten.Text + "',DiaChi=N'" + txt_diachi.Text + "',SDT_EMAIL='" + txt_sdt.Text + "' where MaNXB='" + txt_ma.Text + "'";
            //cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void dgvnxb_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            try
            {
                txt_ma.Text = dgv_nxb.Rows[x].Cells[0].Value.ToString().Trim();
                txt_ten.Text = dgv_nxb.Rows[x].Cells[1].Value.ToString().Trim();
                txt_diachi.Text = dgv_nxb.Rows[x].Cells[2].Value.ToString().Trim();
                txt_sdt.Text = dgv_nxb.Rows[x].Cells[3].Value.ToString().Trim();
            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }
        private void TTNhaXuatBan_Load(object sender, EventArgs e)
        {
            txt_ma.Enabled = false;
            //   ketnoi();
            cls.KetNoi();
            HienThi();
        }

        private void dgv_nxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = dgv_nxb.CurrentRow.Index;
            txt_ma.Text = dgv_nxb.Rows[x].Cells[0].Value.ToString();
            txt_ten.Text = dgv_nxb.Rows[x].Cells[1].Value.ToString();
            txt_diachi.Text = dgv_nxb.Rows[x].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_nxb.Rows[x].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (btn_them.Text == "Add")
            {
                txt_ma.Enabled = true;
                txt_diachi.Clear();
                txt_ma.Clear();
                txt_sdt.Clear();
                txt_ten.Clear();
                btn_sua.Enabled = false;
                btn_qlnvxoa.Enabled = false;
                btn_them.Text = "OK";
            }
            else
            {
                btn_them.Text = "Add";
                btn_sua.Enabled = true;
                btn_qlnvxoa.Enabled = true;
                txt_ma.Enabled = false;
                int slg = cls.CheckID("select COUNT(manxb) from NXB WHERE maNXB='" + txt_ma.Text + "'");
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Mã NXB đã tồn tại!");
                else if (txt_ma.Text == "")
                { MessageBox.Show("Mã NXB trống!"); }
                else if (txt_ten.Text == "")
                {
                    MessageBox.Show("Tên NXB trống");
                }
                else
                {
                    insert();
                    MessageBox.Show(" Thêm thành công!");
                }
                HienThi();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_qlnvxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                HienThi();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show("Sửa thành công!");
            HienThi();
        }
    }
}
