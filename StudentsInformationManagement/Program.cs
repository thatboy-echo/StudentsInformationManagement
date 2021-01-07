using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsInformationManagement.Role;

namespace StudentsInformationManagement
{
    static class Program
    {
        private static string StudentDBFile = @"student.db";
        private static string TeacherDBFile = @"teacher.db";
        internal static RoleBase currentRole = new RoleBase();
        internal static List<Student> studentList = new List<Student>();
        internal static List<Teacher> teachertList = new List<Teacher>();

        static public void loadDatabase()
        {
            // 加载学生列表
            if (File.Exists(StudentDBFile))
            {
                using (FileStream fs = new FileStream(StudentDBFile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    studentList = bf.Deserialize(fs) as List<Student>;
                    fs.Close();
                    foreach (var student in studentList)
                    {
                        student.isStudent = true;
                    }
                }
            }
            // 加载教师列表
            if (File.Exists(TeacherDBFile))
            {
                using (FileStream fs = new FileStream(TeacherDBFile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    teachertList = bf.Deserialize(fs) as List<Teacher>;
                    fs.Close();
                    foreach (var teacher in teachertList)
                    {
                        teacher.isStudent = false;
                    }
                }
            }
        }

        static public void saveDatabase()
        {
            // 保存学生列表
            using (FileStream fs = new FileStream(StudentDBFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, studentList);
                fs.Close();
            }
            // 保存教师列表
            using (FileStream fs = new FileStream(TeacherDBFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, teachertList);
                fs.Close();
            }
        }

        static private void initRoleList()
        {
            if (teachertList.Count == 0)
                teachertList.Add(new Teacher(
                    "管理员", "", "admin", "", "", MD5.Create().ComputeHash(
                        Encoding.UTF8.GetBytes("admin")).ToString()
                ));
            if (studentList.Count == 0)
            {
                var kongjh = new Student(
                    "孔江华", "男", "202170623", "数字媒体技术"
                    , "10987654321", "kongjh@gmail.com", ""
                    , MD5.Create().ComputeHash(
                        Encoding.UTF8.GetBytes("kongjh")).ToString()
                );
                kongjh.scores["C++"] = 80;
                kongjh.scores["Java"] = 89;
                kongjh.scores["C#"] = 87;
                kongjh.scores["Unity"] = 77;
                kongjh.scores["高等数学"] = 67;

                var zhouh = new Student(
                    "周欢", "男", "202170637", "数字媒体技术"
                    , "12345678910", "zhouh@gmail.com", ""
                    , MD5.Create().ComputeHash(
                        Encoding.UTF8.GetBytes("zhouh")).ToString()
                );

                zhouh.scores["C++"] = 76;
                zhouh.scores["Java"] = 93;
                zhouh.scores["C#"] = 80;
                zhouh.scores["Unity"] = 87;
                zhouh.scores["高等数学"] = 78;

                studentList.Add(kongjh);
                studentList.Add(zhouh);
            }

        }

        static public RoleBase getRole(string id, bool isStudent = true)
        {
            if (isStudent)
            {
                foreach (var student in studentList)
                {
                    if (student.id == id)
                        return student;
                }

                return null;
            }
            else
            {
                foreach (var student in teachertList)
                {
                    if (student.id == id)
                        return student;
                }
                return null;
            }
        }

        static public RoleBase getRole(RoleBase role)
        {
            if (role.isStudent)
            {
                foreach (var student in studentList)
                {
                    if (student.id == role.id)
                        return student;
                }

                return null;
            }
            else
            {
                foreach (var student in teachertList)
                {
                    if (student.id == role.id)
                        return student;
                }
                return null;
            }
        }
        static public bool verifyAccount(string id, string passwordHash, bool ifStudent = true)
        {
            if (ifStudent)
            {
                foreach (var student in studentList)
                {
                    if (student.id == id)
                    {
                        if (student.passwordHash == passwordHash)
                            return true;
                        else
                            return false;
                    }
                }

                return false;
            }
            else
            {
                foreach (var teacher in teachertList)
                {
                    if (teacher.id == id)
                    {
                        if (teacher.passwordHash == passwordHash)
                            return true;
                        else
                            return false;
                    }
                }

                return false;
            }
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 加载学生和教师列表
            loadDatabase();
            initRoleList();

            var loginDialog = new Login();
            Form managementDialog = null;
            if (loginDialog.ShowDialog() == DialogResult.OK)
            {
                if (currentRole.isStudent)
                {
                    var dialog = new StudentManagement();
                    dialog.StudentRole = currentRole as Student;
                    managementDialog = dialog;
                }
                else
                {
                    managementDialog = new TeacherManagement();
                }

                Application.Run(managementDialog);

            }
            saveDatabase();
        }
    }
}
