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
        public By signUpCourseButton = By.CssSelector("body > div.wrapper > main > div.fix-btn.active > button");
        public By userNameInput = By.CssSelector("#entry-popup-form > div:nth-child(1) > input");
        public By userPhoneInput = By.CssSelector("#entry-popup-form > div:nth-child(2) > input");
        public By userEmailInput = By.CssSelector("#entry-popup-form > div:nth-child(3) > input");

        public By nameOfForm = By.XPath("/html/body/div[2]/main/div[2]/div/div/div");
        public By selectCityList = By.CssSelector("s#city-popup");
        public By selectCourseList = By.CssSelector("#course-popup");

        public By sendButton = By.CssSelector("#entry-popup-form > div:nth-child(6) > button.form__btn.field.form-btn.popup__button__valid.popup__button__valid__indent.g-recaptcha");
        public By captcha = By.CssSelector("# recaptcha-verify-button");
        public By erorNumber = By.CssSelector("#entry-popup-form > div:nth-child(2)");
        public By erorEmail = By.CssSelector("#entry-popup-form > div:nth-child(3)");
        public By erorSity = By.CssSelector("#entry-popup-form > div:nth-child(4)");
        public By erorCourse = By.CssSelector("#entry-popup-form > div:nth-child(5)");


        public SignUpCourseForm StartForm()
        {
            driver.FindElement(signUpCourseButton).Click();
            return this;
        }
        public SignUpCourseForm EnterUserName(string userName)
        {
            driver.FindElement(userNameInput).SendKeys(userName);
            return this;
        }
        public SignUpCourseForm EnterUserPhone(string userPhone)
        {
            driver.FindElement(userPhoneInput).SendKeys(userPhone);
            return this;
        }
        public SignUpCourseForm EnterUserEmail(string userEmail)
        {
            driver.FindElement(userEmailInput).SendKeys(userEmail);
            return this;
        }
        public SignUpCourseForm SendForm()
        {
            driver.FindElement(sendButton).Click();
            return this;
        }
        public SignUpCourseForm SelectCity(string city)
        {
            IWebElement selectList = driver.FindElement(selectCityList);
            SelectElement selectElement = new SelectElement(selectList);
            selectElement.SelectByValue(city);
            return this;
        }
        public SignUpCourseForm SelectCourse(string course)
        {
            IWebElement selectList = driver.FindElement(selectCourseList);
            SelectElement selectElement = new SelectElement(selectList);
            selectElement.SelectByValue(course);
            return this;
        }
        public SignUpCourseForm FindCaptcha()
        {
            IWebElement selectList = driver.FindElement(captcha);
            return this;
        }

        public string CurrentErorText(By locator)
        {
            return driver.FindElement(locator).Text;
        }

        public void ClicOnNameOfForm()
        {
            driver.FindElement(userPhoneInput).Click();
        }

        public void ChoseSity(int index)
        {
            IWebElement dropdownCity = driver.FindElement(By.Id("city-popup"));
            var selectElementCity = new SelectElement(dropdownCity);
            selectElementCity.SelectByIndex(index);

        }

        public void ChoseCourse(int index)
        {
            IWebElement dropdownCourse = driver.FindElement(By.Id("course-popup"));
            var selectElementCourse = new SelectElement(dropdownCourse);
            selectElementCourse.SelectByIndex(index);
        }

    }
}
