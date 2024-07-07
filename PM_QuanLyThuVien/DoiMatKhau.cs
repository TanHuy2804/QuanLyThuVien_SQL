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
    public partial class DoiMatKhau : Form
    {
        private string _message;
        private string _manv;
        private string _mk;
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Connect cls =  new PM_QuanLyThuVien.Connect();
        public string MK
        {
            get { return _mk; }
            set { _mk = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            lbltaikhoan.Text = _message;

            cls.KetNoi();
            if (_message != null)
            {
                panel1.Visible = true;
                // panel2.Hide();
            }
            if (_manv != null)
            {
                panel1.Hide();
                //    panel2.Visible = true;
            }
        
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            if (txt_MKcu.Text == _mk)
            {
                if (txt_mkmoi.Text == txt_nhaplaimk.Text)
                {
                    try
                    {
                        string sql = "update NHANVIEN set MatKhau='" + txt_mkmoi.Text + "' where TaiKhoan='" + lbltaikhoan.Text + "' ";
                        //SqlCommand cmd = new SqlCommand(sql, cnn);
                        // cmd.ExecuteNonQuery();
                        cls.ThucThiSQLTheoKetNoi(sql);
                        MessageBox.Show("Thay đổi tài khoản thành công!");
                    }
                    catch (Exception) { MessageBox.Show("Error!"); }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!");
                    txt_mkmoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!");
                txt_MKcu.Focus();
            }
        }

        private void ckb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_hienthi.Checked == true)
            {
                txt_MKcu.PasswordChar = '\0';
                txt_nhaplaimk.PasswordChar = '\0';
                txt_mkmoi.PasswordChar = '\0';
            }
            if (ckb_hienthi.Checked == false)
            {
                txt_MKcu.PasswordChar = '*';
                txt_mkmoi.PasswordChar = '*';
                txt_nhaplaimk.PasswordChar = '*';
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltaikhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
