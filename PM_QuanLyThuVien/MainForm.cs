using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PM_QuanLyThuVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Connect cls = new Connect();
        string tk;

        private void MainForm_Load(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Enabled = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelbaocao.Enabled = false;
            panelqlnhanvien.Enabled = false;
            panelbaocao.Enabled = false;
            //     panelqldocgia.Enabled = false;
            panelqlsach.Enabled = false;
            cls.KetNoi();
            txt_Taikhoan.Enabled = false;
        }
        private void HienThi()
        {
            cls.LoadData2DataGridView(dgv_nvdanhsach, "select TaiKhoan,TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh from NHANVIEN");
        }
        private void update()
        {
            string s = txt_ngaysinh.Value.Year + "/" + txt_ngaysinh.Value.Month + "/" + txt_ngaysinh.Value.Day;
            string cmd = "update NHANVIEN set TenNV=N'" + txt_TenNV.Text + "',GioiTinh=N'" + txt_gioitinh.Text + "',DiaChi=N'" + txt_diachi.Text + "',SDT_EMAIL='" + txt_sdt.Text + "',NgaySinh=convert(smalldatetime,'" + s.ToString() + "') where Taikhoan='" + txt_Taikhoan.Text + "'";
            //  cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void delete()
        {

            string sql = "delete from NHANVIEN where TaiKhoan='" + txt_Taikhoan.Text + "'";
            cls.ThucThiSQLTheoKetNoi(sql);

        }
        private void insert()
        {


            string tk = "select COUNT(TaiKhoan) from NHANVIEN WHERE TaiKhoan='" + txt_Taikhoan.Text + "'";
            int slg = cls.CheckID(tk);
            //(int)sl.ExecuteScalar();
            if (slg > 0) MessageBox.Show("Tài khoản này đã tồn tại");
            else
            {
                string s = txt_ngaysinh.Value.Year + "/" + txt_ngaysinh.Value.Month + "/" + txt_ngaysinh.Value.Day;
                string sql =
                    "insert into NHANVIEN(TaiKhoan,TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh,) values('" + txt_Taikhoan.Text + "',N'" + txt_TenNV.Text + "',N'" + txt_gioitinh.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "'," + s + ")";


                cls.ThucThiSQLTheoKetNoi(sql);
            }


        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                paneldangnhap.Hide();
                paneldsnv.Visible = false;
                panelqlphieu.Enabled = false;
                panelqldocgia.Enabled = false;
                panelbaocao.Enabled = false;
                panelqlnhanvien.Enabled = false;
                btn_dangnhap.Enabled = true;
                MessageBox.Show("Bạn đã đăng xuất!");
                lbThongBao.Show();
            }
        }

        private void btn_docgia_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();

            dg.ShowDialog();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau DMK = new DoiMatKhau();
            DMK.Message = txtdntaikhoan.Text;
            DMK.MK = txtdnmatkhau.Text;
            DMK.ShowDialog();
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            TTSach Sach = new TTSach();

            Sach.ShowDialog();
        }

        private void btn_muonsach_Click(object sender, EventArgs e)
        {
            new QuanLyMuon().ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // mat khau//
        public static string tendn, matkhau, quyen;

        private void btn_qlnvxoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                HienThi();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            lbThongBao.Hide();
            txtdnmatkhau.Clear();
            txtdntaikhoan.Clear();
            paneldangnhap.Visible = true;
            txtdntaikhoan.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show("Chỉnh Sửa thành công!");
            cls.LoadData2DataGridView(dgv_nvdanhsach, "select * from NHANVIEN");
            HienThi();
        }

        private void btn_NXB_Click(object sender, EventArgs e)
        {
            TTNhaXuatBan NXB = new TTNhaXuatBan();
            NXB.ShowDialog();
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            new QuanLyTra().ShowDialog();
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {
            new TheLoaiSach().ShowDialog();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //Tìm kiếm sách Dộc giả
            TimKiemSach SDG = new TimKiemSach();
            SDG.ShowDialog();
        }

        private void btn_TTcanhan_Click(object sender, EventArgs e)
        {
            TTCaNhan TTCN = new TTCaNhan();

            TTCN.ShowDialog();
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            DangKy DK = new DangKy();
            DK.ShowDialog();
        }

        private void btn_noiquy_Click(object sender, EventArgs e)
        {
            NoiQuy NQ = new NoiQuy();
            NQ.ShowDialog();
        }

        private void dgv_nvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_nvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgv_nvdanhsach.CurrentRow.Index;
            txt_Taikhoan.Text = dgv_nvdanhsach.Rows[a].Cells[0].Value.ToString();
            txt_TenNV.Text = dgv_nvdanhsach.Rows[a].Cells[1].Value.ToString();
            txt_gioitinh.Text = dgv_nvdanhsach.Rows[a].Cells[2].Value.ToString();
            txt_diachi.Text = dgv_nvdanhsach.Rows[a].Cells[3].Value.ToString();
            txt_sdt.Text = dgv_nvdanhsach.Rows[a].Cells[4].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(dgv_nvdanhsach.Rows[a].Cells[5].Value.ToString());
            txt_ngaysinh.Value = dt1;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            cls.KetNoi();
            paneldsnv.Visible = true;
            HienThi();
        }

        private void btn_gioithieu_Click(object sender, EventArgs e)
        {
            GioiThieu GT = new GioiThieu();
            GT.ShowDialog();
        }

        private void bttdndangnhap_Click(object sender, EventArgs e)
        {
            cls.KetNoi();
            tendn = txtdntaikhoan.Text;
            matkhau = txtdnmatkhau.Text;
            if (tendn != "")
            {
                object Q = cls.layGiaTri("select Quyenhan from NHANVIEN where TaiKhoan = '" + tendn + "' and MatKhau = '" + matkhau + "'");
                if (Q == null)
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdntaikhoan.Clear();
                    txtdnmatkhau.Clear();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);
                    quyen = Convert.ToString(Q);
                    if (quyen == "admin")
                    {
                        paneldsnv.Enabled = true;
                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        btn_nhanvien.Enabled = true;
                        paneldangnhap.Hide();
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        panelqlsach.Enabled = true;

                    }
                    if (quyen == "user")
                    {

                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        btn_nhanvien.Enabled = false;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        //  button8.Enabled = false;
                        paneldangnhap.Hide();
                        panelqlsach.Enabled = true;
                    }
                }

            }
        }

        private void paneldangnhap_Paint(object sender, PaintEventArgs e)
        {

        }
        //    SqlCommand sqlCommand;
    }

}
