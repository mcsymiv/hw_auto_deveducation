using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class MainPage
    {
        IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By SpbLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[4]");
        public By KyivLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[1]");
        public By DniproLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[2]");
        public By KharkivLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[3]");
        public By BakuLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[5]");

        public void SelectCityOnMap(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
