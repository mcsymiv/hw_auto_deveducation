using HW_DevEducation.Deved_POMs;
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
    public class SocialTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32"); //@"I:\DevEducation практика\selenium"); 
        FooterRu fr_POM;
        SocialExpectedText sxt_POM;

        [SetUp]
        public void OpenSocialPage()
        {
            fr_POM = new FooterRu(chrome);
            sxt_POM = new SocialExpectedText(chrome);
            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }

        [TestCase("Политика конфиденциальности")] //Policy
        [TestCase("Dev.education")] //Facebook 
        [TestCase("dev.education")] //Instagram
        [TestCase("DevEducation")] //Youtube 
        [TestCase("Международный IT-колледж DevEducation")] //LinkedIn
        [TestCase("@DevEducation2")] //Twitter
        public void UserOpensSocialPage(string localization)
        {
            string actualText = string.Empty;
            switch (localization)
            {
                case "Политика конфиденциальности": //Policy
                    fr_POM.ClickOnSocialIconLink(fr_POM.PolicyLink);
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExPolicyLink);
                    break;
                case "Dev.education": //Facebook 
                    fr_POM.ClickOnSocialIconLink(fr_POM.FacebookLink);
                    chrome.SwitchTo().Window(chrome.WindowHandles.Last());
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExFacebookLink);
                    break;
                case "dev.education": //Instagram
                    sxt_POM.ClickOnFooterLink(fr_POM.InstaLink);
                    chrome.SwitchTo().Window(chrome.WindowHandles.Last());
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExInstaLink);
                    break;

                case "DevEducation": //Youtube 
                    sxt_POM.ClickOnFooterLink(fr_POM.YoutubeLink);
                    chrome.SwitchTo().Window(chrome.WindowHandles.Last());
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExYoutubeLink);
                    break;
                case "Международный IT-колледж DevEducation":  //LinkedIn
                    sxt_POM.ClickOnFooterLink(fr_POM.LinkedLink);
                    chrome.SwitchTo().Window(chrome.WindowHandles.Last());
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExLinkedLink);
                    break;
                case "@DevEducation2":  //Twitter
                    sxt_POM.ClickOnFooterLink(fr_POM.TwitterLnk);
                    chrome.SwitchTo().Window(chrome.WindowHandles.Last());
                    actualText = sxt_POM.CurrentSocialText(sxt_POM.ExTwitterLnk);
                    break;
            }
            Assert.AreEqual(localization, actualText);

        }
    }
}