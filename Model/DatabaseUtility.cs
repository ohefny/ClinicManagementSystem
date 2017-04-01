using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using Clinic_Managment_System__Better_UI_.Model;

namespace Clinic_Managment_System__Better_UI_
{
    public class DatabaseUtility
    {
        static private MySqlConnection connection;
        static private String connectionString;
        static private DatabaseUtility databaseUtility;
        private DatabaseUtility()
        {

        }
        public DatabaseUtility getInstance() {

            if (databaseUtility == null) {
                initDatabaseUtility();
            }
            return databaseUtility;
        }
        public static void initDatabaseUtility()
        {
            if (databaseUtility != null)
            {
                connection.Open();

                return ;
            }
            databaseUtility = new DatabaseUtility();
            connection = new MySqlConnection();
            connectionString = "server=localhost;database=clinic;"
                + "user=root;pwd=root";
            connection.ConnectionString = connectionString;
            connection.Open();
        }
        public static bool updateSymptom(Symptom symptom) {
            if (String.IsNullOrWhiteSpace(symptom.Name))
            {
                MessageBox.Show("Error..Symptom Name Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(symptom.Description))
            {
                symptom.Description = "";
            }
            initDatabaseUtility();
            String updateStr = "UPDATE symptoms "+
            "SET name = ' " +symptom.Name+ " ' , description = ' "+ symptom.Description+" '  " ;
            updateStr += "Where id = " + symptom.Id;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool updateDrug(Drug drug)
        {
            if (String.IsNullOrWhiteSpace(drug.Id)) {
                MessageBox.Show("Error..Id Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(drug.Name))
            {
                MessageBox.Show("Error..Symptom Name Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(drug.Description))
            {
                drug.Description = "";
            }
            if (String.IsNullOrWhiteSpace(drug.DiseaseId))
            {
                MessageBox.Show("Error..Disease Can't be null");
                return false;
            }
            initDatabaseUtility();
           
            String updateStr = "UPDATE drugs " +
            "SET name = ' " + drug.Name + " ' , description = ' " + drug.Description + " '  "+ "  , disease_id =  "
            +drug.DiseaseId+"  ";
            updateStr += "Where id = " + drug.Id;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;
            // MessageBox.Show(updateStr);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool updateDoctor(Doctor doctor)
        {
            if (String.IsNullOrWhiteSpace(doctor.Name))
            {
                MessageBox.Show("Error..Doctor Name Can't be null");
                return false;
            }
         /*  if (doctor.Diseases == null || doctor.Diseases.Count == 0)
            {
                MessageBox.Show("Error.. Diseases Can't be null/empty");
                return false;
            }*/
            
            String updateStr = "UPDATE doctors " +
           "SET name = ' " + doctor.Name + " ' ";
            updateStr += "Where id = " + doctor.Id;
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool updatePatient(Patient patient)
        {
        
            if (String.IsNullOrWhiteSpace(patient.Name))
            {
                MessageBox.Show("Error..Disease Name Can't be null");
                return false;
            }
            if (patient.IllnessDate==null)
            {
                MessageBox.Show("Error.. not a valid date");
                return false;
            }

               if (patient.Symptoms == null || patient.Symptoms.Count == 0)
               {
                   MessageBox.Show("Error.. Symptoms Can't be null/empty");
                   return false;
               }
               if (patient.Diseases == null || patient.Diseases.Count == 0)
               {
                   MessageBox.Show("Error.. Diseases Can't be null/empty");
                   return false;
               }
            String updateStr = "UPDATE patients " +
            "SET name = ' " + patient.Name + " ' , phone = ' "+patient.Phone+" ' " 
            + "  , time_date =  "+convertDateToStr(patient.IllnessDate)+"  ";
            updateStr += "Where id = " + patient.Id;
            
            initDatabaseUtility(); 
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool updateBooking(BookItem bookItem)
        { 
           
            if (bookItem.ReservationDate ==null)
            {
                MessageBox.Show("Error.. not a valid date");
                return false;
            }
            if (String.IsNullOrWhiteSpace(bookItem.Patient_Id))
            {
                MessageBox.Show("Error..Patient  Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(bookItem.Doctor_Id))
            {
                MessageBox.Show("Error..Doctor Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(bookItem.Disease_Id))
            {
                MessageBox.Show("Error..Disease Can't be null");
                return false;
            }
            String updateStr = "UPDATE bookings " +
            "SET patient_id =  " + bookItem.Patient_Id + "  , doctor_id =  " + bookItem.Doctor_Id + " "
            + "  , time_date =  " + convertDateToStr(bookItem.ReservationDate) + " , "
            + " disease_id = " + bookItem.Disease_Id;
            updateStr += " Where id = " + bookItem.Id;

            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool updateDisease(Disease disease)
        {
            if (String.IsNullOrWhiteSpace(disease.Name))
            {
                MessageBox.Show("Error..Disease Name Can't be null");
                return false;
            }
           /* if (disease.Symptoms == null || disease.Symptoms.Count == 0)
            {
                MessageBox.Show("Error..Disease Symptoms Can't be null/empty");
                return false;
            }*/
            if (String.IsNullOrWhiteSpace(disease.Description))
            {
                disease.Description = "";
            }
            String updateStr = "UPDATE diseases SET name = ' " + disease.Name + " ' , description = ' " + disease.Description + " '  ";
            updateStr += "Where id = " + disease.Id;
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = updateStr;
            MessageBox.Show(updateStr);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removeDrug(String id)
        {
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  drugs  where id = " + id;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removeDoctor(String id)
        {

            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  Doctors  where id = " + id;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removePatient(String id)
        {

            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  patients  where id = " + id;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removeBooking(String id)
        {

            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  bookings  where id = " + id;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removeDisease(String id)
        {

            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  diseases  where id = " + id;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool removeSymptoms(String id) {
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  symptoms  where id = " + id;
            cmd.CommandText = str;
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool addDrug(Drug drug)
        {

            if (String.IsNullOrWhiteSpace(drug.Name))
            {
                MessageBox.Show("Error..Symptom Name Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(drug.Description))
            {
                drug.Description = "";
            }
            if (String.IsNullOrWhiteSpace(drug.DiseaseId))
            {
                MessageBox.Show("Error..Disease Can't be null");
                return false;
            }
            String str = "insert  into drugs (name,description,disease_id) values ( '" + drug.Name + "' , '" + drug.Description +" ' , "+ Convert.ToInt32(drug.DiseaseId)+")";
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool addDoctor(Doctor doctor)
        {

            if (String.IsNullOrWhiteSpace(doctor.Name))
            {
                MessageBox.Show("Error..Doctor Name Can't be null");
                return false;
            }      
            if (doctor.Diseases == null || doctor.Diseases.Count == 0)
            {
                MessageBox.Show("Error.. Diseases Can't be null/empty");
                return false;
            }
            String str = str = "insert  into doctors (name) values ( '" + doctor.Name  + "' )";
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select last_insert_id();";
                doctor.Id = cmd.ExecuteScalar().ToString();
                foreach (Patient pt in doctor.Patients)
                {
                    String st = "insert  into patients_doctors (doctor_id,patient_id) values (  "
                        + Convert.ToInt32(doctor.Id) + " , " + Convert.ToInt32(pt.Id) + " )";
                    cmd.CommandText = st;
                    cmd.ExecuteNonQuery();
                }
                foreach (Disease ds in doctor.Diseases)
                {
                    String st = "insert  into diseases_doctors (doctor_id,disease_id) values (  "
                        + Convert.ToInt32(doctor.Id) + " , " + Convert.ToInt32(ds.Id) + " )";
                    cmd.CommandText = st;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool addPatient(Patient patient)
        {

            if (String.IsNullOrWhiteSpace(patient.Name))
            {
                MessageBox.Show("Error..Disease Name Can't be null");
                return false;
            }
            if (patient.Symptoms == null || patient.Symptoms.Count == 0)
            {
                MessageBox.Show("Error.. Symptoms Can't be null/empty");
                return false;
            }
            if (patient.Diseases == null || patient.Diseases.Count == 0) {
                MessageBox.Show("Error.. Diseases Can't be null/empty");
                return false;
            }
            String str = str = "insert  into patients (name,phone) values ( '" + patient.Name + "' , '" + patient.Phone + "' )";
            if (patient.IllnessDate != null) {
                str = "insert  into patients (name,phone,time_date) values ( ' " 
                    + patient.Name + "' , '" + patient.Phone + "' ,'"
                    + convertDateToStr(patient.IllnessDate)+"'"
                    +  " )";
                
            }



            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select last_insert_id();";
                patient.Id = cmd.ExecuteScalar().ToString();
                foreach (Symptom sm in patient.Symptoms)
                {
                    String st = "insert  into patients_symptoms (symptom_id,patient_id) values (  " + Convert.ToInt32(sm.Id) + " , " + Convert.ToInt32(patient.Id) + " )";
                    cmd.CommandText = st;
                    cmd.ExecuteNonQuery();
                }
                foreach (Disease ds in patient.Diseases)
                {
                    String st = "insert  into diseases_patients (disease_id,patient_id) values (  " + Convert.ToInt32(ds.Id) + " , " + Convert.ToInt32(patient.Id) + " )";
                    cmd.CommandText = st;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        

        public static bool addBooking(BookItem bookItem)
        {
            //after booking assign patients to doctors

            if (String.IsNullOrWhiteSpace(bookItem.Patient_Id))
            {
                MessageBox.Show("Error..Patient  Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(bookItem.Doctor_Id))
            {
                MessageBox.Show("Error..Doctor Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(bookItem.Disease_Id))
            {
                MessageBox.Show("Error..Disease Can't be null");
                return false;
            }
            /*       String str = "insert  into bookings (disease_id,patient_id,doctor_id) values ( "
                        + Convert.ToInt32(bookItem.Disease_Id) +
                       " , " + Convert.ToInt32(bookItem.Patient_Id) + 
                       "  , " + Convert.ToInt32(bookItem.Doctor_Id) + ")";*/
            String str = "";
            if (bookItem.ReservationDate !=null)
            {

                str = "insert  into bookings (disease_id,patient_id,doctor_id,time_date) values ( "
                + Convert.ToInt32(bookItem.Disease_Id) +
               " , " + Convert.ToInt32(bookItem.Patient_Id) +
               "  , " + Convert.ToInt32(bookItem.Doctor_Id) + "  , "
               + convertDateToStr(bookItem.ReservationDate) + ")";
            }
            else {
                MessageBox.Show("Error .. Please Enter a valid date");
            }
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static bool addDisease(Disease disease)
        {
            if (String.IsNullOrWhiteSpace(disease.Name))
            {
                MessageBox.Show("Error..Disease Name Can't be null");
                return false;
            }
            if (disease.Symptoms == null || disease.Symptoms.Count == 0) {
                MessageBox.Show("Error..Disease Symptoms Can't be null/empty");
                return false;
            }
            if (String.IsNullOrWhiteSpace(disease.Description))
            {
                disease.Description = "";
            }
            String str = "insert  into diseases (name,description) values ( '" + disease.Name + "' , '" + disease.Description + "' )";
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong Occurecd");
                connection.Close();
                return false;
            }
           
            cmd.CommandText = "select last_insert_id();";
            try
            {
                disease.Id = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong Occurecd");
                connection.Close();
                return false;
            }
            foreach (Symptom sm in disease.Symptoms) {
               String st= "insert  into diseases_symptoms (disease_id,symptom_id) values (  " +Convert.ToInt32(disease.Id) + "," + Convert.ToInt32(sm.Id) + " )";
                cmd.CommandText = st;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show("Something Wrong Occurecd");
                    connection.Close();
                    return false;
                }
            }
            connection.Close();
            return true;
        }
        public static List<Drug> getDrugsOfDisease(Disease disease) {
            if (String.IsNullOrWhiteSpace(disease.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Drug> list = new List<Drug>();
            string strSql = "select * from drugs where disease_id =" + Convert.ToInt32(disease.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Drug dg = new Drug();
                    dg.Id = mysqlDataReader["id"].ToString();
                    dg.Name = mysqlDataReader["name"].ToString();
                    dg.DiseaseId = mysqlDataReader["disease_id"].ToString();
                    dg.Description = mysqlDataReader["description"].ToString();
                    list.Add(dg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Patient> getPatientssOfDoctor(Doctor doctor)
        {
            if (String.IsNullOrWhiteSpace(doctor.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Patient> list = new List<Patient>();
            string strSql = "select patient_id from patients_doctors where doctor_id =" + Convert.ToInt32(doctor.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Patient patient = new Patient();
                    patient.Id = mysqlDataReader["patient_id"].ToString();
                    list.AddRange(DatabaseUtility.getPatients(patient));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Disease> getDiseasesOfSymptom(Symptom sym) {

            if (String.IsNullOrWhiteSpace(sym.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Disease> list = new List<Disease>();
            string strSql = "select disease_id from diseases_symptoms where symptom_id =" + Convert.ToInt32(sym.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Disease> dis_ids = new List<Disease>();
                while (mysqlDataReader.Read())
                {
                    Disease ds_id = new Disease();

                    ds_id.Id = mysqlDataReader["disease_id"].ToString();
                    dis_ids.Add(ds_id);
                }
                connection.Close();
                foreach (Disease ds in dis_ids)
                {
                    list.AddRange(DatabaseUtility.getDiseases(ds));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Patient> getPatientsOfSymptom(Symptom sym)
        {

            if (String.IsNullOrWhiteSpace(sym.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Patient> list = new List<Patient>();
            string strSql = "select patient_id from patients_symptoms where symptom_id =" + Convert.ToInt32(sym.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Patient> pt_ids = new List<Patient>();
                while (mysqlDataReader.Read())
                {
                    Patient pt_id = new Patient();

                    pt_id.Id = mysqlDataReader["patient_id"].ToString();
                    pt_ids.Add(pt_id);
                }
                connection.Close();
                foreach (Patient pt in pt_ids)
                {
                    list.AddRange(DatabaseUtility.getPatients(pt));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Symptom> getSymptomsOfDisease(Disease disease)
        {
            if (String.IsNullOrWhiteSpace(disease.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Symptom> list = new List<Symptom>();
            string strSql = "select symptom_id from diseases_symptoms where disease_id =" + Convert.ToInt32(disease.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Symptom> syms = new List<Symptom>();
                while (mysqlDataReader.Read())
                {
                    Symptom sym = new Symptom();

                    sym.Id = mysqlDataReader["symptom_id"].ToString();
                    syms.Add(sym);
                }
                connection.Close();
                foreach(Symptom sy in syms)
                {
                    list.AddRange (DatabaseUtility.getSymptoms(sy));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Patient> getPatientsOfDisease(Disease disease)
        {
            if (String.IsNullOrWhiteSpace(disease.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Patient> list = new List<Patient>();
            string strSql = "select patient_id from diseases_patients where disease_id =" + Convert.ToInt32(disease.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Patient> patients_ids = new List<Patient>();
                while (mysqlDataReader.Read())
                {
                    Patient p_id = new Patient();

                    p_id.Id = mysqlDataReader["patient_id"].ToString();
                    patients_ids.Add(p_id);
                }
                connection.Close();
                foreach (Patient pt in patients_ids)
                {
                    list.AddRange(DatabaseUtility.getPatients(pt));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Doctor> getDoctorsOfdisease(Disease disease) {
            if (String.IsNullOrWhiteSpace(disease.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Doctor> list = new List<Doctor>();
            string strSql = "select doctor_id from diseases_doctors where disease_id =" + Convert.ToInt32(disease.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Doctor> drs_ids = new List<Doctor>();
                while (mysqlDataReader.Read())
                {
                    Doctor dr_id = new Doctor();

                    dr_id.Id = mysqlDataReader["doctor_id"].ToString();
                    drs_ids.Add(dr_id);
                }
                connection.Close();
                foreach (Doctor dr in drs_ids)
                {
                    list.AddRange(DatabaseUtility.getDoctors(dr));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Disease> getDiseaseOfDoctor(Doctor doctor) {


            if (String.IsNullOrWhiteSpace(doctor.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Disease> list = new List<Disease>();
            string strSql = "select disease_id from diseases_doctors where doctor_id =" + Convert.ToInt32(doctor.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Disease> dis_ids = new List<Disease>();
                while (mysqlDataReader.Read())
                {
                    Disease dis_id = new Disease();

                    dis_id.Id = mysqlDataReader["disease_id"].ToString();
                    dis_ids.Add(dis_id);
                }
                connection.Close();
                foreach (Disease ds in dis_ids)
                {
                    list.AddRange(DatabaseUtility.getDiseases(ds));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Disease> getDiseasesOfPatient(Patient patient) {
            if (String.IsNullOrWhiteSpace(patient.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Disease> list = new List<Disease>();
            string strSql = "select disease_id from diseases_patients where patient_id =" + Convert.ToInt32(patient.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Disease> dis_ids = new List<Disease>();
                while (mysqlDataReader.Read())
                {
                    Disease dis_id = new Disease();

                    dis_id.Id = mysqlDataReader["disease_id"].ToString();
                    dis_ids.Add(dis_id);
                }
                connection.Close();
                foreach (Disease ds in dis_ids)
                {
                    list.AddRange(DatabaseUtility.getDiseases(ds));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Symptom> getSymptomsOfPatient(Patient patient)
        {
            if (String.IsNullOrWhiteSpace(patient.Id))
            {
                MessageBox.Show("Id can't be null ");
                return null;
            }
            List<Symptom> list = new List<Symptom>();
            string strSql = "select symptom_id from patients_symptoms where patient_id =" + Convert.ToInt32(patient.Id);
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = strSql;
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                List<Symptom> syms = new List<Symptom>();
                while (mysqlDataReader.Read())
                {
                    Symptom sym = new Symptom();

                    sym.Id = mysqlDataReader["symptom_id"].ToString();
                    syms.Add(sym);
                }
                connection.Close();
                foreach (Symptom sy in syms)
                {
                    list.AddRange(DatabaseUtility.getSymptoms(sy));
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static bool addSymptom(Symptom symptom)
        {

           
          /*  if (String.IsNullOrWhiteSpace(symptom.Id)) {
                MessageBox.Show("Error..Symptom Id Can't be null");
            }*/
            if (String.IsNullOrWhiteSpace(symptom.Name))
            {
                MessageBox.Show("Error..Symptom Name Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(symptom.Description)) {
                symptom.Description = "";
            }
            String str= "insert  into symptoms (name,description) values ( '"  + symptom.Name + "' , '" + symptom.Description + "' )";
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show("Something Wrong Occurecd");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static List<Patient> getPatients(Patient patient)
        {
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from patients ");
            List<Patient> list = new List<Patient>();
            MySqlCommand cmd = connection.CreateCommand();
            List<string> selections = new List<string>();
            if (patient != null)
            {
                if (!String.IsNullOrWhiteSpace(patient.Id))
                    selections.Add("id = " + patient.Id);
                if (!String.IsNullOrWhiteSpace(patient.Name))
                    selections.Add("name like '%" + patient.Name + "%' ");
                if (patient.IllnessDate !=null) {
                    //search by date
                }
                // if(patient.Symptoms)
                if (!String.IsNullOrWhiteSpace(patient.Phone )) {
                    selections.Add("phone like '%" + patient.Name+ "%' ");
                }
                appendSelection(mysqlCmdBuilder, selections);

            }
            initDatabaseUtility();
            cmd.CommandText = mysqlCmdBuilder.ToString();
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Patient pt = new Patient();
                    pt.Id = mysqlDataReader["id"].ToString();
                    pt.Name = mysqlDataReader["name"].ToString();
                    pt.Phone = mysqlDataReader["phone"].ToString();
                    String str= mysqlDataReader["time_date"].ToString();
                    DateTime temp;
                    if (DateTime.TryParse(str,out temp)) {
                        pt.IllnessDate = temp;
                    }
                  
                    list.Add(pt);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong");
                connection.Close();
            }
            connection.Close();
            return list;
        }
        public static List<Doctor> getDoctors(Doctor doctor)
        {
            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from doctors ");
            List<Doctor> list = new List<Doctor>();
            MySqlCommand cmd = connection.CreateCommand();
            List<string> selections = new List<string>();
            if (doctor != null)
            {
                if (!String.IsNullOrWhiteSpace(doctor.Id ))
                    selections.Add("id =" + doctor.Id);
                if (!String.IsNullOrWhiteSpace(doctor.Name ))
                    selections.Add("name like '%" + doctor.Name+"%'");
                appendSelection(mysqlCmdBuilder, selections);

            }
            cmd.CommandText = mysqlCmdBuilder.ToString();
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Doctor dr = new Doctor();
                    dr.Id = mysqlDataReader["id"].ToString();
                    dr.Name = mysqlDataReader["name"].ToString();
                    list.Add(dr);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went Wrong");
                connection.Close();
            }
            connection.Close();
            return list;
        }
        public static List<Drug> getDrugs(Drug drug)
        {
            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from drugs ");
            List<Drug> list = new List<Drug>();
            MySqlCommand cmd = connection.CreateCommand();
            
            List<string> selections = new List<string>();
            if (drug != null) {
                if (!String.IsNullOrWhiteSpace(drug.Id))
                    selections.Add("id =" + drug.Id);
                if (!String.IsNullOrWhiteSpace(drug.Name ))
                    selections.Add("name like '%" + drug.Name+"%'");
                if (!String.IsNullOrWhiteSpace(drug.DiseaseId))
                {
                    selections.Add("disease_id =" + drug.DiseaseId);
                }
                appendSelection(mysqlCmdBuilder, selections);

            }
            try
            {
                cmd.CommandText = mysqlCmdBuilder.ToString();
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Drug dg = new Drug();
                    dg.Id = mysqlDataReader["id"].ToString();
                    dg.Name = mysqlDataReader["name"].ToString();
                    dg.DiseaseId = mysqlDataReader["disease_id"].ToString();
                    dg.Description = mysqlDataReader["description"].ToString();
                    list.Add(dg);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static List<Symptom> getSymptoms(Symptom symptom) {

            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from symptoms ");
            List<Symptom> list = new List<Symptom>();
            MySqlCommand cmd = connection.CreateCommand();

            List<string> selections = new List<string>();
            if (symptom != null)
            {
                if (!String.IsNullOrWhiteSpace(symptom.Id))
                    selections.Add("id =" + symptom.Id);
                if (!String.IsNullOrWhiteSpace(symptom.Name))
                    selections.Add("name like '%" + symptom.Name+ "%' ;");
               
                appendSelection(mysqlCmdBuilder, selections);

            }
            cmd.CommandText = mysqlCmdBuilder.ToString();
           
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Symptom dg = new Symptom();
                    dg.Id = mysqlDataReader["id"].ToString();
                    dg.Name = mysqlDataReader["name"].ToString();
                    dg.Description = mysqlDataReader["description"].ToString();
                    list.Add(dg);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong");
                connection.Close();
            }
            connection.Close();
            return list;
        
    }
        public static List<BookItem> getBookings(BookItem bookItem)
        {
            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from bookings ");
            List<BookItem> list = new List<BookItem>();
            MySqlCommand cmd = connection.CreateCommand();
            List<string> selections = new List<string>();
            if (bookItem != null)
            {
                if (!String.IsNullOrWhiteSpace(bookItem.Id ))
                    selections.Add("id =" + bookItem.Id);
                if (!String.IsNullOrWhiteSpace(bookItem.Patient_Id))
                    selections.Add("patient_id =" + bookItem.Patient_Id);
                if (!String.IsNullOrWhiteSpace(bookItem.Disease_Id ))
                {
                    selections.Add("disease_id =" + bookItem.Disease_Id);
                }
                if (!String.IsNullOrWhiteSpace(bookItem.Doctor_Id ))
                    selections.Add("doctor_id =" + bookItem.Doctor_Id);
               /* if (bookItem.ReservationDate.IsValidDateTime) {
                    //add selection statement to date
                }*/
                appendSelection(mysqlCmdBuilder, selections);

            }
            cmd.CommandText = mysqlCmdBuilder.ToString();
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    BookItem bi = new BookItem();
                    bi.Id = mysqlDataReader["id"].ToString();
                    bi.Patient_Id = mysqlDataReader["patient_id"].ToString();
                    bi.Disease_Id = mysqlDataReader["disease_id"].ToString();
                    bi.Doctor_Id = mysqlDataReader["doctor_id"].ToString();
                    String str = mysqlDataReader["time_date"].ToString();
                    DateTime temp;
                    if (DateTime.TryParse(str, out temp))
                    {
                        bi.ReservationDate = temp;
                    }
                    list.Add(bi);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong");
                connection.Close();
            }
            connection.Close();
            return list;
        }

        private static void appendSelection(StringBuilder mysqlCmdBuilder, List<string> selections)
        {
            if (selections.Count != 0)
            {
                mysqlCmdBuilder.Append("where ");
                for (int i = 0; i < selections.Count; i++)
                {
                    mysqlCmdBuilder.Append(selections.ElementAt<String>(i));
                    if (i + 1 != selections.Count)
                    {
                        mysqlCmdBuilder.Append(" and ");
                    }
                }
            }
        }
        
        public static List<Disease> getDiseases(Disease disease)
        {
            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from diseases ");
            List<Disease> list = new List<Disease>();
            MySqlCommand cmd = connection.CreateCommand();
            List<string> selections = new List<string>();
            if (disease != null)
            {
                if (!String.IsNullOrWhiteSpace(disease.Id))
                    selections.Add("id = " + disease.Id);
                if (!String.IsNullOrWhiteSpace(disease.Name ))
                    selections.Add("name like '%" + disease.Name+"%' ");
             
                // if(patient.Symptoms)
               
                appendSelection(mysqlCmdBuilder, selections);

            }
            cmd.CommandText = mysqlCmdBuilder.ToString();
            try
            {
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    Disease bi = new Disease();
                    bi.Id = mysqlDataReader["id"].ToString();
                    bi.Name = mysqlDataReader["name"].ToString();
                    bi.Description = mysqlDataReader["description"].ToString();
                    //bi.
                    // bi.ReservationDate = (MySql.Data.Types.MySqlDateTime)(mysqlDataReader["time_date"]);
                    list.Add(bi);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went Wrong");
                connection.Close();
            }
            connection.Close();
            return list;
        }
        public static DataTable getSymptomsDt(Symptom symptom)
        {

            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select * from symptoms ");        
            MySqlCommand cmd = connection.CreateCommand();

            List<string> selections = new List<string>();
            if (symptom != null)
            {
                if (!String.IsNullOrWhiteSpace(symptom.Id))
                    selections.Add("id = " + symptom.Id);
                if (!String.IsNullOrWhiteSpace(symptom.Name))
                    selections.Add("name = ' " + symptom.Name + " ' ");

                appendSelection(mysqlCmdBuilder, selections);

            }
           
            cmd.CommandText = mysqlCmdBuilder.ToString();
            MessageBox.Show(mysqlCmdBuilder.ToString());
            MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(mysqlDataReader);
            connection.Close();
            return dt;

        }
        private static String convertDateToStr(DateTime mytime)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            String str = mytime.ToString(format);
            return str;
        }
        public static bool addUser(User user) {
            if (String.IsNullOrWhiteSpace(user.UserName))
            {
                MessageBox.Show("Error..User Name Can't be null");
                return false;
            }
            if (String.IsNullOrWhiteSpace(user.Pass))
            {
                MessageBox.Show("Error..Password Can't be null");
                return false;
            }
            User tem = new User();
            tem.UserName = user.UserName;
            if (DatabaseUtility.getUsers(tem).Count > 0)
            {
                MessageBox.Show("Error..UserName Exist");
                return false;

            }


            String str = "insert  into log_in (user_name,user_password,user_privilege) values ( '" + user.UserName + "' , '" + user.Pass + " ' , '" + user.Privilege.ToString()+ "')";
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        public static List<User> getUsers(User user) {
            initDatabaseUtility();
            StringBuilder mysqlCmdBuilder = new StringBuilder("select id,user_name,user_privilege from log_in ");
            List<User> list = new List<User>();
            MySqlCommand cmd = connection.CreateCommand();

            List<string> selections = new List<string>();
            if (user != null)
            {
                if (!String.IsNullOrWhiteSpace(user.Id))
                    selections.Add("id =" + user.Id);
                if (!String.IsNullOrWhiteSpace(user.UserName))
                    selections.Add("user_name like '%" + user.UserName+ "%'");
               
                appendSelection(mysqlCmdBuilder, selections);

            }
            try
            {
                cmd.CommandText = mysqlCmdBuilder.ToString();
                MySqlDataReader mysqlDataReader = cmd.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    User us = new User();
                    us.Id = mysqlDataReader["id"].ToString();
                    us.UserName = mysqlDataReader["user_name"].ToString();
                    us.Privilege = stringToPrivilege(mysqlDataReader["user_privilege"].ToString());
                    
                    list.Add(us);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            connection.Close();
            return list;
        }
        public static bool removeUser(String userID) {
            initDatabaseUtility();
            MySqlCommand cmd = connection.CreateCommand();
            String str = "delete from  log_in  where id = " + userID;
            cmd.CommandText = str;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;

        }
        public static Privilege stringToPrivilege(string v)
        {
            if (v.Equals("Admin"))
                return Privilege.Admin;

            return Privilege.User;
        }
    }
}
