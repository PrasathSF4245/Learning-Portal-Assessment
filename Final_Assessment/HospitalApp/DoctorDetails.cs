using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class DoctorDetails
    {

        private static int s_doctorID = 0;
        /// <summary>
        /// This gets the DoctorID
        /// </summary>
        /// <value>This gets int value</value>
        public int DoctorID { get; }
        /// <summary>
        /// This gets the Name
        /// </summary>
        /// <value>This gets string value</value>
        public string Name { get; set; }
        /// <summary>
        /// This gets the Department
        /// </summary>
        /// <value>This gets string value</value>
        public string Department { get; set; }
        /// <summary>
        /// This constructor assigns the value
        /// </summary>
        /// <param name="name">This gets the Name</param>
        /// <param name="department">This gets the Department</param>
        public DoctorDetails(string name, string department)
        {
            DoctorID = (++s_doctorID);
            Name = name;
            Department = department;
        }

    }
}
