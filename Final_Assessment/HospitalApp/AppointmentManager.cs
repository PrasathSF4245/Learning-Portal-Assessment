using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class AppointmentManager
    {

        protected static List<PatientDetails> PatientDetailslist = new List<PatientDetails>();
        protected static List<DoctorDetails> DoctorDetailslist = new List<DoctorDetails>();
        protected static List<AppoinementDetails> AppoinementDetailslist = new List<AppoinementDetails>();
        protected static PatientDetails currentLoggedinPatient;
        public delegate void AppointmentBooking(Object sender, EventArgs e);

        public static event AppointmentBooking OnAppoinmentHandler;
        public static void BookAppointment()

        {
            //AppointmentManager.AppointmentBooking appointmentBooking +=   AppointmentManager.BookAppointmentMessage;
            int checkCount = 0;

            foreach (DoctorDetails doctor in DoctorDetailslist)
            {
                Console.WriteLine(doctor.Department);
            }
            bool checkdepartment = false;

            Console.WriteLine("Enter the name of the depatment to proceed");
            string departmenrt = Console.ReadLine().ToLower();

            Console.WriteLine("Enter your Problem");
            string problem = Console.ReadLine();

            foreach (DoctorDetails doctor in DoctorDetailslist)
            {
                if (doctor.Department.ToLower() == departmenrt)
                {

                    checkdepartment = true;

                    foreach (AppoinementDetails appoinement in AppoinementDetailslist)
                    {
                        // check the availability of doctor for that department from today and display the message like below
                        if (appoinement.DoctorID == doctor.DoctorID && DateTime.Now.ToString("dd/MM/yyyy") == appoinement.Date.ToString("dd/MM/yyyy"))
                        {
                            checkCount++;
                        }
                    }

                    if (checkCount <= 1)
                    {

                        System.Console.WriteLine();
                        Console.WriteLine($"Doctor Name       : {doctor.Name}");
                        Console.WriteLine($"Doctor Department : {doctor.Department}");
                        System.Console.WriteLine();

                        // To book press “Y”, to cancel press “N”.
                        System.Console.WriteLine("Appointment is confirmed for the date-" + DateTime.Now.ToString("dd/MM/yyyy"));
                        Console.WriteLine("Do you want to Confirm your appoinement YES or N0");
                        string answer = Console.ReadLine().ToLower();
                        System.Console.WriteLine();
                        while (answer != "yes" && answer != "no")
                        {
                            Console.WriteLine("Invalid ");
                            Console.WriteLine("Do you want to Confirm your appoinement YES or N0");
                            answer = Console.ReadLine().ToLower();
                        }
                        //If the user presses “Y”, add a new appointment to Appointments List.
                        if (answer == "yes")
                        {
                            AppoinementDetails appoinementDetails = new AppoinementDetails(currentLoggedinPatient.PatientID, doctor.DoctorID, DateTime.Now, problem);
                            AppoinementDetailslist.Add(appoinementDetails);
                            //  appointmentBooking();
                            OnAppoinmentHandler?.Invoke(null, EventArgs.Empty);

                            Console.WriteLine($"Your Appoinement is Booked and your  AppointmentID : {appoinementDetails.AppointmentID} Appoinment Booked on {appoinementDetails.Date.ToString("dd/MM/yyyy")}");

                        }
                        if (answer == "no")
                        {
                            Console.WriteLine("Your current appoinement is not placed");
                        }
                    }
                    else { Console.WriteLine("Doctor is not free today"); }
                }
            }
            if (!checkdepartment)
            {
                System.Console.WriteLine("Invalid Department please enter the correct one");
            }


        }
        public static void ViewAppointmentdetails()
        {
            bool checkEntries = false;
            foreach (AppoinementDetails appoinement in AppoinementDetailslist)
            {
                if (currentLoggedinPatient.PatientID == appoinement.PatientID)
                {
                    foreach (DoctorDetails doctor in DoctorDetailslist)
                    {
                        if (doctor.DoctorID == appoinement.DoctorID)
                        {
                            checkEntries = true;
                            System.Console.WriteLine();
                            System.Console.WriteLine();
                            Console.WriteLine($"AppointmentID : {appoinement.AppointmentID}");
                            Console.WriteLine($"Doctor Name   : {doctor.Name}");
                            Console.WriteLine($"DoctorID      : {appoinement.DoctorID}");
                            Console.WriteLine($"Department    : {doctor.Department}");
                            System.Console.WriteLine();
                            break;
                        }
                    }
                }
            }
            if (!checkEntries)
            {
                Console.WriteLine("No Records Found");
            }

        }
        public static void Editmyprofile()
        {
            bool checkChoice = false;
            do
            {
                Console.WriteLine("Chose which one to modify");
                Console.WriteLine("1.Name\n2.Password\n3.Age\n4.Gender");
                checkChoice = int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the nmae to change");
                            currentLoggedinPatient.Name = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Password to change");
                            currentLoggedinPatient.Password = Console.ReadLine();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Age to change");
                            currentLoggedinPatient.Age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Gender to change");
                            currentLoggedinPatient.Gender = Enum.Parse<Gender>(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            checkChoice = false;
                            break;
                        }
                }
            } while (!checkChoice);


        }
        public static void BookAppointmentMessage(Object sender, EventArgs e)
        {
            System.Console.WriteLine(" Booking is Successfull");
        }
    }
}