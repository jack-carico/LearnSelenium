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
    class DriverCommands
    {
        [Test]
        public void TestGeneralIWebDriverMethods()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://www.demoqa.com";

            string title = driver.Title;
            int titleLength = driver.Title.Length;

            Console.WriteLine("Page Title: " + title);
            Console.WriteLine("Page Title Length: " + titleLength);

            string pageUrl = driver.Url;
            int pageUrlLength = driver.Url.Length;

            Console.WriteLine("Page URL: " + pageUrl);
            Console.WriteLine("Page URL Length: " + pageUrlLength);

            string pageSource = driver.PageSource;
            Console.WriteLine("Page Source: " + pageSource);

            driver.Quit();


        }
    }
}
