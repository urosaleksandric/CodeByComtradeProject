using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Humanity.Page.Objects
{
    public class HumanityEditStaff
    {
        public static readonly string EditStaff_URL = "https://inc12.humanity.com/app/staff/detail/5306203/";
        private static readonly string EditDetails_XPATH = "//a[contains(text(),'Edit Details')]";
        private static readonly string UploadPicture_XPATH = "//input[@id='fileupload']";
        private static readonly string Nickname_XPATH = "//input[@id='nick_name']";
        private static readonly string Picture_PATH = @"C:\Users\Rosulica\Desktop\Zavrsni projekat\IMG_3894(1).jpg";
        private static readonly string SaveEmployeeBtn_XPATH = "//button[@id='act_primary']";
        private static readonly string SaveEmployeeBtn2_XPATH = "//input[@name='update']";

        public static void NavigateToEditStaff_URL(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(EditStaff_URL);
        }
        //EditDetails
        public static IWebElement getEditDetails(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(EditDetails_XPATH));
        }
        public static void clickEditDetails(IWebDriver webDriver)
        {
            getEditDetails(webDriver).Click();
        }
        //UploadPicture
        public static IWebElement getUploadPicture(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(UploadPicture_XPATH));
        }
        public static void clickUploadPicture(IWebDriver webDriver)
        {
            getUploadPicture(webDriver).Click();
        }
        //GetPicture
        public static void getPicture(IWebDriver webDriver)
        {
            getUploadPicture(webDriver).SendKeys(Picture_PATH);
        }
        //Nickname
        public static IWebElement getNickname(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(Nickname_XPATH));
        }
        public static void sendNickname(IWebDriver webDriver, string data)
        {
            getNickname(webDriver).SendKeys(data);
        }
        //SaveEmployeeBtn
        public static IWebElement getSaveEmployeeBtn(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SaveEmployeeBtn_XPATH));
        }
        public static void clickSaveEmployeeBtn(IWebDriver webDriver)
        {
            getSaveEmployeeBtn(webDriver).Click();
        }
        //SaveEmployeeBtn2
        public static IWebElement getSaveEmployeeBtn2(IWebDriver webDriver)
        {
            return webDriver.FindElement(By.XPath(SaveEmployeeBtn2_XPATH));
        }
        public static void clickSaveEmployeeBtn2(IWebDriver webDriver)
        {
            getSaveEmployeeBtn2(webDriver).Click();
        }
    }
}
