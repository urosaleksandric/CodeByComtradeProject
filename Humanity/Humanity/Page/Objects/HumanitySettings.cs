using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Humanity.Page.Objects
{
    public class HumanitySettings
    {
        public static readonly string HumanitySettings_URL = "https://inc12.humanity.com/app/admin/settings/";
        
        private static readonly string Country_XPATH = "//select[@id='country']";
        private static readonly string DefaultLanguage_XPATH = "//select[@name='language']";
        private static readonly string TimeFormat_XPATH = "//select[@name='pref_24hr']";
        private static readonly string SaveSettings_XPATH = "//button[@id='act_primary']";

        //Country
        public static SelectElement getCountry(IWebDriver webDriver)
        {
            return new SelectElement(webDriver.FindElement(By.XPath(Country_XPATH)));
        }
        public static void sendCountry(IWebDriver webDriver,string countrySelect)
        {
            getCountry(webDriver).SelectByText(countrySelect);
        }
        //DefaultLanguage
        public static SelectElement getDefaultLanguage(IWebDriver webDriver)
        {
            return new SelectElement(webDriver.FindElement(By.XPath(DefaultLanguage_XPATH)));
        }
        public static void sendDefaultLanguage(IWebDriver webDriver, string languageSelect)
        {
            getDefaultLanguage(webDriver).SelectByText(languageSelect);
        }
        //TimeFormat
        public static SelectElement getTimeFormat(IWebDriver webDriver)
        {
            return new SelectElement(webDriver.FindElement(By.XPath(TimeFormat_XPATH)));
        }
        public static void sendTimeFormat(IWebDriver webDriver, string tformatselect)
        {
            getTimeFormat(webDriver).SelectByText(tformatselect);
        }
        //SaveSettings
        public static IWebElement getSaveSettings(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SaveSettings_XPATH));
        }
        public static void clickSaveSettings(IWebDriver webDriver)
        {
            getSaveSettings(webDriver).Click();
        }
    }
}
