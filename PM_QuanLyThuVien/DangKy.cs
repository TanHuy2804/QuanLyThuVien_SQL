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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();
        private void DangKy_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string mapm = "select COUNT(TaiKhoan) from NHANVIEN WHERE TaiKhoan='" + txt_TenDangNhap.Text + "'";
            int slg = cls.CheckID(mapm);
            //(int)sl.ExecuteScalar();
            if (slg > 0) MessageBox.Show("Tài Khoản đã tồn tại!");
            else if (txt_TenDangNhap.Text.Length - 1 < 5)
                MessageBox.Show(" Tên người dùng quá ngắn!");
            else if (txt_TenDangNhap.Text.Length - 1 > 30)
                MessageBox.Show("Tên người dùng quá dài!");
            else if (txt_MatKhau.Text.Length - 1 < 5)
                MessageBox.Show("Mật khẩu quá ngắn!");
            else if (txt_NhapLai.Text.Length - 1 > 30)
                MessageBox.Show("Mật khẩu quá dài");
            else if (txt_MatKhau.Text != txt_NhapLai.Text)
                MessageBox.Show("Mật khẩu không khớp!");
            else
            {
                string sql = "insert into NHANVIEN(TaiKhoan, MatKhau, Quyenhan) values('" + txt_TenDangNhap.Text + "', '" + txt_MatKhau.Text + "', 'user')";
                // SqlCommand cmd = new SqlCommand(sql, cnn);
                //  cmd.ExecuteNonQuery();
                cls.ThucThiSQLTheoKetNoi(sql);
                //cls.ThucThiSQLTheoKetNoi(sql);
                MessageBox.Show("Đăng kí thàn công! Hãy cập nhật thông tin trong phần thông tin cá nhân");
            }
        }

        private void ckb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienThi.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
                txt_NhapLai.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
                txt_NhapLai.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
