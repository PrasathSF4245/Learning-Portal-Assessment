using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class AppoinementDetails
    {
        
       private static int s_appointmentID = 1;
       /// <summary>
       /// This gets the AppointmentID
       /// </summary>
       /// <value>This gets int value</value>
        public int  AppointmentID { get; set; }
       /// <summary>
       /// This gets the PatientID
       /// </summary>
       /// <value>This gets int value</value>
        
        public int PatientID { get; set; }
        /// <summary>
        ///  This gets the DoctorID
        /// </summary>
        /// <value>This gets int value</value>
        public int DoctorID { get; set; }
        /// <summary>
        /// This gets the Date of Appoinment
        /// </summary>
        /// <value>this gets value in datetime datatype</value>

        public DateTime Date { get; set; }
        /// <summary>
        /// This gets the Problem
        /// </summary> 
        /// <value>this gets value in string datatype</value>
        public string Problem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"> This sets the PatientID</param>
        /// <param name="doctorID">This sets the DoctorID</param>
        /// <param name="date"> This sets the Date of Appoinment</param>
        /// <param name="problem">This sets the Problem</param> 
        public AppoinementDetails(int patientID, int doctorID, DateTime date, string problem) 
        {
            // AppointmentID = "AID" + (++s_appointmentID);
           AppointmentID=(s_appointmentID++);
            PatientID = patientID;  
            DoctorID = doctorID;    
            Date = date;    
            Problem = problem;  
            
        } 
    }
}
