using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class Footer
    {
        By PolicyLink = By.XPath("/html/body/div[2]/footer/div/div[1]/a");
        By FacebookLink = By.XPath("/html/body/div[2]/footer/div/ul/li[2]/a");
        By InstaLink = By.XPath("/html/body/div[2]/footer/div/ul/li[3]/a");
        By VkLink = By.XPath("/html/body/div[2]/footer/div/ul/li[4]/a");
        By YoutubeLink = By.XPath("/html/body/div[2]/footer/div/ul/li[5]/a");
        By LinkedLink = By.XPath("/html/body/div[2]/footer/div/ul/li[6]/a");
        By TwitterLnk = By.XPath("/html/body/div[2]/footer/div/ul/li[7]/a");
    }
}
