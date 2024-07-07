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
    public partial class QuanLyTra : Form
    {
        public QuanLyTra()
        {
            InitializeComponent();
        }
        int k = 0;
        Connect cls = new PM_QuanLyThuVien.Connect();
        private void QuanLyTra_Load(object sender, EventArgs e)
        {
            cbo_pnmasach.Enabled = false;
            cbo_pnmanv.Enabled = false;
            cbo_pnmaphieu.Enabled = false;
            // ketnoi();
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv_pn1, "select *from TRASACH");
            //  i = 1;
            //    HienThi();
        }

        private void update_TS()
        {
            string s = dtt_pnngaytra.Value.Year + "/" + dtt_pnngaytra.Value.Month + "/" + dtt_pnngaytra.Value.Day;
            string sql = "update TRASACH set NgayTra=convert(smalldatetime,'" + s.ToString() + "'),PhatQuaHan='" + txt_pnphat.Text + "' where MaPM='" + cbo_pnmaphieu.Text + "' and MaSach='" + cbo_pnmasach.Text + "' ";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void insert()
        {

            string s = dtt_pnngaytra.Value.Year + "/" + dtt_pnngaytra.Value.Month + "/" + dtt_pnngaytra.Value.Day;
            string sql = "insert into TRASACH (MaPM,MaSach,TaiKhoan,NgayTra,PhatQuaHan) values('" + cbo_pnmaphieu.Text + "','" + cbo_pnmasach.Text + "','" + cbo_pnmanv.Text + "',convert(smalldatetime,'" + s.ToString() + "'),'" + txt_pnphat.Text + "')";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void delete()
        {
            string sql = "delete from TRASACH where MaPM='" + cbo_pnmaphieu.Text + "' and MaSach='" + cbo_pnmasach.Text + "'";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void delete_mp()
        {

            string cmd = "delete from MAPHIEU where MaPM='" + cbo_pnmaphieu.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);
            string cmd1 = "delete from QL_PHIEUMUON where MaPM='" + cbo_pnmaphieu.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd1);
        }
        private void combobox()
        {

            cls.KetNoi();

            cls.LoadCombo(cbo_pnmaphieu, "select MaPM from PHIEUMUON");

            cls.LoadCombo(cbo_pnmasach, "select MaSach from SACH ");

            cls.LoadCombo(cbo_pnmanv, "select MaNV from NHANVIEN");

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update_TS();
            // HienThi();
            cls.LoadData2DataGridView(dgv_pn1, "select*from TRASACH");
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dgv_pn1, "select * from TRASACH where mapm='" + txt_timkiem.Text + "'");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dgv_pn1, "select*from TRASACH");
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            if (k == 1 && txt_pnphat.Text == "0")
            {
                MessageBox.Show("Không cập nhât!");
            }
            else if (txt_pnphat.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách sẽ được trả lại!");
            }
            else
            {
                string cmd = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + cbo_pnmasach.Text + "' and Mapm='" + cbo_pnmaphieu.Text + "') from sach where MaSach='" + cbo_pnmasach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd);
                string cmd1 = "delete from QL_PHIEUMUON where MaPM='" + cbo_pnmaphieu.Text + "' and MaSach='" + cbo_pnmasach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd1);
                delete();
                MessageBox.Show("Trả sách thành công!");
                txt_pnphat.Text = "";
                cbo_pnmaphieu.Text = "";
                cbo_pnmasach.Text = "";
                cbo_pnmanv.Text = "";
                k = 0;
                cls.LoadData2DataGridView(dgv_pn1, "select*from dbo.TRASACH");
            }
        }

        private void dgv_pn1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                cbo_pnmaphieu.Text = dgv_pn1.Rows[i].Cells[0].Value.ToString().Trim();
                cbo_pnmasach.Text = dgv_pn1.Rows[i].Cells[1].Value.ToString().Trim();
                cbo_pnmanv.Text = dgv_pn1.Rows[i].Cells[2].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgv_pn1.Rows[i].Cells[3].Value.ToString());
                dtt_pnngaytra.Value = dt;
                txt_pnphat.Text = dgv_pn1.Rows[i].Cells[4].Value.ToString().Trim();

                DateTime y = DateTime.Now;
                if ((y.Month - dtt_pnngaytra.Value.Month > 0) || ((y.Day - dtt_pnngaytra.Value.Day > 0) && (y.Month == dtt_pnngaytra.Value.Month) && txt_pnphat.Text == "0"))

                {
                    MessageBox.Show("Borrow-card " + cbo_pnmaphieu.Text + " borrow book " + cbo_pnmasach.Text + " out of date! ");
                    k = 1;
                    return;

                }
                k = 0;
            }
            catch (Exception) { }
        }
    }
}
