using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class Header
    {
        By LogoLink = By.XPath("/html/body/div[2]/div/header/div/a");
        By CurrentLanguage = By.XPath("/html/body/div[2]/div/header/div/div[1]/ul/li");
        By FloatButton = By.Name("entry");
    }
}
