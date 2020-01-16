using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityHome
    {
        public static readonly string Humanity_URL = "https://www.humanity.com/";
        public static readonly string HumanityLogin_URL = "https://www.humanity.com/app/";

        private static readonly string AboutUs_XPATH = "//a[@class='nav-link no-before'][contains(text(),'About us')]";

        private static readonly string LogIn_XPATH = "//p[contains(text(),'LOGIN')]";
        private static readonly string LogInUsername_XPATH = "//input[@id='email']";
        private static readonly string LogInPassword_XPATH = "//input[@id='password']";
        private static readonly string LogInButton_XPATH = "//button[@name='login'][contains(text(),'Log in')]";

        private static readonly string UpperStartMyFreeTrial_XPATH = "//a[@class='button pale']";
        private static readonly string FullName_XPATH = "//div[@class='input-wrapper']//input[@placeholder='Full Name']";
        private static readonly string WorkEmail_XPATH = "//div[@class='input-wrapper']//input[@placeholder='Work Email']";
        private static readonly string MiddleStartMyFreeTrial_XPATH = "//input[@id='free-trial-link-01']";

        public static void NavigateToHumanity_URL(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(Humanity_URL);
        }
        //AboutUs
        public static IWebElement getAboutUs(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(AboutUs_XPATH));
        }
        public static void clickAboutUs(IWebDriver webDriver)
        {
            getAboutUs(webDriver).Click();
        }
        //LogIn
        public static IWebElement getLogIn(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(LogIn_XPATH));
        }
        public static void clickLogIn(IWebDriver webDriver)
        {
            getLogIn(webDriver).Click();
        }
        //LogInUsername
        public static IWebElement getLogInUsername(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(LogInUsername_XPATH));
        }
        public static void sendLogInUsername(IWebDriver webDriver, string data)
        {
            getLogInUsername(webDriver).SendKeys(data);
        }
        //LogInPassword
        public static IWebElement getLogInPassword(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(LogInPassword_XPATH));
        }
        public static void sendLogInPassword(IWebDriver webDriver, string data)
        {
            getLogInPassword(webDriver).SendKeys(data);
        }
        //LogInButton
        public static IWebElement getLogInButton(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(LogInButton_XPATH));
        }
        public static void clickLogInButton(IWebDriver webDriver)
        {
            getLogInButton(webDriver).Click();
        }
        //UpperStartMyFreeTrial
        public static IWebElement getUpperStartMyFreeTrial(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(UpperStartMyFreeTrial_XPATH));
        }
        public static void clickUpperStartMyFreeTrial(IWebDriver webDriver)
        {
            getUpperStartMyFreeTrial(webDriver).Click();
        }
        //FullName
        public static IWebElement getFullName(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(FullName_XPATH));
        }
        public static void sendFullName(IWebDriver webDriver, string data)
        {
            getFullName(webDriver).SendKeys(data);
        }
        //WorkEmail
        public static IWebElement getWorkEmail(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(WorkEmail_XPATH));
        }
        public static void sendWorkEmail(IWebDriver webDriver, string data)
        {
            getWorkEmail(webDriver).SendKeys(data);
        }
        //MiddleStartMyFreeTrial
        public static IWebElement getMiddleStartMyFreeTrial(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(MiddleStartMyFreeTrial_XPATH));
        }
        public static void clickMiddleStartMyFreeTrial(IWebDriver webDriver)
        {
            getMiddleStartMyFreeTrial(webDriver).Click();
        }
    }
}
