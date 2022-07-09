using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_Basics
{
    class _09062022_Assignment3
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
        //    idriver.Navigate().GoToUrl("https://www.orangehrm.com");
        //    Thread.Sleep(2000);
        //    w.Until(ExpectedConditions.ElementExists(By.XPath("//a[@title = 'Accept Cookies']"))).Click();
        //    w.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()='Contact Sales']"))).Click();
        //    //Fill the Contact form
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_FullName"))).SendKeys("Sreenivasulu Kapa");
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_CompanyName"))).SendKeys("Kapa Consulting Services");
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_JobTitle"))).SendKeys("Director");
        //    //selecting elemnts from list box(options)
        //    var NoOfEmployees = w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_NoOfEmployees")));
        //    var selectElement = new SelectElement(NoOfEmployees);
        //    selectElement.SelectByValue("11 - 15");
        //    //Select the values from the dropdown(ul>li)
        //    w.Until(ExpectedConditions.ElementExists(By.ClassName("iti__selected-flag"))).Click();
        //    var country = w.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Australia']")));
        //    country.Click();
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_Contact"))).SendKeys("421340904");
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_Email"))).SendKeys("Sreeni@test.com");
        //    w.Until(ExpectedConditions.ElementExists(By.Id("Form_submitForm_Comment"))).SendKeys("Sample Test");
        //}
    }
}