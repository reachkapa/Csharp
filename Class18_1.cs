using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    class Class18_1
    {

        static void Main(String[] args)
        {
            //launch Chrome browser
            ChromeOptions options = new ChromeOptions();
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver idriver = new ChromeDriver(options);
            //implicit wait
            idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Explicit Wait
            //WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(60));
            idriver.Manage().Window.Maximize();
            //navigate to url
            idriver.Navigate().GoToUrl("https://jqueryui.com/datepicker/");
            IWebElement datepickerframe = idriver.FindElement(By.CssSelector(".demo-frame"));
            idriver.SwitchTo().Frame(datepickerframe);
            idriver.FindElement(By.Id("datepicker")).Click();
            idriver.FindElement(By.XPath("//a[text()='29']")).Click();
            //a[@data-handler = 'prev']
            //a[@data-handler = 'next']
            //span[@class = 'ui-datepicker-year']
            //span[@class = 'ui-datepicker-month']
        }




    }
}

