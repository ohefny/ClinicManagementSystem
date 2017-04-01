using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;
namespace Clinic_Managment_System__Better_UI_
{
    public class Patient
    {
        String name;
        String id;
        String phone = "";
        DateTime illnessDate = DateTime.Now;
        
        List<Symptom> symptoms = new List<Symptom>();

        List<Disease> diseases = new List<Disease>();
        public String getIllnessDateString() {
            string format = "yyyy-MM-dd HH:mm:ss";
            String mytime = illnessDate.ToString(format);
            return mytime;
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

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public DateTime IllnessDate
        {
            get
            {
                return illnessDate;
            }

            set
            {
                illnessDate = value;
            }
        }

        internal List<Symptom> Symptoms
        {
            get
            {
                return symptoms;
            }

            set
            {
                symptoms = value;
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
            if (obj is Patient)
            {
                if (((Patient)obj).Id == id)
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
