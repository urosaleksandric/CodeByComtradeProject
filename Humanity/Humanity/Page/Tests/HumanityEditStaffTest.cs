﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using Humanity.Page.Objects;

namespace Humanity.Page.Tests
{
    public class HumanityEditStaffTest
    {
        public static void EditStaffTest()
        {
            IWebDriver webDriver = new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

            //Ucitavanje tabele Login
            ExcelUtility.OpenFile(Constants.LOGIN_PATH);
            //Ucitavanje work sheet-a
            ExcelUtility.LoadWorkSheet(0);
            try
            {
                //Prolazak Log In forme sa podacima iz tabele
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
                    HumanityProfile.clickAvatar(webDriver);

                    HumanityProfile.clickSettings(webDriver);
                    if (webDriver.Url.Contains(HumanityProfile.HumanityProfileSettings_URL))
                    {
                        Console.WriteLine("Profile settings page successfully loaded");
                    }
                    else
                    {
                        Console.WriteLine("Profile settings page failed to load");
                    }

                    HumanityEditStaff.getPicture(webDriver);
                    HumanityEditStaff.sendNickname(webDriver, "uros123");
                    HumanityEditStaff.clickSaveEmployeeBtn2(webDriver);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Edit completed");

            webDriver.Quit();
        }
        public static void LogInFillForm(IWebDriver webDriver, string username, string password)
        {
            HumanityLogin.sendLogInUsername(webDriver, username);
            HumanityLogin.sendLogInPassword(webDriver, password);
        }
    }
}
