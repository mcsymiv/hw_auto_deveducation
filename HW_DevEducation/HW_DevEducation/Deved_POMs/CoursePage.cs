using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class CoursePage
    {
        IWebDriver driver;
        public CoursePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By PageTitle = By.CssSelector("html body.small.ru.deveducation.webp div.wrapper main.main section.origin-courses div._container.origin-courses__container h1.origin-courses__title.title2");

        public string GetCoursePageTitle(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
