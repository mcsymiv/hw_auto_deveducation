﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DevEducation
{
    public class BlogPage
    {
        IWebDriver driver;
        public BlogPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By PageTitle = By.XPath("/html/body/div[2]/main/div/div/div[1]/div/h1");
        public string GetBlogPageTitle(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
