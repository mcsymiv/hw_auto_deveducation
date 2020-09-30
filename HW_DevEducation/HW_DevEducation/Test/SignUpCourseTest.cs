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

        [TestCase("Валидный", "981068405", "test@gmail.com", 3, 2)]
        [TestCase("Телефон", "+++++++++", "test@gmail.com", 4, 2)]
        [TestCase("Телефон", "", "test@gmail.com", 5, 2)]
        [TestCase("Email", "0981060000", "email", 6, 3)]
        [TestCase("Email", "0981060000", "", 5, 4)]
        [TestCase("Sity", "0981060000", "test@gmail.com", 2, 4)]
        [TestCase("Courses", "0981060000", "test@gmail.com", 4, 1)]

        public void UserSignUpForCourseOnMainPage(string name, string number, string mail, int indexSity, int indexCourse)
        {
            string actualText = string.Empty;
            switch (name)
            {
                case "Валидный":
                    signUp_POM.EnterUserName(name).EnterUserPhone(number).EnterUserEmail(mail).ChooseCity(indexSity).ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    break;

                case "Телефон":
                    signUp_POM.EnterUserName(name).EnterUserPhone(number).EnterUserEmail(mail).ChooseCity(indexSity).ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    actualText = signUp_POM.CurrentErrorText(signUp_POM.errorNumber);
                    Assert.AreEqual(name, actualText);
                    //signUp_POM.FindCaptcha();                  
                    break;

                case "Email":
                    signUp_POM.EnterUserName(name).EnterUserPhone(number).EnterUserEmail(mail).ChooseCity(indexSity).ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    actualText = signUp_POM.CurrentErrorText(signUp_POM.errorEmail);
                    Assert.AreEqual(name, actualText);
                    break;

                case "City":
                    signUp_POM.EnterUserName(name).EnterUserPhone(number).EnterUserEmail(mail).ChooseCity(indexSity).ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    actualText = signUp_POM.CurrentErrorText(signUp_POM.errorCity);
                    //Console.WriteLine(actualText);
                    //Assert.AreEqual(name, actualText);
                    break;

                case "Course":
                    signUp_POM.EnterUserName(name).EnterUserPhone(number).EnterUserEmail(mail).ChooseCity(indexSity);
                    signUp_POM.ChooseCourse(indexCourse);
                    signUp_POM.SendForm();
                    actualText = signUp_POM.CurrentErrorText(signUp_POM.errorCourse);
                    Assert.AreEqual(name, actualText);
                    break;
            }
        }
    }
}
