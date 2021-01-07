
namespace StudentsInformationManagement
{
    partial class TeacherManagement
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
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGridView
            // 
            this.studentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.gender,
            this.major,
            this.phone,
            this.mail});
            this.studentGridView.Location = new System.Drawing.Point(12, 12);
            this.studentGridView.MultiSelect = false;
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersVisible = false;
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 27;
            this.studentGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(1078, 304);
            this.studentGridView.TabIndex = 0;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onStudentClicked);
            this.studentGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.onStudentEdited);
            this.studentGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.onStudentAdded);
            this.studentGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.onStudentRemoved);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "学号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.name.HeaderText = "姓名";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 66;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gender.HeaderText = "性别";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 66;
            // 
            // major
            // 
            this.major.HeaderText = "专业";
            this.major.MinimumWidth = 6;
            this.major.Name = "major";
            this.major.Width = 125;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "手机";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // mail
            // 
            this.mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail.HeaderText = "邮箱";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            // 
            // studentInfoLayout
            // 
            this.studentInfoLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentInfoLayout.ColumnCount = 2;
            this.studentInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentInfoLayout.Location = new System.Drawing.Point(12, 322);
            this.studentInfoLayout.Name = "studentInfoLayout";
            this.studentInfoLayout.RowCount = 1;
            this.studentInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentInfoLayout.Size = new System.Drawing.Size(1078, 312);
            this.studentInfoLayout.TabIndex = 1;
            // 
            // TeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 646);
            this.Controls.Add(this.studentInfoLayout);
            this.Controls.Add(this.studentGridView);
            this.Name = "TeacherManagement";
            this.Text = "TeacherManagement";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.TableLayoutPanel studentInfoLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
    }
}