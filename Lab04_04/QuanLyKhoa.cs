using Lab04_04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class QuanLyKhoa : Form
    {
        private StudentModel studentModel = new StudentModel(); // Model chứa dữ liệu khoa
        private Faculty selectedFaculty;
        private int TongGS = 0;

        public QuanLyKhoa()
        {
            InitializeComponent();
            
        }

        private void QuanLyKhoa_Load_1(object sender, EventArgs e)
        {
            txtTongGS.Text = "0"; // Khởi tạo tổng số GS ban đầu
            LoadData(); // Nạp dữ liệu khi form load
            cmbSapXep.Items.Add("Tăng dần");
            cmbSapXep.Items.Add("Giảm dần");
            textBox1.Enabled = false;

        }

        // Nạp dữ liệu từ cơ sở dữ liệu
        private void LoadData()
        {
            List<Faculty> listFaculty = studentModel.Faculty.ToList();
            FillDataDGV(listFaculty);
            UpdateGSCount();
        }

        // Điền các lựa chọn sắp xếp vào ComboBox
        private void FillDataDGV(List<Faculty> listFaculty)
        {
            dgvKhoa.Rows.Clear();
            foreach (var faculty in listFaculty)
            {
                int rowNew = dgvKhoa.Rows.Add();
                dgvKhoa.Rows[rowNew].Cells[0].Value = faculty.FacultyID;
                dgvKhoa.Rows[rowNew].Cells[1].Value = faculty.FacultyName;
                dgvKhoa.Rows[rowNew].Cells[2].Value = faculty.TotalProfessor;
            }
        }
        private bool CheckDataInput()
        {
            string facultyId = txtMaKhoa.Text.Trim();
            string facultyName = txtKhoa.Text.Trim();
            string totalProfessorText = txtTongGS.Text.Trim();

            if (string.IsNullOrWhiteSpace(facultyId) || string.IsNullOrWhiteSpace(facultyName) || string.IsNullOrWhiteSpace(totalProfessorText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            if (!int.TryParse(facultyId, out int facultyID))
            {
                MessageBox.Show("Mã khoa không hợp lệ. Vui lòng chỉ nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Clear(); 
                txtMaKhoa.Focus(); 
                return false;
            }


            if (facultyName.Length < 3 || facultyName.Length > 100 || facultyName.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên khoa phải từ 3 đến 100 ký tự và không chứa ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Clear();
                txtKhoa.Focus(); 
                return false;
            }


            if (!int.TryParse(totalProfessorText, out int totalProfessor) || totalProfessor < 0 || totalProfessor > 15)
            {
                MessageBox.Show("Tổng số giáo sư không hợp lệ. Phải từ 0 đến 15.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongGS.Clear(); 
                txtTongGS.Focus(); 
                return false;
            }

            return true;
        }
        private void LoadDGV()
        {
            List<Faculty> newListFaculty = studentModel.Faculty.ToList();
            FillDataDGV(newListFaculty);
        }

        private void UpdateGSCount()
        {
            List<Faculty> listFaculty = studentModel.Faculty.ToList();

            int totalProfessorCount = listFaculty.Sum(f => f.TotalProfessor);

            textBox1.Text = totalProfessorCount.ToString();
        }
        private bool CheckIdKhoa(string idNewFaculty)
        {
            if (int.TryParse(idNewFaculty, out int facultyID))
            {
                return studentModel.Faculty.Any(f => f.FacultyID == facultyID);
            }
            else
            {
                MessageBox.Show("Mã khoa không hợp lệ. Vui lòng chỉ nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Nếu không thể chuyển đổi, trả về false
            }
        }
        // Thêm khoa mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (!CheckIdKhoa(txtMaKhoa.Text))
                {
                    Faculty newFaculty = new Faculty
                    {
                        FacultyID = int.Parse(txtMaKhoa.Text.Trim()),
                        FacultyName = txtKhoa.Text.Trim(),
                        TotalProfessor = int.Parse(txtTongGS.Text.Trim())
                    };

                    // Add new faculty to the database
                    studentModel.Faculty.Add(newFaculty); // Make sure to add it to the DbSet
                    studentModel.SaveChanges(); // Save changes to the database

                    UpdateGSCount(); // Update the total number of professors
                    LoadDGV();
                    ClearTextFields();// Reload the DataGridView
                    MessageBox.Show($"Thêm khoa {newFaculty.FacultyName} vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Khoa có mã số {txtMaKhoa.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (selectedFaculty != null)
            {
                if (CheckDataInput())
                {
                    selectedFaculty.FacultyID = int.Parse(txtMaKhoa.Text.Trim());
                    selectedFaculty.FacultyName = txtKhoa.Text.Trim();
                    selectedFaculty.TotalProfessor = int.Parse(txtTongGS.Text.Trim()); // Chuyển đổi từ string sang int

                    studentModel.SaveChanges();
                    UpdateGSCount();
                    LoadDGV();
                    ClearTextFields();

                    MessageBox.Show($"Cập nhật thông tin khoa {selectedFaculty.FacultyName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedFaculty = studentModel.Faculty.Find(int.Parse(txtMaKhoa.Text));

            if (selectedFaculty == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoa {selectedFaculty.FacultyName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                studentModel.Faculty.Remove(selectedFaculty);
                studentModel.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                LoadDGV(); // Tải lại DataGridView
                UpdateGSCount();
                ClearTextFields();// Cập nhật số lượng sau khi tải dữ liệu mới
                MessageBox.Show($"Xóa khoa {selectedFaculty.FacultyName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        // Xóa nội dung trong các ô nhập liệu
        private void ClearTextFields()
        {
            txtMaKhoa.Clear();
            txtKhoa.Clear();
            txtTongGS.Clear();
        }

        // Xử lý sự kiện sắp xếp
        private void cmbSapXep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<Faculty> listFaculty = studentModel.Faculty.ToList(); // Lấy danh sách khoa ban đầu

            // Kiểm tra tùy chọn đã chọn
            switch (cmbSapXep.SelectedItem.ToString())
            {
                case "Tăng dần":
                    listFaculty = listFaculty.OrderBy(f => f.TotalProfessor).ToList(); // Sắp xếp tăng dần
                    break;
                case "Giảm dần":
                    listFaculty = listFaculty.OrderByDescending(f => f.TotalProfessor).ToList(); // Sắp xếp giảm dần
                    break;
            }

            FillDataDGV(listFaculty); // Hiển thị dữ liệu đã sắp xếp
        }



        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn
            {
                string facultyId = dgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString(); // Lấy mã khoa
                selectedFaculty = studentModel.Faculty.Find(int.Parse(facultyId)); // Tìm khoa theo mã khoa

                if (selectedFaculty != null) // Nếu tìm thấy khoa
                {
                    txtMaKhoa.Text = selectedFaculty.FacultyID.ToString(); // Cập nhật mã khoa
                    txtKhoa.Text = selectedFaculty.FacultyName; // Cập nhật tên khoa
                    txtTongGS.Text = selectedFaculty.TotalProfessor.ToString(); // Cập nhật tổng số giáo sư
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
