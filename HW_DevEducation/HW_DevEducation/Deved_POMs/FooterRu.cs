﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class FooterRu : Footer
    {
        IWebDriver driver;
        public FooterRu(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By CourseLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[1]/a");
        public By GraduatesLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[2]/a");
        public By NewsLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[3]/a");
        public By BlogLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[4]/a");
        public By AboutUsLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[5]/a");
        public By ContactsLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[6]/a");
        public By FaqLink = By.XPath("/html/body/div[2]/footer/div/nav/ul/li[7]/a");

        public void ClickOnSocialIconLink(By locator)
        {
            driver.FindElement(locator).Click();
        }
        public void ClickOnFooterLink(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public string CurrentCityText(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
