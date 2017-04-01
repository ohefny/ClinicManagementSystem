using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace Clinic_Managment_System__Better_UI_
{
    public class BookItem
    {
        String id;
        String patient_Id;
        String doctor_Id;
        String disease_Id;
        DateTime reservationDate; // = new MySqlDateTime(DateTime.Now);

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

        public string Patient_Id
        {
            get
            {
                return patient_Id;
            }

            set
            {
                patient_Id = value;
            }
        }

        public string Doctor_Id
        {
            get
            {
                return doctor_Id;
            }

            set
            {
                doctor_Id = value;
            }
        }

        public string Disease_Id
        {
            get
            {
                return disease_Id;
            }

            set
            {
                disease_Id = value;
            }
        }

        public DateTime ReservationDate
        {
            get
            {
                return reservationDate;
            }

            set
            {
                reservationDate = value;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is BookItem)
            {
                if (((BookItem)obj).Id == id)
                    return true;
                return false;
            }

            return base.Equals(obj);
        }
       
    }
}
