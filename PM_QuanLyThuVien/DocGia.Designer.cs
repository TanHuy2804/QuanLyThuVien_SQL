namespace PM_QuanLyThuVien
{
    partial class DocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneldg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dsdocgia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_chitietmuon = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tendocgia = new System.Windows.Forms.TextBox();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtttcnten = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneldg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdocgia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldg
            // 
            this.paneldg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paneldg.Controls.Add(this.label1);
            this.paneldg.Controls.Add(this.dgv_dsdocgia);
            this.paneldg.Controls.Add(this.groupBox1);
            this.paneldg.Controls.Add(this.btn_thoat);
            this.paneldg.Controls.Add(this.txt_gioitinh);
            this.paneldg.Controls.Add(this.txt_ngaysinh);
            this.paneldg.Controls.Add(this.btn_xoa);
            this.paneldg.Controls.Add(this.btn_sua);
            this.paneldg.Controls.Add(this.btn_themmoi);
            this.paneldg.Controls.Add(this.txt_sodienthoai);
            this.paneldg.Controls.Add(this.txt_diachi);
            this.paneldg.Controls.Add(this.txt_tendocgia);
            this.paneldg.Controls.Add(this.txt_madocgia);
            this.paneldg.Controls.Add(this.label19);
            this.paneldg.Controls.Add(this.label17);
            this.paneldg.Controls.Add(this.label16);
            this.paneldg.Controls.Add(this.label14);
            this.paneldg.Controls.Add(this.label13);
            this.paneldg.Controls.Add(this.txtttcnten);
            this.paneldg.Controls.Add(this.label11);
            this.paneldg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldg.Location = new System.Drawing.Point(-14, -4);
            this.paneldg.Margin = new System.Windows.Forms.Padding(4);
            this.paneldg.Name = "paneldg";
            this.paneldg.Size = new System.Drawing.Size(1358, 754);
            this.paneldg.TabIndex = 4;
            this.paneldg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Sách Độc Giả";
            // 
            // dgv_dsdocgia
            // 
            this.dgv_dsdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsdocgia.Location = new System.Drawing.Point(32, 290);
            this.dgv_dsdocgia.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dsdocgia.Name = "dgv_dsdocgia";
            this.dgv_dsdocgia.RowHeadersWidth = 51;
            this.dgv_dsdocgia.Size = new System.Drawing.Size(897, 304);
            this.dgv_dsdocgia.TabIndex = 29;
            this.dgv_dsdocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsdocgia_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_chitietmuon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(948, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(351, 335);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết mượn sách";
            // 
            // dgv_chitietmuon
            // 
            this.dgv_chitietmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietmuon.Location = new System.Drawing.Point(25, 31);
            this.dgv_chitietmuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_chitietmuon.Name = "dgv_chitietmuon";
            this.dgv_chitietmuon.RowHeadersWidth = 51;
            this.dgv_chitietmuon.Size = new System.Drawing.Size(300, 304);
            this.dgv_chitietmuon.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.Image = global::PM_QuanLyThuVien.Properties.Resources.Thoat;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.Location = new System.Drawing.Point(973, 627);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(184, 73);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_gioitinh.Location = new System.Drawing.Point(301, 186);
            this.txt_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(236, 30);
            this.txt_gioitinh.TabIndex = 25;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_ngaysinh.CalendarForeColor = System.Drawing.Color.White;
            this.txt_ngaysinh.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ngaysinh.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ngaysinh.CustomFormat = "dd-MM-yyyy";
            this.txt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngaysinh.Location = new System.Drawing.Point(814, 182);
            this.txt_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaysinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(265, 30);
            this.txt_ngaysinh.TabIndex = 24;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.Image = global::PM_QuanLyThuVien.Properties.Resources.xoa;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.Location = new System.Drawing.Point(718, 627);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(193, 73);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sua.Image = global::PM_QuanLyThuVien.Properties.Resources.Sua;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.Location = new System.Drawing.Point(473, 627);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(187, 73);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_themmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_themmoi.Image = global::PM_QuanLyThuVien.Properties.Resources.themdg;
            this.btn_themmoi.Location = new System.Drawing.Point(214, 627);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(197, 73);
            this.btn_themmoi.TabIndex = 19;
            this.btn_themmoi.Text = "Thêm";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themmoi.UseVisualStyleBackColor = false;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_sodienthoai.Location = new System.Drawing.Point(814, 134);
            this.txt_sodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(265, 30);
            this.txt_sodienthoai.TabIndex = 16;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_diachi.Location = new System.Drawing.Point(814, 91);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(265, 30);
            this.txt_diachi.TabIndex = 14;
            // 
            // txt_tendocgia
            // 
            this.txt_tendocgia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tendocgia.Location = new System.Drawing.Point(301, 134);
            this.txt_tendocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendocgia.Name = "txt_tendocgia";
            this.txt_tendocgia.Size = new System.Drawing.Size(236, 30);
            this.txt_tendocgia.TabIndex = 11;
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_madocgia.Location = new System.Drawing.Point(301, 91);
            this.txt_madocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(236, 30);
            this.txt_madocgia.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(352, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(577, 42);
            this.label19.TabIndex = 8;
            this.label19.Text = "THÔNG TIN CHI TIẾT ĐỘC GIẢ";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(652, 186);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "Ngày sinh :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(652, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 26);
            this.label16.TabIndex = 5;
            this.label16.Text = "SĐT :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(652, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "Địa chỉ :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(159, 182);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giới tính :";
            // 
            // txtttcnten
            // 
            this.txtttcnten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtttcnten.AutoSize = true;
            this.txtttcnten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttcnten.ForeColor = System.Drawing.Color.Black;
            this.txtttcnten.Location = new System.Drawing.Point(159, 134);
            this.txtttcnten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtttcnten.Name = "txtttcnten";
            this.txtttcnten.Size = new System.Drawing.Size(106, 26);
            this.txtttcnten.TabIndex = 1;
            this.txtttcnten.Text = "Tên ĐG :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(159, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã ĐG :";
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 734);
            this.Controls.Add(this.paneldg);
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.paneldg.ResumeLayout(false);
            this.paneldg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdocgia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietmuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dsdocgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_chitietmuon;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tendocgia;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtttcnten;
        private System.Windows.Forms.Label label11;
    }
}