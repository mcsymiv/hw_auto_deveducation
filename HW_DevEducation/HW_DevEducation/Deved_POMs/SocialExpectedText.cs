using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation.Deved_POMs
{
    public class SocialExpectedText
    {
        IWebDriver driver;
        public SocialExpectedText(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By ExPolicyLink = By.XPath("/html/body/div[2]/main/div/div/h1");
        public By ExFacebookLink = By.CssSelector("#u_0_0 > span._33vv > a > span");
        public By ExInstaLink = By.XPath("/html/body/div[1]/section/main/div/header/section/div[1]/h2");
        public By ExYoutubeLink = By.CssSelector("#text");
        public By ExLinkedLink = By.XPath("/html/body/main/section[1]/section[1]/div/div[1]/div[1]/h4");
        public By ExTwitterLnk = By.XPath("/html/body/div/div/div/div[2]/main/div/div/div/div[1]/div/div[2]/div/div/div[1]/div/div[2]/div/div/div[2]/div/span");
        public string CurrentSocialText(By locator)
        {
            return driver.FindElement(locator).Text;
        }
        public SocialExpectedText ClickOnFooterLink(By locator)
        {
            driver.FindElement(locator).Click();
            return this;
        }
    }
}
