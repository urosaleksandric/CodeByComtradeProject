﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using Humanity.Page.Objects;

namespace Humanity.Page.Tests
{
    public class HumanityAddNewEmployeeTests
    {
        public static void AddNewEmployeeTests()
        {
            IWebDriver webDriver = new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

            try
            {
                HumanityHome.NavigateToHumanity_URL(webDriver);
                if (webDriver.Url.Contains(HumanityHome.Humanity_URL))
                {
                    Console.WriteLine("Home page successfully loaded");
                }
                else
                {
                    Console.WriteLine("Home page failed to load");
                }

                HumanityHome.clickLogIn(webDriver);
                if (webDriver.Url.Contains(HumanityHome.HumanityLogin_URL))
                {
                    Console.WriteLine("Login page successfully loaded");
                }
                else
                {
                    Console.WriteLine("Login page failed to load");
                }

                LogInFillForm(webDriver, "bamem58343@clsn.top", "humanity123");

                HumanityLogin.clickLogInButton(webDriver);
                if (webDriver.Url.Contains(HumanityLogin.HumanityLogin_URL))
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login Unsuccessful");
                }

                HumanityMenu.clickStaff(webDriver);
                if (webDriver.Url.Contains(HumanityStaff.HumanityStaff_URL))
                {
                    Console.WriteLine("Staff page successfully loaded");
                }
                else
                {
                    Console.WriteLine("Staff page failed to load");
                }

                HumanityStaff.clickAddEmployees(webDriver);
                HumanityStaff.sendAddFirstName(webDriver, 1, "Nikola");
                HumanityStaff.sendAddLastName(webDriver, 1, "Nikolic");
                HumanityStaff.sendAddEmail(webDriver, 1, "@gmail.com");
                HumanityStaff.clickSaveEmployees(webDriver);
                Console.WriteLine("Employee added");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            webDriver.Quit();
        }
        public static void AddNewEmployeeTestsAutomatic()
        {
            IWebDriver webDriver = new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

            //Ucitavanje tabele Login
            ExcelUtility.OpenFile(Constants.LOGIN_PATH);
            ////Ucitavanje work sheet-a
            ExcelUtility.LoadWorkSheet(0);
            //Ucitavanje tabele Zaposleni
            ZaposleniExcelUtility.OpenFile(Constants.ZAPOSLENI_PATH);
            ////Ucitavanje work sheet-a
            ZaposleniExcelUtility.LoadWorkSheet(0);

            try
            {
                for (int i = 1; i < ExcelUtility.GetRowCount(); i++)
                {
                    string email = ExcelUtility.GetDataAt(i, 3);
                    string password = ExcelUtility.GetDataAt(i, 10);

                    HumanityHome.NavigateToHumanity_URL(webDriver);
                    if (webDriver.Url.Contains(HumanityHome.Humanity_URL))
                    {
                        Console.WriteLine("Home page successfully loaded");
                    }
                    else
                    {
                        Console.WriteLine("Home page failed to load");
                    }

                    HumanityHome.clickLogIn(webDriver);
                    if (webDriver.Url.Contains(HumanityHome.HumanityLogin_URL))
                    {
                        Console.WriteLine("Login page successfully loaded");
                    }
                    else
                    {
                        Console.WriteLine("Login page failed to load");
                    }
                    
                    LogInFillForm(webDriver, email, password);

                    HumanityLogin.clickLogInButton(webDriver);
                    if (webDriver.Url.Contains(HumanityLogin.HumanityLogin_URL))
                    {
                        Console.WriteLine("Login Successful");
                    }
                    else
                    {
                        Console.WriteLine("Login Unsuccessful");
                    }
                }
                HumanityMenu.clickStaff(webDriver);
                if (webDriver.Url.Contains(HumanityStaff.HumanityStaff_URL))
                {
                    Console.WriteLine("Staff page successfully loaded");
                }
                else
                {
                    Console.WriteLine("Staff page failed to load");
                }

                HumanityStaff.clickAddEmployees(webDriver);

                //adding employee
                for (int i = 1; i < ZaposleniExcelUtility.GetRowCount(); i++)
                {
                    string fname = ZaposleniExcelUtility.GetDataAt(i, 0);
                    string lname = ZaposleniExcelUtility.GetDataAt(i, 1);
                    string email = ZaposleniExcelUtility.GetDataAt(i, 3);

                    HumanityStaff.sendAddFirstName(webDriver, i, fname);
                    HumanityStaff.sendAddLastName(webDriver, i, lname);
                    HumanityStaff.sendAddEmail(webDriver, i, email);
                }
                HumanityStaff.clickSaveEmployees(webDriver);
                Console.WriteLine("Employee added");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            webDriver.Quit();
        }
        public static void LogInFillForm(IWebDriver webDriver, string username, string password)
        {
            HumanityLogin.sendLogInUsername(webDriver, username);
            HumanityLogin.sendLogInPassword(webDriver, password);
        }
    }

}
