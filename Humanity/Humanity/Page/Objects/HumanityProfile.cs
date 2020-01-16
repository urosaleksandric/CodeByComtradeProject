using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityProfile

    {
        public static readonly string HumanityProfileSettings_URL = "https://inc12.humanity.com/app/staff/edit/";

        private static readonly string Avatar_XPATH = "//img[@id='tr_avatar']";
        private static readonly string Profile_XPATH = "//a[contains(text(),'Profile')]";
        private static readonly string Settings_XPATH = "//div[@class='userm userm-mainPage']//a[contains(text(),'Settings')]";
        private static readonly string Availability_XPATH = "//div[@class='userm userm-mainPage']//a[contains(text(),'Availability')]";
        private static readonly string SigOut_XPATH = "//a[contains(text(),'Sign Out')]";
        private static readonly string HumanityAppVersion_XPATH = "//b[contains(text(),'9.13.4')]";
        private static readonly string clickArrow_XPATH = "//i[@class='icon icon-arrowFullDn j-arrowIconToAvatar navBottom__userArrow']";

        //Avatar
        public static IWebElement getAvatar(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Avatar_XPATH));
        }
        public static void clickAvatar(IWebDriver webDriver)
        {
            getAvatar(webDriver).Click();
        }
        //Profile
        public static IWebElement getProfile(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Profile_XPATH));
        }
        public static void clickProfile(IWebDriver webDriver)
        {
            getProfile(webDriver).Click();
        }
        //Settings
        public static IWebElement getSettings(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Settings_XPATH));
        }
        public static void clickSettings(IWebDriver webDriver)
        {
            getSettings(webDriver).Click();
        }
        //Availability
        public static IWebElement getAvailability(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Availability_XPATH));
        }
        public static void clickAvailability(IWebDriver webDriver)
        {
            getAvailability(webDriver).Click();
        }
        //SigOut
        public static IWebElement getSigOutBtn(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SigOut_XPATH));
        }
        public static void clickSigOutBtn(IWebDriver webDriver)
        {
            getSigOutBtn(webDriver).Click();
        }
        //HumanityAppVersion
        public static IWebElement getHumanityAppVersion(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(HumanityAppVersion_XPATH));
        }
        //clickArrow
        public static IWebElement getclickArrowBtn(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(clickArrow_XPATH));
        }
        public static void clickArrowBtn(IWebDriver webDriver)
        {
            getclickArrowBtn(webDriver).Click();
        }
    }
}
