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
        By SpbLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[4]");
        By KyivLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[1]");
        By DniproLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[2]");
        By KharkivLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[3]");
        By BakuLinkOnMap = By.XPath("/html/body/div[2]/main/section/div/div[2]/div/a[5]");

        public void SelectCityOnMap(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
