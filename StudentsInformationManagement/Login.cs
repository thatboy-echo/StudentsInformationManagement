using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsInformationManagement.Role;

namespace StudentsInformationManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            roleComboBox.SelectedIndex = 0; // 默认选择学生
        }

        private void loginButtonClicked(object sender, EventArgs e)
        {
            // 验证账户
            Program.currentRole.isStudent = roleComboBox.Text == "学生";
            Program.currentRole.id = accountTextBox.Text;
            Program.currentRole.passwordHash = MD5.Create().ComputeHash(
                Encoding.UTF8.GetBytes(passwordTextBox.Text)).ToString();

            if (Program.verifyAccount(accountTextBox.Text, Program.currentRole.passwordHash, Program.currentRole.isStudent))
            {
                // 设置账户角色
                Program.currentRole = Program.getRole(Program.currentRole);

                DialogResult = DialogResult.OK;
                Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("账户验证失败，请检查后重试！", "Verify Account", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
