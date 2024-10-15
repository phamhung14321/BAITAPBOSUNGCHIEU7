using Lab04_04.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04_04
{
    public partial class QuanLySinhVien : Form
    {
        private StudentModel studentModel = new StudentModel();
        private Student selectedStudent; 


        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnNu.Checked = true;
            txtNam.Text = "0";
            txtNu.Text = "0";
            txtNam.ReadOnly = true;
            txtNu.ReadOnly = true;
            LoadData();
            ClearTextFields();
        }
        private void LoadData()
        {
            List<Student> listStudent = studentModel.Student.ToList();
            List<Faculty> listFaculty = studentModel.Faculty.ToList();
            FillDataCBB(listFaculty);
            FillDataDGV(listStudent);
            UpdateGenderCount();
        }
        private void FillDataDGV(List<Student> listStudent)
        {
            dgvSinhVien.Rows.Clear();
            foreach (var student in listStudent)
            {
                int rowNew = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[rowNew].Cells[0].Value = student.StudentID;
                dgvSinhVien.Rows[rowNew].Cells[1].Value = student.FullName;
                dgvSinhVien.Rows[rowNew].Cells[2].Value = student.Gender;
                dgvSinhVien.Rows[rowNew].Cells[3].Value = student.AverageScore;
                dgvSinhVien.Rows[rowNew].Cells[4].Value = student.Faculty.FacultyName;
            }
        }

        private void FillDataCBB(List<Faculty> listFaculty)
        {
            cmbKhoa.DataSource = listFaculty;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
        }

        private bool CheckDataInput()
        {
            string studentId = txtMSSV.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập đúng thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (studentId.Length != 10 || !long.TryParse(studentId, out _))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ.", "Thông báo");
                return false;
            }
            else
            {
                if (!float.TryParse(txtDiem.Text, out float kq))
                {
                    MessageBox.Show("Điểm sinh viên chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void ClearTextFields()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDiem.Clear();
            cmbKhoa.SelectedIndex = 0; // Reset ComboBox to the first option
            rbtnNu.Checked = true; // Set gender to 'Female' by default
            txtMSSV.ReadOnly = false; // Allow editing MSSV for new entries
        }
        private void LoadDGV()
        {
            List<Student> newListStudent = studentModel.Student.ToList();
            FillDataDGV(newListStudent);
        }

        private bool CheckIdSinhVien(string idNewStudent)
        {
            return studentModel.Student.Any(s => s.StudentID == idNewStudent);
        }
        private void UpdateGenderCount()
        {
            List<Student> listStudent = studentModel.Student.ToList();
            int countNam = listStudent.Count(s => s.Gender == "Nam");
            int countNu = listStudent.Count(s => s.Gender == "Nữ");
            txtNam.Text = countNam.ToString();
            txtNu.Text = countNu.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (!CheckIdSinhVien(txtMSSV.Text))
                {
                    Student newStudent = new Student
                    {
                        StudentID = txtMSSV.Text,
                        FullName = txtHoTen.Text,
                        AverageScore = (float)double.Parse(txtDiem.Text),
                        FacultyID = Convert.ToInt32(cmbKhoa.SelectedValue),
                        Gender = rbtnNam.Checked ? "Nam" : "Nữ"
                    };

                    studentModel.Student.Add(newStudent);
                    studentModel.SaveChanges(); 
                    LoadDGV(); 
                    UpdateGenderCount();
                    ClearTextFields();
                    MessageBox.Show($"Thêm sinh viên {newStudent.FullName} vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Sinh viên có mã số {txtMSSV.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null)
            {
                if (CheckDataInput())
                {
                    string newMSSV = txtMSSV.Text.Trim();
                    if (selectedStudent.StudentID != newMSSV && CheckIdSinhVien(newMSSV))
                    {
                        MessageBox.Show($"Mã số sinh viên {newMSSV} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    selectedStudent.FullName = txtHoTen.Text.Trim();
                    selectedStudent.AverageScore = (float)double.Parse(txtDiem.Text);
                    selectedStudent.FacultyID = Convert.ToInt32(cmbKhoa.SelectedValue);
                    selectedStudent.Gender = rbtnNam.Checked ? "Nam" : "Nữ";

                    studentModel.SaveChanges(); 
                    LoadDGV();
                    UpdateGenderCount();
                    ClearTextFields(); 
                    MessageBox.Show($"Cập nhật thông tin sinh viên {selectedStudent.FullName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedStudent = studentModel.Student.Find(txtMSSV.Text);

            if (selectedStudent == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {selectedStudent.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                studentModel.Student.Remove(selectedStudent);
                studentModel.SaveChanges(); 
                LoadDGV(); 
                UpdateGenderCount();
                ClearTextFields();
                MessageBox.Show($"Xóa sinh viên {selectedStudent.FullName} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string studentId = dgvSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedStudent = studentModel.Student.Find(studentId);

                if (selectedStudent != null)
                {
                    txtMSSV.Text = selectedStudent.StudentID;
                    txtHoTen.Text = selectedStudent.FullName;
                    txtDiem.Text = selectedStudent.AverageScore.ToString();
                    cmbKhoa.SelectedValue = selectedStudent.FacultyID;
                    rbtnNam.Checked = selectedStudent.Gender == "Nam";
                    rbtnNu.Checked = selectedStudent.Gender == "Nữ";
                    // Do not set txtMSSV.ReadOnly = true, allowing MSSV to be editable
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            QuanLyKhoa quanLyKhoaForm = new QuanLyKhoa();
            quanLyKhoaForm.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            TimSinhVien timSinhVien = new TimSinhVien();
            timSinhVien.Show();
        }
    }
}
