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
    class DriverCommands2
    {
        [Test]
        public void TestXpathFindAndClick()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            driver.Close();
        }
    }
}
