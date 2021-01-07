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
        class Teacher: RoleBase
        {
            public string phone;

            public Teacher(string _name, string _gender, string _id, string _phone, string _avatar = "", string _passwordHash = "")
                : base(_name, _gender, _id, _avatar, _passwordHash)
            {
                base.isStudent = false;
                phone = _phone;
            }
        }
    }
}
