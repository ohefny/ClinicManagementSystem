using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Managment_System__Better_UI_.Model
{
    public enum Privilege {Admin,User};
    public class User
    {
        String id;
        String userName;
        String pass;
        Privilege privilege;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public Privilege Privilege
        {
            get
            {
                return privilege;
            }

            set
            {
                privilege = value;
            }
        }
        public override bool Equals(object obj)
        {
            return (((User)obj).Id==id);
        }
    }
}
