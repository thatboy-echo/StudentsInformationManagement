using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsInformationManagement.Role;

namespace StudentsInformationManagement
{
    public partial class TeacherManagement : Form
    {
        public TeacherManagement()
        {
            InitializeComponent();

            studentInfoWidget.mailTextBox.ReadOnly = true;
            studentInfoWidget.phoneTextBox.ReadOnly = true;
            studentInfoWidget.Parent = studentInfoLayout;
            scoreInfoWidget.Parent = studentInfoLayout;
            scoreInfoWidget.scoreGridView.ReadOnly = false;
            scoreInfoWidget.scoreGridView.AllowUserToAddRows = true;
            scoreInfoWidget.scoreGridView.AllowUserToDeleteRows = true;
            updateStudentList();
        }


        public void updateStudentList()
        {
            var studentList = Program.studentList;
            studentGridView.RowCount = studentList.Count + 1;
            for (int i = 0; i < studentList.Count; i++)
            {
                var student = studentList.ElementAt(i);
                studentGridView["id", i].Value = student.id;
                studentGridView["gender", i].Value = student.gender;
                studentGridView["name", i].Value = student.name;
                studentGridView["major", i].Value = student.major;
                studentGridView["phone", i].Value = student.phone;
                studentGridView["mail", i].Value = student.mail;
            }
        }

        StudentInfoWidget studentInfoWidget = new StudentInfoWidget();
        ScoreInfoWidget scoreInfoWidget = new ScoreInfoWidget();
        private void onStudentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Program.studentList.Count && e.RowIndex >= 0) 
            {
                studentInfoWidget.StudentRole = Program.getRole(
                    studentGridView.Rows[e.RowIndex].Cells["id"].Value.ToString()) as Student;
                scoreInfoWidget.Scores = studentInfoWidget.StudentRole.scores;
            }
        }
        private void onStudentRemoved(object sender, DataGridViewRowCancelEventArgs e)
        {
            Program.studentList.Remove(Program.getRole(e.Row.Cells["id"].Value.ToString()) as Student);
        }

        private void onStudentAdded(object sender, DataGridViewRowEventArgs e)
        {
            Program.studentList.Insert(e.Row.Index,
                new Student("", "", "", "", "", ""));
        }

        private void onStudentEdited(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Program.studentList.Count
                && e.RowIndex >= 0
                && e.ColumnIndex < studentGridView.ColumnCount
                && e.ColumnIndex >= 0) 
            {
                var student = Program.getRole(
                    studentGridView.Rows[e.RowIndex].Cells["id"].Value.ToString()) as Student;
                var cell = studentGridView[e.ColumnIndex, e.RowIndex].Value;
                var value = cell == null ? "" : cell.ToString();
                switch (studentGridView.Columns[e.ColumnIndex].Name)
                {
                    case "id":
                        student.id = value;
                        break;
                    case "name":
                        student.name = value;
                        break;
                    case "gender":
                        student.gender = value;
                        break;
                    case "phone":
                        student.phone = value;
                        break;
                    case "mail":
                        student.mail = value;
                        break;
                    case "major":
                        student.major = value;
                        break;
                    default:
                        break;
                }
                
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            scoreInfoWidget.updateToScore();
        }
    }
}
