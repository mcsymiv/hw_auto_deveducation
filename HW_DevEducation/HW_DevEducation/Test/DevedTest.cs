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
        public MainPage mp_POM;
        CoursePage cp_POM;
        HeaderCityRu head_city_ru_POM;


        [SetUp]
        public void OpenDevedPage()
        {
            mp_POM = new MainPage(chrome);
            cp_POM = new CoursePage(chrome);
            head_city_ru_POM = new HeaderCityRu(chrome);
            
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
            string localCityText = head_city_ru_POM.CurrentCityText(head_city_ru_POM.currentCity);
            Assert.AreEqual(localization, localCityText);
        }
    }
}
