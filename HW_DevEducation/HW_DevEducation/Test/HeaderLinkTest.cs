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
    public class HeaderLinkTest
    {
        IWebDriver chrome = new ChromeDriver(@"C:\Users\mcsymiv\Desktop\git\chromedriver_win32");

        MainPage mp_POM;
        HeaderCityRu head_ru_POM;
        CoursePage cr_POM;
        GraduatePage gr_POM;
        NewsPage news_POM;
        BlogPage blog_POM;
        AboutPage about_POM;
        ContactPage contact_POM;

        [SetUp]
        public void OpenDevedPage()
        {
            mp_POM = new MainPage(chrome);
            head_ru_POM = new HeaderCityRu(chrome);
            cr_POM = new CoursePage(chrome);
            gr_POM = new GraduatePage(chrome);
            news_POM = new NewsPage(chrome);
            blog_POM = new BlogPage(chrome);
            about_POM = new AboutPage(chrome);
            contact_POM = new ContactPage(chrome);

            chrome.Navigate().GoToUrl("https://deveducation.com");
            chrome.Manage().Window.Maximize();
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void CloseBroser()
        {
            chrome.Quit();
        }

        [TestCase("Наши курсы")]
        [TestCase("Наши выпускники")]
        [TestCase("Новости")]
        [TestCase("Блог")]
        [TestCase("О нас")]
        [TestCase("Наши контакты")]
        public void UserOpensPagesViaHeaderLinks(string pageTitle)
        {
            string actualPageTitle = string.Empty;
            switch (pageTitle)
            {
                case "Наши курсы":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.CourseLink);
                    actualPageTitle = cr_POM.GetCoursePageTitle(cr_POM.PageTitle);
                    break;
                case "Наши выпускники":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.GraduatesLink);
                    actualPageTitle = gr_POM.GetGraduatePageTitle(gr_POM.PageTitle);
                    break;
                case "Новости":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.NewsLink);
                    actualPageTitle = news_POM.GetNewsPageTitle(news_POM.PageTitle);
                    break;
                case "Блог":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.BlogLink);
                    actualPageTitle = blog_POM.GetBlogPageTitle(blog_POM.PageTitle);
                    break;
                case "О нас":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.AboutUsLink);
                    actualPageTitle = about_POM.GetAboutPageTitle(about_POM.PageTitle);
                    break;
                case "Наши контакты":
                    head_ru_POM.ClickOnHeaderLink(head_ru_POM.ContactsLink);
                    actualPageTitle = contact_POM.GetContactPageTitle(contact_POM.PageTitle);
                    break;
            }
            Assert.AreEqual(pageTitle, actualPageTitle);
        }
    }
}
