using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class SocialExpectedText
    {        
        public By ExPolicyLink = By.XPath("/html/body/div[2]/main/div/div/h1");
        public By ExFacebookLink = By.CssSelector("#u_0_0 > span._33vv > a > span");
        public By ExInstaLink = By.XPath("/html/body/div[2]/footer/div/ul/li[3]/a");
        public By ExVkLink = By.XPath("/html/body/div[2]/footer/div/ul/li[4]/a");
        public By ExYoutubeLink = By.XPath("/html/body/div[2]/footer/div/ul/li[5]/a");
        public By ExLinkedLink = By.XPath("/html/body/div[2]/footer/div/ul/li[6]/a");
        public By ExTwitterLnk = By.XPath("/html/body/div[2]/footer/div/ul/li[7]/a");
    }
}