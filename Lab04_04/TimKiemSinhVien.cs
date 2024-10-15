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

namespace Lab04_04
{
    public partial class TimSinhVien : Form
    {
        private StudentModel studentModel = new StudentModel();
        private Student selectedStudent;

        public TimSinhVien()
        {
            InitializeComponent();
        }

        private void TimSinhVien_Load(object sender, EventArgs e)
        {
            rbtnNu.Checked = true;
            txtKetQua.Text = "0";
            txtKetQua.ReadOnly = true;
            LoadData();
            txtKetQua.Enabled = false;
            rbtnNu.Checked = true;
        }
        private void LoadData()
        {
            List<Student> listStudent = studentModel.Student.ToList();
            List<Faculty> listFaculty = studentModel.Faculty.ToList();
            FillDataCBB(listFaculty);
            FillDataDGV(listStudent);
            UpdateKQCount();
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
        private void UpdateKQCount()
        {
            List<Student> listStudent = studentModel.Student.ToList();
            int totalStudents = listStudent.Count();
            txtKetQua.Text = totalStudents.ToString();

        }
        private void FillDataCBB(List<Faculty> listFaculty)
        {
            cmbKhoa.DataSource = listFaculty;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
        }
        private void ClearTextFields()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
        }
        private void LoadDGV()
        {
            List<Student> newListStudent = studentModel.Student.ToList();
            FillDataDGV(newListStudent);
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string studentID = txtMSSV.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            string gender = rbtnNam.Checked ? "Nam" : "Nữ";
            int? facultyId = cmbKhoa.SelectedValue as int?;

            var searchResults = studentModel.Student.AsQueryable();

            if (!string.IsNullOrWhiteSpace(studentID))
                searchResults = searchResults.Where(s => s.StudentID.ToString() == studentID);

            if (!string.IsNullOrWhiteSpace(fullName))
                searchResults = searchResults.Where(s => s.FullName.Contains(fullName));

            searchResults = searchResults.Where(s => s.Gender == gender);

            if (facultyId.HasValue)
            {
                searchResults = searchResults.Where(s => s.FacultyID == facultyId.Value);
            }

            var resultList = searchResults.ToList();
            FillDataDGV(resultList);
            txtKetQua.Text = resultList.Count.ToString();

            if (resultList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào thỏa mãn tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                UpdateKQCount();
                ClearTextFields();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
