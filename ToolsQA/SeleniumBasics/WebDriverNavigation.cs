using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ToolsQA.SeleniumBasics
{
    class WebDriverNavigation
    {
        private string BaseQAUrl = "http://demoqa.com/";

        [Test, Category("Navigation")]        
        public void TestBasicNavigation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(BaseQAUrl);

            IWebElement menuItem = driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a"));
            menuItem.Click();

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            driver.Close();
        }


    }
}
