using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationManagement
{
    namespace Role
    {
        [SerializableAttribute]
        class RoleBase
        {
            [NonSerialized] public bool isStudent = true;
            public string name;
            public string gender;
            public string id;
            public string avatar;
            public string passwordHash;

            internal RoleBase(string _name, string _gender, string _id, string _avatar = "", string _passwordHash = "")
            {
                name = _name;
                gender = _gender;
                id = _id;
                avatar = _avatar;
                passwordHash = _passwordHash;
            }

            internal RoleBase()
            {
            }


            public static void Serialize(Stream stream, RoleBase role)
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, role);
            }
            public static RoleBase Unserialize(Stream stream)
            {
                IFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream) as RoleBase;
            }
        }
    }
}
