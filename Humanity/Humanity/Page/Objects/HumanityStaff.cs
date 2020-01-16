using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityStaff
    {
        public static readonly string HumanityStaff_URL = "https://inc12.humanity.com/app/staff/list/load/true/";

        private static readonly string AddEmployees_XPATH = "//button[@id='act_primary']";
        
        //get added employees
        private static readonly string EmployeesName_START = "//a[contains(text(),'";
        // + EmployeesName +
        private static readonly string EmployeesName_END = "')]";

        //send employee
        private static readonly string AddFirstName_XPATH = "//input[@id='_asf";
        private static readonly string AddLastName_XPATH = "//input[@id='_asl";
        private static readonly string AddEmail_XPATH= "//input[@id='_ase";
        // + i +
        private static readonly string EndOf_XPATH= "']";

        private static readonly string SaveEmployees_XPATH = "//button[@id='_as_save_multiple']";

        //AddEmployees
        public static IWebElement getAddEmployees(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(AddEmployees_XPATH));
        }
        public static void clickAddEmployees(IWebDriver webDriver)
        {
            getAddEmployees(webDriver).Click();
        }
        //EmployeesName
        public static IWebElement getEmployeesName(IWebDriver webDriver, string EmployeesName)
        {
            return webDriver.FindElement(By.XPath(EmployeesName_START + EmployeesName + EmployeesName_END));
        }
        public static void clickEmployeesLink(IWebDriver webDriver, string EmployeesName)
        {
            getEmployeesName(webDriver, EmployeesName).Click();
        }
        //AddFirstName
        public static IWebElement getAddFirstName(IWebDriver webDriver, int i)
        {
            return webDriver.FindElement(By.XPath(AddFirstName_XPATH + i + EndOf_XPATH));
        }
        public static void sendAddFirstName(IWebDriver webDriver, int i, string fname)
        {
            getAddFirstName(webDriver, i).SendKeys(fname);
        }
        //AddLastName
        public static IWebElement getAddLastName(IWebDriver webDriver, int i)
        {
            return webDriver.FindElement(By.XPath(AddLastName_XPATH + i + EndOf_XPATH));
        }
        public static void sendAddLastName(IWebDriver webDriver, int i, string lname)
        {
            getAddLastName(webDriver, i).SendKeys(lname);
        }
        //AddEmail
        public static IWebElement getAddEmail(IWebDriver webDriver, int i)
        {
            return webDriver.FindElement(By.XPath(AddEmail_XPATH + i + EndOf_XPATH));
        }
        public static void sendAddEmail(IWebDriver webDriver, int i, string email)
        {
            getAddEmail(webDriver, i).SendKeys(email);
        }
        //SaveEmployees
        public static IWebElement getSaveEmployees(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SaveEmployees_XPATH));
        }
        public static void clickSaveEmployees(IWebDriver webDriver)
        {
            getSaveEmployees(webDriver).Click();
        }
    }
}
