using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class HeaderRu : Header
    {
        public By CourseLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[1]/a");
        public By GraduatesLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[2]/a");
        public By NewsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[3]/a");
        public By BlogLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[4]/a");
        public By AboutUsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[5]/a");
        public By ContactsLink = By.XPath("/html/body/div[2]/div/header/div/div[1]/nav/ul/li[6]/a");
    }
}
