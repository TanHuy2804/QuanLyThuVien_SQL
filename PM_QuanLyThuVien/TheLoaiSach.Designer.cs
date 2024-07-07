namespace PM_QuanLyThuVien
{
    partial class TheLoaiSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_Loai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpn1madg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_qlnvxoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Lammoi);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.txt_ma);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.dgv_Loai);
            this.panel1.Controls.Add(this.btn_qlnvxoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_themmoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 587);
            this.panel1.TabIndex = 2;
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Lammoi.Location = new System.Drawing.Point(132, 154);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(123, 49);
            this.btn_Lammoi.TabIndex = 31;
            this.btn_Lammoi.Text = "Mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(180, 93);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(239, 30);
            this.txt_ten.TabIndex = 30;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(180, 33);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(239, 30);
            this.txt_ma.TabIndex = 29;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(282, 153);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(137, 50);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_Loai
            // 
            this.dgv_Loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvpn1madg});
            this.dgv_Loai.Location = new System.Drawing.Point(28, 290);
            this.dgv_Loai.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Loai.Name = "dgv_Loai";
            this.dgv_Loai.RowHeadersWidth = 51;
            this.dgv_Loai.Size = new System.Drawing.Size(751, 284);
            this.dgv_Loai.TabIndex = 8;
            this.dgv_Loai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_CellContentClick);
            this.dgv_Loai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loai_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTL";
            this.Column1.HeaderText = "Mã Loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvpn1madg
            // 
            this.dgvpn1madg.DataPropertyName = "TenTL";
            this.dgvpn1madg.HeaderText = "Tên Loại";
            this.dgvpn1madg.MinimumWidth = 6;
            this.dgvpn1madg.Name = "dgvpn1madg";
            // 
            // btn_qlnvxoa
            // 
            this.btn_qlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_qlnvxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlnvxoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlnvxoa.Image = global::PM_QuanLyThuVien.Properties.Resources.xoa;
            this.btn_qlnvxoa.Location = new System.Drawing.Point(556, 193);
            this.btn_qlnvxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_qlnvxoa.Name = "btn_qlnvxoa";
            this.btn_qlnvxoa.Size = new System.Drawing.Size(179, 68);
            this.btn_qlnvxoa.TabIndex = 26;
            this.btn_qlnvxoa.Text = "Xóa";
            this.btn_qlnvxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qlnvxoa.UseVisualStyleBackColor = false;
            this.btn_qlnvxoa.Click += new System.EventHandler(this.btn_qlnvxoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::PM_QuanLyThuVien.Properties.Resources.Sua1;
            this.btn_sua.Location = new System.Drawing.Point(558, 109);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(179, 76);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_themmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_themmoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.Image = global::PM_QuanLyThuVien.Properties.Resources.ThemSach;
            this.btn_themmoi.Location = new System.Drawing.Point(558, 32);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(177, 69);
            this.btn_themmoi.TabIndex = 23;
            this.btn_themmoi.Text = "Thêm";
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themmoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themmoi.UseVisualStyleBackColor = false;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thể Loại";
            // 
            // TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 587);
            this.Controls.Add(this.panel1);
            this.Name = "TheLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể Loại Sách";
            this.Load += new System.EventHandler(this.TheLoaiSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpn1madg;
        private System.Windows.Forms.Button btn_qlnvxoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}