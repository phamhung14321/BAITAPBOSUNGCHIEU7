namespace Lab04_04
{
    partial class TimSinhVien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.rbtnNu);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(585, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMSSV,
            this.dgvHoTen,
            this.dgvGioiTinh,
            this.dgvKhoa,
            this.dgvDiem});
            this.dgvSinhVien.Location = new System.Drawing.Point(227, 577);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 102;
            this.dgvSinhVien.RowTemplate.Height = 40;
            this.dgvSinhVien.Size = new System.Drawing.Size(1671, 640);
            this.dgvSinhVien.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(208, 60);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(454, 38);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(208, 127);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(454, 38);
            this.txtHoTen.TabIndex = 1;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(208, 211);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(110, 36);
            this.rbtnNam.TabIndex = 2;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(461, 215);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(87, 36);
            this.rbtnNu.TabIndex = 2;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(208, 295);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(454, 39);
            this.cmbKhoa.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(795, 476);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(205, 52);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1115, 476);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(205, 52);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(1693, 476);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(205, 52);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.MinimumWidth = 12;
            this.dgvMSSV.Name = "dgvMSSV";
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Họ tên";
            this.dgvHoTen.MinimumWidth = 12;
            this.dgvHoTen.Name = "dgvHoTen";
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Giới tính";
            this.dgvGioiTinh.MinimumWidth = 12;
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.HeaderText = "Khoa";
            this.dgvKhoa.MinimumWidth = 12;
            this.dgvKhoa.Name = "dgvKhoa";
            // 
            // dgvDiem
            // 
            this.dgvDiem.HeaderText = "Điểm TB";
            this.dgvDiem.MinimumWidth = 12;
            this.dgvDiem.Name = "dgvDiem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1185, 1287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả tìm kiếm";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(1449, 1284);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(123, 38);
            this.txtKetQua.TabIndex = 4;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // TimSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2230, 1365);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimSinhVien";
            this.Text = "Tìm sinh viên";
            this.Load += new System.EventHandler(this.TimSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}