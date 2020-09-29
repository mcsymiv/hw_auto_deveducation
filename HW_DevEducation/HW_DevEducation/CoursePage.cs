using OpenQA.Selenium;
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

        By PageTitle = By.CssSelector("html body.small.ru.deveducation.webp div.wrapper main.main section.origin-courses div._container.origin-courses__container h1.origin-courses__title.title2");
        By DniproLink = By.XPath("/html/body/div[2]/main/section[1]/div/div/ul/li[1]/a");
        By KyivLink = By.XPath("/html/body/div[2]/main/section[1]/div/div/ul/li[2]/a");
        By BakuLink = By.XPath("/html/body/div[2]/main/section[1]/div/div/ul/li[3]/a");
        By SpbLink = By.XPath("/html/body/div[2]/main/section[1]/div/div/ul/li[4]/a");
        By KharkivLink = By.XPath("/html/body/div[2]/main/section[1]/div/div/ul/li[5]/a");

        By CourseForm = By.Name("ajax-form");
        By FormTitle = By.XPath("/html/body/div[2]/main/div[1]/section/div/h2");
        By UserNameInput = By.Name("signUpCourse1Name");
        By UserPhoneInput = By.Name("signUpCourse1Tell");
        By UserEmailInput = By.Name("signUpCourse1Email");
        By SelectCourseList = By.Name("signUpCourse1CourseList");
        By SelectCityList = By.Name("signUpCourse1SityList");

        public CoursePage EnterUserName(string userName)
        {
            driver.FindElement(UserNameInput).SendKeys(userName);
            return this;
        }

        public CoursePage EnterUserPhone(string userPhone)
        {
            driver.FindElement(UserPhoneInput).SendKeys(userPhone);
            return this;
        }
    }
}
