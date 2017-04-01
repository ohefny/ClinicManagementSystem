using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Managment_System__Better_UI_
{
    public class Symptom
    {
        String id;
        String name;
        String description;

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
        public override bool Equals(object obj)
        {
            if(obj is Symptom) {
                if (((Symptom)obj).Id == id)
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
