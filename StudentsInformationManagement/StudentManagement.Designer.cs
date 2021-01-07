
namespace StudentsInformationManagement
{
    partial class StudentManagement
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
            this.studentManagementTabControl = new System.Windows.Forms.TabControl();
            this.scoreInquiryPage = new System.Windows.Forms.TabPage();
            this.personalInfoPage = new System.Windows.Forms.TabPage();
            this.studentManagementTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentManagementTabControl
            // 
            this.studentManagementTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentManagementTabControl.Controls.Add(this.personalInfoPage);
            this.studentManagementTabControl.Controls.Add(this.scoreInquiryPage);
            this.studentManagementTabControl.Location = new System.Drawing.Point(12, 12);
            this.studentManagementTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentManagementTabControl.Name = "studentManagementTabControl";
            this.studentManagementTabControl.SelectedIndex = 0;
            this.studentManagementTabControl.Size = new System.Drawing.Size(585, 302);
            this.studentManagementTabControl.TabIndex = 0;
            // 
            // scoreInquiryPage
            // 
            this.scoreInquiryPage.Location = new System.Drawing.Point(4, 25);
            this.scoreInquiryPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreInquiryPage.Name = "scoreInquiryPage";
            this.scoreInquiryPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreInquiryPage.Size = new System.Drawing.Size(577, 273);
            this.scoreInquiryPage.TabIndex = 1;
            this.scoreInquiryPage.Text = "成绩查询";
            this.scoreInquiryPage.UseVisualStyleBackColor = true;
            // 
            // personalInfoPage
            // 
            this.personalInfoPage.Location = new System.Drawing.Point(4, 25);
            this.personalInfoPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalInfoPage.Name = "personalInfoPage";
            this.personalInfoPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalInfoPage.Size = new System.Drawing.Size(577, 273);
            this.personalInfoPage.TabIndex = 0;
            this.personalInfoPage.Text = "个人信息";
            this.personalInfoPage.UseVisualStyleBackColor = true;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 326);
            this.Controls.Add(this.studentManagementTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.studentManagementTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl studentManagementTabControl;
        private System.Windows.Forms.TabPage scoreInquiryPage;
        private System.Windows.Forms.TabPage personalInfoPage;
    }
}