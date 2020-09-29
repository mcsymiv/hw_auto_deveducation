using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class HeaderCityRu : HeaderRu
    {
        IWebDriver driver;
        public HeaderCityRu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By currentCity = By.XPath("/html/body/div[2]/div/header/div/div[1]/ul/li[2]/button");
        public By personalArea = By.XPath("/html/body/div[2]/div/header/div/div[1]/ul/li[1]/button");
        public HeaderCityRu ClickOnHeaderLink(By locator)
        {
            driver.FindElement(locator).Click();
            return this;
        }

        public string CurrentCityText(By locator)
        {
            return driver.FindElement(locator).Text;
        }

    }
}
