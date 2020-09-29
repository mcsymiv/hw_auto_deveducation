using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation.Deved_POMs
{
    public class SignUpCourseForm
    {
        IWebDriver driver;
        public SignUpCourseForm(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By signUpCourseButton = By.Name("entry");
        public By CourseForm = By.Name("ajax-form");
        public By FormTitle = By.XPath("/html/body/div[2]/main/div[1]/section/div/h2");
        public By UserNameInput = By.Name("signUpCourse1Name");
        public By UserPhoneInput = By.Name("signUpCourse1Tell");
        public By UserEmailInput = By.Name("signUpCourse1Email");
        public By SelectCourseList = By.Name("signUpCourse1CourseList");
        public By SelectCityList = By.Name("signUpCourse1SityList");

        public SignUpCourseForm EnterUserName(string userName)
        {
            driver.FindElement(UserNameInput).SendKeys(userName);
            return this;
        }
        public SignUpCourseForm EnterUserPhone(string userPhone)
        {
            driver.FindElement(UserPhoneInput).SendKeys(userPhone);
            return this;
        }
        public SignUpCourseForm EnterUserEmail(string userEmail)
        {
            driver.FindElement(UserEmailInput).SendKeys(userEmail);
            return this;
        }
        public SignUpCourseForm SelectCity(string city)
        {
            IWebElement selectList = driver.FindElement(SelectCityList);
            SelectElement selectElement = new SelectElement(selectList);
            selectElement.SelectByValue(city);
            return this;
        }
        public SignUpCourseForm SelectCourse(string course)
        {
            IWebElement selectList = driver.FindElement(SelectCourseList);
            SelectElement selectElement = new SelectElement(selectList);
            selectElement.SelectByValue(course);
            return this;
        }
    }
}
