using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public enum Gender { Male, Female }
    public class PatientDetails
    {

        private static int s_patientID = 0;
        /// <summary>
        /// This gets the PatientID
        /// </summary>
        /// <value>This gets int value</value>
        public int PatientID { get; set; }
        /// <summary>
        /// This gets the Password
        /// </summary>
        /// <value>This gets string value</value>
        public string Password { get; set; }
        /// <summary>
        /// This gets the Name
        /// </summary>
        /// <value>This gets string value</value>
        public string Name { get; set; }
        /// <summary>
        /// This gets the Age
        /// </summary>
        /// <value>This gets int value</value>
        public int Age { get; set; }
        /// <summary>
        /// This gets the Gender
        /// </summary>
        /// <value>This gets Gender datatype value</value>
        public Gender Gender { get; set; }

        /// <summary>
        /// This constructor assign the value
        /// </summary>
        /// <param name="password">This sets string value</param>
        /// <param name="name">This sets string value</param>
        /// <param name="age">This sets int value</param>
        /// <param name="gender">This sets Gender datatype value</param>
        public PatientDetails(string password, string name, int age, Gender gender)
        {
            PatientID = (++s_patientID);
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
          
        }

    }
}
