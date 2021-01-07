using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationManagement
{
    namespace Role
    {
        [SerializableAttribute]
        class Student : RoleBase
        {
            public string major;
            public string phone;
            public string mail;

            public Dictionary<string, double> scores = new Dictionary<string, double>();

            public Student(string _name, string _gender, string _id, string _major, string _phone, string _mail, string _avatar = "", string _passwordHash = "")
                : base(_name, _gender, _id, _avatar, _passwordHash)
            {
                base.isStudent = true;
                major = _major;
                phone = _phone;
                mail = _mail;
            }


        }
    }
}
