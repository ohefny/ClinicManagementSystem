using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Managment_System__Better_UI_
{
    public class Drug
    {
        String id;
        String name;
       // List<Disease> diseases;
        String description;
        String diseaseId;
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

      /*  internal List<Disease> Diseases
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
        */
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string DiseaseId
        {
            get
            {
                return diseaseId;
            }

            set
            {
                diseaseId = value;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Drug)
            {
                if (((Drug)obj).Id == id)
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
