using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Managment_System__Better_UI_
{
    public class Doctor
    {
        String id;
        String name;
        List<Patient> patients = new List<Patient>();
        List<Disease> diseases = new List<Disease>();

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal List<Patient> Patients
        {
            get
            {
                return patients;
            }

            set
            {
                patients = value;
            }
        }

        internal List<Disease> Diseases
        {
            get
            {
                return diseases;
            }

            set
            {
                diseases = value;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Doctor)
            {
                if (((Doctor)obj).Id == id)
                    return true;
                return false;
            }

            return base.Equals(obj);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
