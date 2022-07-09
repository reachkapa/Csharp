using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Basics
{
    class FindElementAndElements
    {
        //public static void Main(string[] args)
        //{

        //    //launch Chrome browser
        //    ChromeOptions options = new ChromeOptions();
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    IWebDriver idriver = new ChromeDriver(options);
        //    idriver.Manage().Window.Maximize();
        //    //navigate to url
        //    idriver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_page");
        //    ReadOnlyCollection<IWebElement> links = idriver.FindElements(By.XPath("//a"));

            
        //    foreach(IWebElement elem in links)
        //    {
        //        Console.WriteLine("Text of the link first appears in the webPage-->" + elem.Text);
        //    }
        //}
    }
}
