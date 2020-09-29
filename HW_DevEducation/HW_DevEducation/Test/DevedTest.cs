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
        HeaderCityRu head_city_ru_POM;

        [SetUp]
        public void OpenDevedPage()
        {
            mp_POM = new MainPage(chrome);
            head_city_ru_POM = new HeaderCityRu(chrome);

            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }

        [TestCase("Киев")]
        [TestCase("Днепр")]
        [TestCase("Харьков")]
        [TestCase("Баку")]
        [TestCase("Санкт-Петербург")]
        public void UserOpensKyivCoursePage(string localization)
        {
            string localCityText = string.Empty;
            switch (localization)
            {
                case "Киев":
                    mp_POM.SelectCityOnMap(mp_POM.KyivLinkOnMap);
                    break;
                case "Днепр":
                    mp_POM.SelectCityOnMap(mp_POM.DniproLinkOnMap);
                    break;
                case "Харьков":
                    mp_POM.SelectCityOnMap(mp_POM.KharkivLinkOnMap);
                    break;
                case "Баку":
                    mp_POM.SelectCityOnMap(mp_POM.BakuLinkOnMap);
                    break;
                case "Санкт-Петербугр":
                    mp_POM.SelectCityOnMap(mp_POM.SpbLinkOnMap);
                    break;
            }
            localCityText = head_city_ru_POM.CurrentCityText(head_city_ru_POM.currentCity);
            Assert.AreEqual(localization, localCityText);
        }



    }
}
