using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //this will add the the default details
            HospitalApp.Application.AddDefaultDetails();
            AppointmentManager.OnAppoinmentHandler+=AppointmentManager.BookAppointmentMessage;
            //this will start the application
            HospitalApp.Application.StartApp();

        }
    }
}