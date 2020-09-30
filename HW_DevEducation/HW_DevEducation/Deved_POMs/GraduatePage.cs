using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class GraduatePage
    {
        IWebDriver driver;
        public GraduatePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By PageTitle = By.XPath("/html/body/div[2]/main/section[1]/div/div/h1");
        public string GetGraduatePageTitle(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
