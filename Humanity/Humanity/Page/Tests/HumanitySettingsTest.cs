using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using Humanity.Page.Objects;

namespace Humanity.Page.Tests
{
    public class HumanitySettingsTest
    {
        public static void SettingsTest()
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

                HumanityMenu.clickSettingsBtn(webDriver);
                if (webDriver.Url.Contains(HumanitySettings.HumanitySettings_URL))
                {
                    Console.WriteLine("Settings page successfully loaded");
                }
                else
                {
                    Console.WriteLine("Settings page failed to load");
                }

                HumanitySettings.sendCountry(webDriver, "Serbia");
                HumanitySettings.sendDefaultLanguage(webDriver, "American English");
                HumanitySettings.sendTimeFormat(webDriver, "24 hour");
                HumanitySettings.clickSaveSettings(webDriver);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Settings updated successfully");

            webDriver.Quit();
        }
        public static void LogInFillForm(IWebDriver webDriver, string username, string password)
        {
            HumanityLogin.sendLogInUsername(webDriver, username);
            HumanityLogin.sendLogInPassword(webDriver, password);
        }
    }
}
