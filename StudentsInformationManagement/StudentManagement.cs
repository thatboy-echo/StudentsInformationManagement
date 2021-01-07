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
using StudentsInformationManagement.Properties;

namespace StudentsInformationManagement
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            studentInfoWidget.Parent = personalInfoPage;
            scoreInfoWidget.Parent = scoreInquiryPage;
            scoreInfoWidget.scoreGridView.ReadOnly = true;
            scoreInfoWidget.scoreGridView.AllowUserToAddRows = false;
            scoreInfoWidget.scoreGridView.AllowUserToDeleteRows = false;
        }


        internal StudentInfoWidget studentInfoWidget = new StudentInfoWidget();
        internal ScoreInfoWidget scoreInfoWidget = new ScoreInfoWidget();
        private Student studentRole;
        internal Student StudentRole
        {
            get { return studentRole;}
            set
            {
                studentRole = value;
                studentInfoWidget.StudentRole = studentRole;
                scoreInfoWidget.Scores = studentRole.scores;
            }
        }
    }
}
