using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using Humanity.Page.Objects;

namespace Humanity.Page.Tests
{
    public class HumanityLoginTests
    {
        public static void goToLogIn()
        {
            IWebDriver webDriver= new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

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
        }

        public static void doLogIn()
        {
            IWebDriver webDriver = new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

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

            webDriver.Quit();
        }
        public static void doLogInAutomatic()
        {
            IWebDriver webDriver = new ChromeDriver(Constants.WEBDRIVER_PATH);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            webDriver.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");

            //Ucitavanje tabele Login
            ExcelUtility.OpenFile(Constants.LOGIN_PATH);
            //Ucitavanje work sheet-a
            ExcelUtility.LoadWorkSheet(0);

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
