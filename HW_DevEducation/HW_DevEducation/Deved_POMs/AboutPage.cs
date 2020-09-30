using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class AboutPage
    {
        IWebDriver driver;
        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By PageTitle = By.XPath("/html/body/div[2]/main/div[1]/div[1]/div[1]/h2");

        public string GetAboutPageTitle(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
