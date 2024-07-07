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
    public partial class QuanLyMuon : Form
    {
        public QuanLyMuon()
        {
            InitializeComponent();
        }
        Connect cls = new PM_QuanLyThuVien.Connect();
        private void HienThi_PM()
        {


            cls.LoadData2DataGridView(dgv_pn1, "select * from PHIEUMUON");

        }
        private void HienThi_QL()
        {

            cls.LoadData2DataGridView(dgv_pn2, "select * from QL_PHIEUMUON WHERE MAPM='" + txt_pn1mapm.Text + "'");
        }
        private void insert_PM()
        {

            //else { 
            string s1 = dtt_pn1ngaymuon.Value.Year + "/" + dtt_pn1ngaymuon.Value.Month + "/" + dtt_pn1ngaymuon.Value.Day;
            string sql = "insert into PHIEUMUON (MaPM,MaDG,TaiKhoan, NgayMuon) values('" + txt_pn1mapm.Text + "','" + cbo_pn1madg.Text + "','" + cbo_pn1manv.Text + "',convert(smalldatetime,'" + s1.ToString() + "')) ";

            cls.ThucThiSQLTheoKetNoi(sql);
        }


        private void update_PM()
        {
            string s1 = dtt_pn1ngaymuon.Value.Year + "/" + dtt_pn1ngaymuon.Value.Month + "/" + dtt_pn1ngaymuon.Value.Day;
            string cmd = "update PHIEUMUON set MaDG='" + cbo_pn1madg.Text + "',NgayMuon=convert(smalldatetime,'" + s1.ToString() + "'),TaiKhoan='" + cbo_pn1manv.Text + "' where MaPM='" + txt_pn2mapm.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void update_QL()
        {

            string s2 = dtt_pn2hantra.Value.Year + "/" + dtt_pn2hantra.Value.Month + "/" + dtt_pn2hantra.Value.Day;
            string cmd = "update QL_PHIEUMUON set MaSach='" + cbo_pn2masach.Text + "',HanTra=convert(smalldatetime,'" + s2.ToString() + "'), SoLuongSM='" + txt_sdsachmuon.Text + "' where MaPM='" + txt_pn1mapm.Text + "' and MaSach='" + cbo_pn2masach.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);
        }

        private void delete_PT()
        {
            string s2 = dtt_pn2hantra.Value.Year + "/" + dtt_pn2hantra.Value.Month + "/" + dtt_pn2hantra.Value.Day;

            string cmd = "delete from TRASACH where MaPM='" + txt_pn1mapm.Text + "'and MaSach='" + cbo_pn2masach.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void insert_PT()
        {
            string s1 = dtt_pn2hantra.Value.Year + "/" + dtt_pn2hantra.Value.Month + "/" + dtt_pn2hantra.Value.Day;
            string sql = "insert into TRASACH (MaPM,MaSach,TaiKhoan,NgayTra,PhatQuaHan) values ('" + txt_pn1mapm.Text + "','" + cbo_pn2masach.Text + "','" + cbo_pn1manv.Text + "',convert(smalldatetime,'" + s1.ToString() + "'),'0')";

            cls.ThucThiSQLTheoKetNoi(sql);
        }


        private void QuanLyMuon_Load(object sender, EventArgs e)
        {
            txt_pn1mapm.Enabled = false;
            txt_pn2mapm.Enabled = false;
            // ketnoi();


            cls.KetNoi();
            HienThi_PM();
            HienThi_QL();

            cls.LoadCombo(cbo_pn2masach, "select masach from Sach");
            cls.LoadCombo(cbo_pn1madg, "select MaDG from DOCGIA");


            cls.LoadCombo(cbo_pn1manv, "select TaiKhoan from NHANVIEN");
        }
        private void insert_QL()
        {

            string s2 = dtt_pn2hantra.Value.Year + "/" + dtt_pn2hantra.Value.Month + "/" + dtt_pn2hantra.Value.Day;
            string cmd = "insert into QL_PHIEUMUON (MaPM,MaSach,HanTra,SoLuongSM) values('" + txt_pn2mapm.Text + "','" + cbo_pn2masach.Text + "',convert(smalldatetime,'" + s2.ToString() + "'),'" + txt_sdsachmuon.Text + "')";

            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void delete_PM()
        {

            string cmd = "delete from PHIEUMUON where MaPM='" + txt_pn1mapm.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);


        }
        private void delete_QL()

        {

            string s2 = dtt_pn2hantra.Value.Year + "/" + dtt_pn2hantra.Value.Month + "/" + dtt_pn2hantra.Value.Day;
            string cmd = "delete from QL_PHIEUMUON where  MaSach='" + cbo_pn2masach.Text + "'and mapm='" + txt_pn2mapm.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);

        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            if (btn_themmoi.Text == "Add")
            {

                txt_pn2mapm.Enabled = false;
                txt_pn1mapm.Enabled = true;
                cbo_pn1madg.Text = "";
                cbo_pn1manv.Text = "";
                txt_pn1mapm.Clear();
                txt_pn2mapm.Clear();
                cbo_pn2masach.Text = "";
                txt_pn1mapm.Focus();
                btn_sua.Enabled = false;
                btn_themmoi.Text = "OK";
                return;
            }
            else
            {

                btn_sua.Enabled = true;
                txt_pn1mapm.Enabled = false;
                txt_pn2mapm.Enabled = false;
                string mapm = "select COUNT(mapm) from PHIEUMUON WHERE MAPM='" + txt_pn1mapm.Text + "'";

                int slg = cls.CheckID(mapm);
                if (slg > 0) MessageBox.Show("Thẻ mượn đã tồn tại!");
                else if (txt_pn1mapm.Text == "")
                {
                    MessageBox.Show("Thẻ mượn trống!");
                }
                else if (cbo_pn1madg.Text == "")
                {
                    MessageBox.Show("ID người đọc trống!");
                }
                else
                // if()

                {
                    string s1 = dtt_pn1ngaymuon.Value.Year + "/" + dtt_pn1ngaymuon.Value.Month + "/" + dtt_pn1ngaymuon.Value.Day;
                    string tm = "select count(mapm) from phieumuon where madg='" + cbo_pn1madg.Text + "'and NgayMuon= convert(smalldatetime,'" + s1.ToString() + "')";

                    int slt = cls.CheckID(tm);
                    if (slt > 0) MessageBox.Show("Mỗi độc giả chỉ đăng ký một thẻ mượn mỗi ngày!");
                    else
                    {
                        insert_PM();
                        HienThi_PM();
                        MessageBox.Show("Hoàn tất!");
                    }


                }
                btn_themmoi.Text = "Add";
                return;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete1 = "DELETE TRASACH WHERE MAPM='" + txt_pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                string delete2 = "DELETE QL_PHIEUMUON WHERE MAPM='" + txt_pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete2);
                string delete = "delete from phieumuon where Mapm='" + txt_pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete);
            }
            cls.LoadData2DataGridView(dgv_pn1, "select *from phieumuon");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update_PM();
            MessageBox.Show("Sửa hoàn tất!");
            HienThi_PM();
        }

        private void dgv_pn1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txt_pn1mapm.Text = dgv_pn1.Rows[i].Cells[0].Value.ToString().Trim();
                cbo_pn1madg.Text = dgv_pn1.Rows[i].Cells[1].Value.ToString().Trim();
                cbo_pn1manv.Text = dgv_pn1.Rows[i].Cells[2].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgv_pn1.Rows[i].Cells[3].Value.ToString());
                dtt_pn1ngaymuon.Value = dt;


                cls.LoadData2DataGridView(dgv_pn2, "select * from QL_PHIEUMUON WHERE MAPM='" + txt_pn1mapm.Text + "'");
                cls.LoadData2DataGridView(dgv_TTDG, "select * from DOCGIA WHERE MADG='" + cbo_pn1madg.Text + "'");
            }
            catch (Exception)
            {

            }
        }

        private void txt_pn1mapm_TextChanged(object sender, EventArgs e)
        {
            txt_pn2mapm.Text = txt_pn1mapm.Text.ToString();
        }

        private void dgv_pn2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {

                txt_pn1mapm.Text = dgv_pn2.Rows[i].Cells[0].Value.ToString().Trim();
                cbo_pn2masach.Text = dgv_pn2.Rows[i].Cells[1].Value.ToString().Trim();

                DateTime dt1 = Convert.ToDateTime(dgv_pn2.Rows[i].Cells[2].Value.ToString());
                dtt_pn2hantra.Value = dt1;
                txt_sdsachmuon.Text = dgv_pn2.Rows[i].Cells[3].Value.ToString().Trim();
                txt_pn2mapm.Text = txt_pn1mapm.Text.ToString().Trim();

                cls.LoadData2DataGridView(dgv_TTSach, "select * from SACH where masach='" + cbo_pn2masach.Text + "'");

            }
            catch (Exception) { }
        }

        private void btn_pn2xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cmd1 = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + cbo_pn2masach.Text + "' and Mapm='" + txt_pn2mapm.Text + "') from sach where MaSach='" + cbo_pn2masach.Text + "'";

                cls.ThucThiSQLTheoKetNoi(cmd1);
                delete_QL();
                delete_PT();


            }
            HienThi_QL();
            //  textBox2.Clear();
            txt_sdsachmuon.Clear();
        }

        private void btn_muon_Click(object sender, EventArgs e)
        {
            if (txt_sdsachmuon.Text == "")
            {
                MessageBox.Show("Số lượng đang trống!");
            }
            else
            {
                string s1 = "select SoSachHong from SACH where masach='" + cbo_pn2masach.Text + "'";
                string s2 = "select SoLuong from sach where masach='" + cbo_pn2masach.Text + "'";

                int S1 = Int32.Parse(txt_sdsachmuon.Text);
                if (S1 > 5)
                {
                    MessageBox.Show("Không thể mượn hơn 5 cuốn sách cho mỗi loại sách!");
                }

                else
                {
                    int S3 = cls.account(s1);

                    int S2 = cls.account(s2);
                    if (S1 > S2 - S3) MessageBox.Show("Số lượng sách mượn lớn hơn số lượng sách có sẵn!");
                    else
                    {
                        update_QL();
                        string masach = "select count(masach) from QL_PHIEUMUON where mapm='" + txt_pn1mapm.Text + "' and masach='" + cbo_pn2masach.Text + "'";

                        int sl = cls.CheckID(masach);
                        if (sl > 0) MessageBox.Show("Cuốn sách này đã được mượn từ thẻ mượn hiện tại, vui lòng cập nhật số lượng nếu bạn muốn mượn thêm sách!");
                        else
                        {
                            insert_QL();

                            string tongsachmuon = "select isnull(sum(soluongSM),0) from PHIEUMUON, QL_PHIEUMUON where PHIEUMUON.MaPM= QL_PHIEUMUON.MaPM and madg='" + cbo_pn1madg.Text + "'";
                            int tongmuon = cls.account(tongsachmuon);
                            if (tongmuon > 20)
                            {
                                MessageBox.Show("Mỗi độc giả chỉ có thể mượn tối đa 20 cuốn sách!");
                                delete_QL();
                            }
                            else
                            {
                                string cmd = "update SACH set SoLuong = SoLuong -(select soluongSm from ql_phieumuon where MaSach='" + cbo_pn2masach.Text + "' and Mapm='" + txt_pn2mapm.Text + "') from sach where MaSach='" + cbo_pn2masach.Text + "' ";

                                cls.ThucThiSQLTheoKetNoi(cmd);

                                insert_PT();

                                HienThi_QL();
                                MessageBox.Show("Hoàn tất!");
                            }

                        }
                    }
                }
            }
         }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dgv_pn1, "select * from PHIEUMUON where maDG='" + txt_Madocgia.Text + "'");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            txt_Madocgia.Clear();
            cls.LoadData2DataGridView(dgv_pn1, "select * from PHIEUMUON");
        }

        private void btn_pn2sua_Click(object sender, EventArgs e)
        {
            update_QL();
            string masach = "select count(masach) from QL_PHIEUMUON where mapm='" + txt_pn1mapm.Text + "' and masach='" + cbo_pn2masach.Text + "'";

            int sl = cls.CheckID(masach);
            if (sl == 0)
            {
                MessageBox.Show("Cuốn sách này không có sẵn trên thẻ mượn, vui lòng chọn mục 'Mượn sách' để mượn!");

            }
            else
            {

                string cmd1 = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + cbo_pn2masach.Text + "' and Mapm='" + txt_pn2mapm.Text + "') from sach where MaSach='" + cbo_pn2masach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd1);
                update_QL();
                MessageBox.Show("Cập nhật thành công!");

                string cmd = "update SACH set SoLuong = SoLuong -(select soluongSm from ql_phieumuon where MaSach='" + cbo_pn2masach.Text + "' and Mapm='" + txt_pn2mapm.Text + "') from sach where MaSach='" + cbo_pn2masach.Text + "' ";
                cls.ThucThiSQLTheoKetNoi(cmd);

                insert_PT();

                HienThi_QL();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportPhieuMuon pn = new ReportPhieuMuon();
            pn.ShowDialog();
        }
    }
}
        