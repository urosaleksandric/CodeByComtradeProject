using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityMenu
    {
        public static readonly string HumanityMenu_URL = "https://inc12.humanity.com/app/dashboard/";

        private static readonly string Dashboard_XPATH = "//p[contains(text(),'Dashboard')]";
        private static readonly string ShiftPlanning_XPATH = "//p[contains(text(),'ShiftPlanning')]";
        private static readonly string TimeClock_XPATH = "//p[contains(text(),'Time Clock')]";
        private static readonly string Leave_XPATH = "//p[@class='primNavQtip__itemName'][contains(text(),'Leave')]";
        private static readonly string Training_XPATH = "//p[contains(text(),'Training')]";
        private static readonly string Staff_XPATH = "//p[contains(text(),'Staff')]";
        private static readonly string Payroll_XPATH = "//p[contains(text(),'Payroll')]";
        private static readonly string Reports_XPATH = "//p[contains(text(),'Reports')]";
        private static readonly string SettingsBtn_XPATH = "//i[@class='primNavQtip__icon icon-gear']";

        //Dashboard
        public static IWebElement getDashboard(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Dashboard_XPATH));
        }
        public static void clickDashboard(IWebDriver webDriver)
        {
            getDashboard(webDriver).Click();
        }
        //ShiftPlanning
        public static IWebElement getShiftPlanning(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(ShiftPlanning_XPATH));
        }
        public static void clickShiftPlanning(IWebDriver webDriver)
        {
            getShiftPlanning(webDriver).Click();
        }
        //TimeClock
        public static IWebElement getTimeClock(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(TimeClock_XPATH));
        }
        public static void clickTimeClock(IWebDriver webDriver)
        {
            getTimeClock(webDriver).Click();
        }
        //Leave
        public static IWebElement getLeave(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Leave_XPATH));
        }
        public static void clickLeave(IWebDriver webDriver)
        {
            getLeave(webDriver).Click();
        }
        //Training
        public static IWebElement getTraining(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Training_XPATH));
        }
        public static void clickTraining(IWebDriver webDriver)
        {
            getTraining(webDriver).Click();
        }
        //Staff
        public static IWebElement getStaff(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Staff_XPATH));
        }
        public static void clickStaff(IWebDriver webDriver)
        {
            getStaff(webDriver).Click();
        }
        //Payroll
        public static IWebElement getPayroll(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Payroll_XPATH));
        }
        public static void clickPayroll(IWebDriver webDriver)
        {
            getPayroll(webDriver).Click();
        }
        //Reports
        public static IWebElement getReports(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Reports_XPATH));
        }
        public static void clickReports(IWebDriver webDriver)
        {
            getReports(webDriver).Click();
        }
        //Settings
        public static IWebElement getSettingsBtn(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SettingsBtn_XPATH));
        }
        public static void clickSettingsBtn(IWebDriver webDriver)
        {
            getSettingsBtn(webDriver).Click();
        }
    }
}
