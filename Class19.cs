using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Basics
{
    class Class19
    {
        //public static void Main(string[] args)
        //{

        //    //launch Chrome browser
        //    ChromeOptions options = new ChromeOptions();
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    IWebDriver idriver = new ChromeDriver(options);
        //    WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(60));
        //    idriver.Manage().Window.Maximize();
        //    //navigate to url
        //    //idriver.Navigate().GoToUrl("https://www.way2automation.com");
        //    //////i[@class = 'eicon-close']
        //    //var allcourse = w.Until(ExpectedConditions.ElementExists(By.XPath("(//span[text()='All Courses'])[1]")));
        //    //Actions action = new Actions(idriver);
        //    //action.MoveToElement(allcourse).Perform();
        //    //idriver.FindElement(By.XPath("(//span[text() = 'Lifetime Membership'])[1]")).Click();

        //    /////second exercise right click event
        //    //idriver.Navigate().GoToUrl("https://www.deluxe-menu.com/popup-mode-sample.html");

        //    //var image = idriver.FindElement(By.XPath("(//p//img)[2]"));
        //    //Actions action = new Actions(idriver);
        //    //action.ContextClick(image).Perform();
        //    //idriver.FindElement(By.XPath("//td[text()='Contact Us']")).Click();

        //    ///Third exercise double click event
        //    //idriver.Navigate().GoToUrl("https://www.demo.guru99.com/test/simple_context_menu.html");

        //    var doubleClick = idriver.FindElement(By.XPath("//button[text()='Double-Click Me To See Alert']"));
        //    Actions action = new Actions(idriver);
        //    action.DoubleClick(doubleClick).Perform();
            
        //}
    }
}
