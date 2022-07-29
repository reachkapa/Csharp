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
    class Class18
    {

        //static void Main(String[] args)
        //{
        //    //launch Chrome browser
        //    ChromeOptions options = new ChromeOptions();
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    IWebDriver idriver = new ChromeDriver(options);
        //    //implicit wait
        //    //idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        //    //Explicit Wait
        //    WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(60));
        //    idriver.Manage().Window.Maximize();
        //    //navigate to url
        //    idriver.Navigate().GoToUrl("https://www.facebook.com");
        //    w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text() = 'Create New Account']"))).Click();
        //    var selectDay = w.Until(ExpectedConditions.ElementExists(By.XPath("//select[@id='day']")));
        //    var selectElement = new SelectElement(selectDay);
        //    selectElement.SelectByValue("20");

        //    var selectMonth = w.Until(ExpectedConditions.ElementExists(By.XPath("//select[@id='month']")));
        //    var selectElement1 = new SelectElement(selectMonth);
        //    selectElement1.SelectByText("Aug");

        //    var selectYear = w.Until(ExpectedConditions.ElementExists(By.XPath("//select[@id='year']")));
        //    var selectElement2 = new SelectElement(selectYear);
        //    selectElement2.SelectByText("2012");




        //}
    }
}
