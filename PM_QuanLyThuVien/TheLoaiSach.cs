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
    public partial class TheLoaiSach : Form
    {
        public TheLoaiSach()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();
        private void TheLoaiSach_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv_Loai, "select *from THELOAI");
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            string matl = txt_ma.Text.Trim();
            string tentl = txt_ten.Text.Trim();

            if (matl.Length != 0 && tentl.Length != 0)
            {
                int temp = cls.CheckID("select COUNT(matl) from theloai WHERE matl='" + matl + "'");
                if (temp > 0)
                {
                    MessageBox.Show("Mã thể loại đã tồn tại!");
                }
                else
                {
                    string insert = "insert into THELOAI values('" + matl + "',N'" + tentl + "')";
                    cls.ThucThiSQLTheoKetNoi(insert);
                    MessageBox.Show("Thêm thành công!");
                    cls.LoadData2DataGridView(dgv_Loai, "select *from THELOAI");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để hoàn tất!");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_qlnvxoa_Click(object sender, EventArgs e)
        {
            string matl = txt_ma.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string del = "delete THELOAI where MaTL = '" + matl + "'";
                cls.ThucThiSQLTheoKetNoi(del);
                MessageBox.Show("Xóa Thành công!");
            }
            cls.LoadData2DataGridView(dgv_Loai, "select *from THELOAI");
        }

        private void dgv_Loai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Loai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txt_ma.Text = dgv_Loai.Rows[i].Cells[0].Value.ToString().Trim();
                txt_ten.Text = dgv_Loai.Rows[i].Cells[1].Value.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string matl = txt_ma.Text.Trim();
            string tentl = txt_ten.Text.Trim();
            if (matl.Length != 0 && tentl.Length != 0)
            {
                int temp = cls.CheckID("select COUNT(matl) from theloai WHERE matl='" + matl + "'");
                if (temp > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn sửa?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string update = "update THELOAI set  TenTL=N'" + txt_ten.Text + "' where MaTL='" + txt_ma.Text + "' ";
                        cls.ThucThiSQLTheoKetNoi(update);
                        MessageBox.Show("Sửa thành công!");
                        cls.LoadData2DataGridView(dgv_Loai, "select *from THELOAI");
                    }
                }
                else
                {
                    MessageBox.Show("Mã thể loại chưa tồn tại! Không thể sửa");
                }

            }
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            txt_ma.Clear();
            txt_ten.Clear();
        }
    }
}
