using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityLogin
    {
        public static readonly string HumanityLogin_URL = "https://www.humanity.com/app/";

        private static readonly string LogInUsername_XPATH = "//input[@id='email']";
        private static readonly string LogInPassword_XPATH = "//input[@id='password']";
        private static readonly string LogInButton_XPATH = "//button[@name='login'][contains(text(),'Log in')]";

        public static void NavigateToHumanityLogin_URL(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(HumanityLogin_URL);
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
    }
}
