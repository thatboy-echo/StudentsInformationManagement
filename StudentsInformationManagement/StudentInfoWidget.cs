using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using StudentsInformationManagement.Properties;
using StudentsInformationManagement.Role;

namespace StudentsInformationManagement
{
    public partial class StudentInfoWidget : UserControl
    {
        public StudentInfoWidget()
        {
            InitializeComponent();
        }

        internal Student StudentRole
        {
            get { return studentRole; }
            set
            {
                studentRole = value;
                nameLabel.Text = studentRole.name;
                genderLabel.Text = studentRole.gender;
                idLabel.Text = studentRole.id;
                majorLabel.Text = studentRole.major;
                mailTextBox.Text = studentRole.mail;
                phoneTextBox.Text = studentRole.phone;
                if (string.IsNullOrWhiteSpace(studentRole.avatar))
                    avatarPictureBox.Image = Resources.DefaultAvatar;
                else
                    avatarPictureBox.ImageLocation = studentRole.avatar;
            }
        }
        private void onMailTextBoxChanged(object sender, EventArgs e)
        {
            studentRole.mail = mailTextBox.Text;
        }

        private void onPhoneTextBoxChanged(object sender, EventArgs e)
        {
            studentRole.phone = phoneTextBox.Text;
        }

        private void onAvatarClicked(object sender, EventArgs e)
        {
            if (studentRole == null)
                return;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.Filter = @"Image Files(*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                studentRole.avatar = dialog.FileName;
                avatarPictureBox.ImageLocation = studentRole.avatar;
            }
        }

        private Student studentRole;

        private void onPasswordChanging(object sender, EventArgs e)
        {
            if(studentRole == null)
                return;
            var newPassword = Interaction.InputBox("请输入新密码", "修改密码");

            if (newPassword.Length != 0)
                studentRole.passwordHash = MD5.Create().ComputeHash(
                    Encoding.UTF8.GetBytes(newPassword)).ToString();
        }
    }
}
