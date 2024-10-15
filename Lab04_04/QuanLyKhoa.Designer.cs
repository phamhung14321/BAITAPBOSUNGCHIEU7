namespace Lab04_04
{
    partial class QuanLyKhoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSapXep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.dgvMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(826, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(763, 135);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(95, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongGS);
            this.groupBox2.Controls.Add(this.txtMaKhoa);
            this.groupBox2.Controls.Add(this.txtKhoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(57, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 414);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khoa";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(223, 323);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(352, 38);
            this.txtTongGS.TabIndex = 4;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(223, 92);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(352, 38);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(223, 204);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(352, 38);
            this.txtKhoa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số GS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khoa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSapXep);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(57, 689);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 145);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // cmbSapXep
            // 
            this.cmbSapXep.FormattingEnabled = true;
            this.cmbSapXep.Location = new System.Drawing.Point(223, 73);
            this.cmbSapXep.Name = "cmbSapXep";
            this.cmbSapXep.Size = new System.Drawing.Size(352, 39);
            this.cmbSapXep.TabIndex = 1;
            this.cmbSapXep.SelectedIndexChanged += new System.EventHandler(this.cmbSapXep_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Săp xếp";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKhoa,
            this.dgvTenKhoa,
            this.dgvTongGS});
            this.dgvKhoa.Location = new System.Drawing.Point(783, 265);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 102;
            this.dgvKhoa.RowTemplate.Height = 40;
            this.dgvKhoa.Size = new System.Drawing.Size(1509, 722);
            this.dgvKhoa.TabIndex = 5;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // dgvMaKhoa
            // 
            this.dgvMaKhoa.HeaderText = "Mã khoa";
            this.dgvMaKhoa.MinimumWidth = 12;
            this.dgvMaKhoa.Name = "dgvMaKhoa";
            // 
            // dgvTenKhoa
            // 
            this.dgvTenKhoa.HeaderText = "Tên khoa";
            this.dgvTenKhoa.MinimumWidth = 12;
            this.dgvTenKhoa.Name = "dgvTenKhoa";
            // 
            // dgvTongGS
            // 
            this.dgvTongGS.HeaderText = "Tổng GS";
            this.dgvTongGS.MinimumWidth = 12;
            this.dgvTongGS.Name = "dgvTongGS";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 937);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(294, 937);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 50);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(527, 937);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 50);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1082, 1107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 38);
            this.textBox1.TabIndex = 7;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(2030, 1084);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(158, 82);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 1110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng số GS";
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2763, 1218);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyKhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.QuanLyKhoa_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbSapXep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongGS;
    }
}