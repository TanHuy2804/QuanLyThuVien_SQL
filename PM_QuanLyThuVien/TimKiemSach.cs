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
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();
        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv_TTsach, "select * from SACH");
            cls.LoadData2DataGridView(dgv_TTDG, "select * from DOCGIA");
        }

        private void cbo_TKSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = cbo_TKSach.Text;
        }

        private void btn_TKSach_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Mã Sách")
                cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where masach like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Tên Sách") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where Tensach like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Mã NXB") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where manxb like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Mã Thể Loại") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where matl like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Số Lượng") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where soluong like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Số Trang") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where sotrang like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "SL Sách Hỏng") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where sosachhong like'%" + txt_TKSach.Text + "%'");
            else if (label8.Text == "Giá Sách") cls.LoadData2DataGridView(dgv_TTsach, "select*from Sach where gia like'%" + txt_TKSach.Text + "%'");
        }

        private void btn_ThoatSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TKDG_Click(object sender, EventArgs e)
        {
            //  cls.LoadData2DataGridView(dataGridView2, "select*from docgia where Masach like'%" + textBox2.Text + "%'");
            if (label9.Text == "Mã ĐG")
                cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where MaDG like'%" + txt_TKDG.Text + "%'");
            else if (label9.Text == "SĐT") cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where SDT_EMAIL like'%" +  txt_TKDG.Text + "%'");
            else if (label9.Text == "Tên ĐG") cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where TenDG like'%" + txt_TKDG.Text + "%'");
            else if (label9.Text == "Giới Tính") cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where GioiTinh like'%" + txt_TKDG.Text + "%'");
            else if (label9.Text == "Địa Chỉ") cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where DiaChi like'%" + txt_TKDG.Text + "%'");
            else if (label9.Text == "Ngày Sinh") cls.LoadData2DataGridView(dgv_TTDG, "select*from docgia where NgaySinh like'%" + txt_TKDG.Text + "%'");
        }

        private void txt_TKDG_TextChanged(object sender, EventArgs e)
        {
            label9.Text = cbo_TKDG.Text;
        }

        private void btn_ThoatDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
