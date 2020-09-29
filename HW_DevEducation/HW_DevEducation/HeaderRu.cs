using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class HeaderRu : Header
    {
        IWebDriver driver;
        public HeaderRu(IWebDriver driver)
        {
            this.driver = driver;
        }
        By CourseLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[1]/a");
        By GraduatesLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[2]/a");
        By NewsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[3]/a");
        By BlogLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[4]/a");
        By AboutUsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[5]/a");
        By ContactsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[6]/a");

        public void ClickOnHeaderLink(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
