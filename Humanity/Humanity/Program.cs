using System;
using Humanity.Page.Objects;
using Humanity.Page.Tests;

namespace Humanity
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;
            do
            {
                PrintMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("\nYou choose to exit from testing!\n");
                            exit = true;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("\nYou choose to test manual login page!\n");
                            HumanityLoginTests.doLogIn();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nYou choose to test login page with login data from excell table!\n");
                            HumanityLoginTests.doLogInAutomatic();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nYou choose to test manual adding new employees!\n");
                            HumanityAddNewEmployeeTests.AddNewEmployeeTests();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nYou choose to test adding new employees with employee data from excell table!\n");
                            HumanityAddNewEmployeeTests.AddNewEmployeeTestsAutomatic();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nYou choose to test edit staff!\n");
                            HumanityEditStaffTest.EditStaffTest();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\nYou choose to test changing settings!\n");
                            HumanitySettingsTest.SettingsTest();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nYou choose to test sign out from page!\n");
                            HumanityProfileSignOutTest.ProfileSignOutTest();
                            break;
                        }
                    default:
                        Console.WriteLine("\nOption does not exist\n");
                        break;
                }
            }
            while (!exit); 
        }
        static void PrintMenu()
        {
            Console.WriteLine("Choose the test, by number, that you would like to run:\n");
            Console.WriteLine("0 - Exit from testing");
            Console.WriteLine("1 - Humanity manual login test");
            Console.WriteLine("2 - Humanity automatic login test from excell table");
            Console.WriteLine("3 - Humanity manual add new employee test");
            Console.WriteLine("4 - Humanity automatic add new employee test from excell table");
            Console.WriteLine("5 - Humanity edit staff test");
            Console.WriteLine("6 - Humanity settings test");
            Console.WriteLine("7 - Humanity profile sign out test\n");
        }
    }
}
