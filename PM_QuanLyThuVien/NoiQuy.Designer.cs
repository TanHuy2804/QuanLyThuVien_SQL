namespace PM_QuanLyThuVien
{
    partial class NoiQuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoiQuy));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_daro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(173, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "NỘI QUY THƯ VIỆN";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(133, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 515);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btn_daro
            // 
            this.btn_daro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_daro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daro.ForeColor = System.Drawing.Color.Black;
            this.btn_daro.Location = new System.Drawing.Point(364, 675);
            this.btn_daro.Name = "btn_daro";
            this.btn_daro.Size = new System.Drawing.Size(191, 36);
            this.btn_daro.TabIndex = 4;
            this.btn_daro.Text = "Đã Rõ";
            this.btn_daro.UseVisualStyleBackColor = false;
            this.btn_daro.Click += new System.EventHandler(this.btn_daro_Click);
            // 
            // NoiQuy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PM_QuanLyThuVien.Properties.Resources.nennoiquy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 723);
            this.Controls.Add(this.btn_daro);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "NoiQuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nội Quy Thư Viện";
            this.Load += new System.EventHandler(this.NoiQuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_daro;
    }
}