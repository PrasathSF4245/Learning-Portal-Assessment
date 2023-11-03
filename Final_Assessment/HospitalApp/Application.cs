using Microsoft.Win32;
using System;
using System.Collections.Generic;
namespace HospitalApp;
class Application:AppointmentManager
{
   //Application is Started
   public static void StartApp()
    {

        Console.WriteLine("                    Welcome to the Hosptial        ");
      
        bool menuCheck = false;
        do
        {
            //Main menu is displayed
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Login\n2.Register\n3.Exit");
            menuCheck = int.TryParse(Console.ReadLine(), out int menuChoice);
            switch (menuChoice)
            {
                case 1:
                    {
                        Login();
                        menuCheck = false;
                        break;
                    }
                case 2:
                    {
                        Register();
                        menuCheck = false;
                        break;
                    }
                case 3:
                    {
                        menuCheck = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        menuCheck = false;
                        break;
                    }
            }
        } while (!menuCheck);

    }
    //New user Resgistration 
    public static void Register()
    {

        Console.WriteLine("Enter your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your Password");
        string password = Console.ReadLine();
        Console.WriteLine("Enter your Age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your Gender");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine());
        PatientDetails patient = new PatientDetails(password, name, age, gender);
        PatientDetailslist.Add(patient);
        Console.WriteLine($"Registration successfull your ID is : {patient.PatientID}");

    }
   //User Login 
    public static void Login()
    {
        bool checkPatient = false;
        Console.WriteLine("Enter your User Name");
        string checkname = Console.ReadLine();
        Console.WriteLine("Enter your Password");
        string checkpassword = Console.ReadLine();
        foreach (PatientDetails patient in PatientDetailslist)
        {
            if (patient.Name.ToLower() == checkname.ToLower() && patient.Password == checkpassword)
            {
                currentLoggedinPatient = patient;
                checkPatient = true;
            }
        }
        if (checkPatient)
        {
            bool checkSubmenu = false;
            do
            {
                //this shows the sub menu
                Console.WriteLine("Sub Main Menu");
                Console.WriteLine("1.Book Appointment\n2.View Appointment details\n3.Edit my profile\n4.Exit");
                checkSubmenu = int.TryParse(Console.ReadLine(), out int submenuchoice);
                switch (submenuchoice)
                {
                    case 1:
                        {
                            BookAppointment();
                            
                            checkSubmenu = false;
                            break;
                        }
                    case 2:
                        {
                            ViewAppointmentdetails();
                            checkSubmenu = false;
                            break;
                        }
                    case 3:
                        {
                            Editmyprofile();
                            checkSubmenu = false;
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            checkSubmenu = false;
                            break;
                        }
                }
            } while (!checkSubmenu);

        }
        if (!checkPatient)
        {
            
            Console.WriteLine("Sorry, your record is invalid. Please register your profile and log in again.");
        }
    }


    //Adding the Default Details
    public static void AddDefaultDetails()
    {
        //Assume your Doctors List having the following records,


        DoctorDetailslist.Add(new DoctorDetails("Nancy", "Anaesthesiology"));
        DoctorDetailslist.Add(new DoctorDetails("Andrew", "Cardiology"));
        DoctorDetailslist.Add(new DoctorDetails("Janet", "Diabetology"));
        DoctorDetailslist.Add(new DoctorDetails("Margaret", "Neonatology"));
        DoctorDetailslist.Add(new DoctorDetails("Steven", "Nephrology"));

        //Assume your Patients List having the following records,


        PatientDetailslist.Add(new PatientDetails("welcome", "Robert", 40, Gender.Male));
        PatientDetailslist.Add(new PatientDetails("welcome", "Laura", 36, Gender.Female));
        PatientDetailslist.Add(new PatientDetails("welcome", "Anne", 42, Gender.Female));


        //Assume your Appointments List having the following records,


        AppoinementDetailslist.Add(new AppoinementDetails(1, 2, new DateTime(2012, 3, 8), "Heart problem"));
        AppoinementDetailslist.Add(new AppoinementDetails(1, 5, new DateTime(2012, 3, 8), "Spinal cord injury"));
        AppoinementDetailslist.Add(new AppoinementDetails(2, 2, new DateTime(2012, 3, 8), "Heart attack"));
    }
}