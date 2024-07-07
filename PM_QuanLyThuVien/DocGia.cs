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
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();

        private void insert()
        {

            int slg = cls.CheckID("select COUNT(MaDG) from DOCGIA WHERE MaDG='" + txt_madocgia.Text + "'");
            //(int)sl.ExecuteScalar();
            if (slg > 0) MessageBox.Show("Mã độc giả đã tồn tại!");
            else
            {
                if (txt_madocgia.Text == "")
                {
                    MessageBox.Show("Mã độc giả trống!");
                }
                else if (txt_tendocgia.Text == "")
                {
                    MessageBox.Show("Tên độc giả trống!");
                }
                else
                {
                    string s = txt_ngaysinh.Value.Year + "/" + txt_ngaysinh.Value.Month + "/" + txt_ngaysinh.Value.Day;
                    string sql = "INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'" + txt_madocgia.Text + "', N'" + txt_tendocgia.Text + "', N'" + txt_gioitinh.Text + "', N'" + txt_diachi.Text + "', N'" + txt_sodienthoai.Text + "','" + s + "')";
                    cls.ThucThiSQLTheoKetNoi(sql);
                    MessageBox.Show("Success!");
                }
            }

        }
        private void update()
        {
            string s = txt_ngaysinh.Value.Year + "/" + txt_ngaysinh.Value.Month + "/" + txt_ngaysinh.Value.Day;
            string update =
                "update DOCGIA set TenDG=N'" + txt_tendocgia.Text + "',GioiTinh=N'" + txt_gioitinh.Text + "',DiaChi=N'" + txt_diachi.Text + "',SDT_EMAIL='" + txt_sodienthoai.Text + "',NgaySinh='" + s + "' WHERE MaDG='" + txt_madocgia.Text + "'";

            cls.ThucThiSQLTheoKetNoi(update);
        }
        private void delete()
        {

            string delete1 = "DELETE TRASACH WHERE MAPM=(SELECT MAPM FROM PHIEUMUON WHERE MAPM=TRASACH.MAPM AND MaDG='" + txt_madocgia.Text + "')";
            cls.ThucThiSQLTheoKetNoi(delete1);
            string delete2 = "DELETE QL_PHIEUMUON WHERE MAPM=(SELECT MAPM FROM PHIEUMUON WHERE MAPM=QL_PHIEUMUON.MAPM AND MaDG='" + txt_madocgia.Text + "')";
            cls.ThucThiSQLTheoKetNoi(delete2);
            string delete = "delete from phieumuon where MaDG='" + txt_madocgia.Text + "'";
            cls.ThucThiSQLTheoKetNoi(delete);

        }
        private void DocGia_Load(object sender, EventArgs e)
        {
            paneldg.Visible = true;
            // if()
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv_dsdocgia, "select *from DOCGIA");

            txt_madocgia.Enabled = false;
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            if (btn_themmoi.Text == "Add")
            {
                // txtma.Focus();
                txt_madocgia.Clear();
                txt_sodienthoai.Clear();
                txt_tendocgia.Clear();
                txt_diachi.Clear();
                txt_gioitinh.Clear();
                txt_madocgia.Enabled = true;
                btn_themmoi.Text = "OK";
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txt_madocgia.Focus();

            }
            else
            {
                insert();
                //  HienThi();

                cls.LoadData2DataGridView(dgv_dsdocgia, "select *from docgia");
                txt_madocgia.Enabled = false;
                btn_themmoi.Text = "Add";
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show(" Sửa thành công!");
            cls.LoadData2DataGridView(dgv_dsdocgia, "select *from DOCGIA");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                string delete1 = "delete DOCGIA where MaDG='" + txt_madocgia.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                MessageBox.Show("Xóa thành công!");
            }
            cls.LoadData2DataGridView(dgv_dsdocgia, "select *from DOCGIA");
            //HienThi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_dsdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgv_dsdocgia.CurrentRow.Index;
            txt_madocgia.Text = dgv_dsdocgia.Rows[a].Cells[0].Value.ToString();
            txt_tendocgia.Text = dgv_dsdocgia.Rows[a].Cells[1].Value.ToString();
            txt_gioitinh.Text = dgv_dsdocgia.Rows[a].Cells[2].Value.ToString();
            txt_diachi.Text = dgv_dsdocgia.Rows[a].Cells[3].Value.ToString();
            txt_sodienthoai.Text = dgv_dsdocgia.Rows[a].Cells[4].Value.ToString();
            DateTime dt = Convert.ToDateTime(dgv_dsdocgia.Rows[a].Cells[5].Value.ToString());
            txt_ngaysinh.Value = dt;
            cls.LoadData2DataGridView(dgv_chitietmuon, "EXEC DSSachmuon @MaDocGia='" + txt_madocgia.Text + "'");
        }
    }
}
