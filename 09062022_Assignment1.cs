using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Basics
{
    class _09062022_Assignment1
    {
        //public static void Main(string[] args)
        //{

        //    //launch Chrome browser
        //    ChromeOptions options = new ChromeOptions();
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    IWebDriver idriver = new ChromeDriver(options);
        //    WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(30));
        //    idriver.Manage().Window.Maximize();
        //    idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    //navigate to url
        //    idriver.Navigate().GoToUrl("https://www.Google.com");
        //    //idriver.SwitchTo().Frame(frame - id);
        //    idriver.SwitchTo().Frame("callout");
        //    idriver.FindElement(By.XPath("//button[text()='No thanks']")).Click();
        //    idriver.SwitchTo().ParentFrame();
        //    idriver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Way2automation");
        //    w.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Way2Automation']"))).Click();
        //    //ReadOnlyCollection<IWebElement> search_results = idriver.FindElements(By.XPath("//span"));

        //    //try
        //    //{
        //    //    foreach (IWebElement elem in search_results)
        //    //    {

        //    //        if (elem.Text.Equals("Way2Automation"))
        //    //        {
        //    //            elem.Click();
        //    //        }
        //    //    }
        //    //}
        //    //catch
        //    //{

        //    //}

        //}
    }
}
