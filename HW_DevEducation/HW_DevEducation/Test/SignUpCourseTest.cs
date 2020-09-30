using HW_DevEducation.Deved_POMs;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation.Test
{
    [TestFixture]
    public class SignUpCourseTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");
        MainPage mp_POM;
        SignUpCourseForm signUp_POM;


        [SetUp]
        public void OpenDevedPopUpForm()
        {
            mp_POM = new MainPage(chrome);
            signUp_POM = new SignUpCourseForm(chrome);
            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            signUp_POM.StartForm();
        }

        [OneTimeTearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }

        [TestCase("Имя", "", "981068405", "test@gmail.com", 3, 2, "Поле обязательно для заполнения")]
        // [TestCase("Телефон", "Иван", "", "test@gmail.com", 4, 2, "Поле обязательно для заполнения")]
        // [TestCase("Email", "Иван", "0981060000", "", 6, 3, "Поле обязательно для заполнения")]
       
        public void UserSignUpForCourseOnMainPageWithOneRequiredFieldEmpty(string testName, string name, string number, string mail, int indexSity, int indexCourse, string expectedMessage)
        {
            string actualText = string.Empty;
            switch (testName)
            {
                case "Имя":
                    signUp_POM.MakeClickOnFormField(signUp_POM.userNameInput)
                        .EnterUserName(name)
                        .EnterUserPhone(number)
                        .EnterUserEmail(mail)
                        .ChooseCity(indexSity)
                        .ChooseCourse(indexCourse);
                    break;

                case "Телефон":
                    signUp_POM.EnterUserName(name)
                        .MakeClickOnFormField(signUp_POM.userPhoneInput)
                        .EnterUserPhone(number)
                        .EnterUserEmail(mail)
                        .ChooseCity(indexSity)
                        .ChooseCourse(indexCourse);
                    break;

                case "Email":
                    signUp_POM.EnterUserName(name)
                        .EnterUserPhone(number)
                        .MakeClickOnFormField(signUp_POM.userEmailInput)
                        .EnterUserEmail(mail)
                        .ChooseCity(indexSity)
                        .ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    break;
            }
            actualText = signUp_POM.CurrentErrorText(signUp_POM.ErrorDataMessage);
            Assert.AreEqual(expectedMessage, actualText);
        }
    }
}
