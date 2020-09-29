using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation.Test
{
    [TestFixture]
    public class DevedTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        MainPage mp_POM;
        CoursePage cp_POM;


        [SetUp]
        public void OpenDevedPage()
        {
            mp_POM = new MainPage(chrome);
            cp_POM = new CoursePage(chrome);
            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        [TearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }
        [TestCase("Киев")]
        public void UserOpensKyivCoursePage(string localization)
        {
            mp_POM.SelectCityOnMap(mp_POM.KyivLinkOnMap);
            string localText = chrome.FindElement(By.XPath("/html/body/div[2]/div/header/div/div[1]/ul/li[2]/button")).Text;
            Assert.AreEqual(localization, localText);
        }
    }
}
