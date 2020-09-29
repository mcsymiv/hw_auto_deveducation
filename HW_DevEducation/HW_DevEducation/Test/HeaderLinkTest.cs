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
    public class HeaderLinkTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        MainPage mp_POM;
        HeaderCityRu head_ru_POM;

        [SetUp]
        public void OpenDevedPage()
        {
            mp_POM = new MainPage(chrome);
            head_ru_POM = new HeaderCityRu(chrome);

            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }

        [TestCase("Наши курсы")]
        public void UserOpensHeaderLinkPages(string pageTitle)
        {
            head_ru_POM.ClickOnHeaderLink(head_ru_POM.CourseLink);
        }
    }
}
