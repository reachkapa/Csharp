using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Selenium_Basics
{
    class CabOps_Processing_Cabinet_Item
    {
        public static void CabOps(String itemNumber)
        {

            //launch Chrome browser
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver idriver = new ChromeDriver();

            try
            {
                //var watch = Stopwatch.StartNew();
                WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(30));
                idriver.Manage().Window.Maximize();
                //Navigate to https://portal.cloud9.cabnet
                idriver.Navigate().GoToUrl("https://portal.cloud9.cabnet");
                // Enter user id 
                idriver.FindElement(By.Id("userNameInput")).SendKeys(@"cloud9\pcab.ops1");
                // Enter password
                idriver.FindElement(By.Id("passwordInput")).SendKeys(@"Welcome01!");
                // Click on submit
                idriver.FindElement(By.Id("submitButton")).Click();
                //Click on Hamburger menu
                w.Until(ExpectedConditions.ElementExists(By.Name("aHamburger"))).Click();
                //Click on Cabinet Items
                w.Until(ExpectedConditions.ElementExists(By.Name("aCabinetItems"))).Click();
                //Search the Cabinet item
                Thread.Sleep(10000);
                w.Until(ExpectedConditions.ElementExists(By.Id("txtSearch"))).SendKeys(itemNumber);
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnSearchNow']"))).Click();
                w.Until(ExpectedConditions.ElementExists(By.XPath("//i[text()='keyboard_arrow_left']"))).Click();
                //var urlCabinetItem = idriver.FindElement(By.XPath("//app-search-results//child::a[@href]")).GetAttribute("href");
                //Console.WriteLine("item url-->"+urlCabinetItem);
                //idriver.Navigate().GoToUrl(urlCabinetItem);
                var cabinetItem = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//a[text()=' " + itemNumber + " '])[2]")));
                cabinetItem.Click();
                //Navigate to workspace
                var goToWorkspace = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='GO TO WORKSPACE']")));
                Extensions.ScrollToElement(idriver, goToWorkspace);
                goToWorkspace.Click();
                ////Manage Lock for Release*********
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnLockForRelease']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select All']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select all to validate']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnValidate"))).Click();
                w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='- VALIDATED']")));
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='LOCK FOR RELEASE']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnClose"))).Click();
                var btnManageRelease = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnManageRelease']")));
                Extensions.ScrollToElement(idriver, btnManageRelease);
                btnManageRelease.Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Cabinet Secretary')]"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Cabinet Division')]"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Authority')]"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']"))).Click();
                Thread.Sleep(1000);
                var CoOrd_Rlease = w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnRelease")));
                Extensions.ScrollToElement(idriver, CoOrd_Rlease);
                CoOrd_Rlease.Click();
                //Final Release
                ////Manage Lock for Release*********
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnLockForRelease']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select All']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select all to validate']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnValidate"))).Click();
                w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='- VALIDATED']")));
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='LOCK FOR RELEASE']"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnClose"))).Click();
                var final_btnManageRelease = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnManageRelease']")));
                Extensions.ScrollToElement(idriver, final_btnManageRelease);
                final_btnManageRelease.Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Cabinet Secretary')]"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Minister')]"))).Click();
                w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']"))).Click();
                Thread.Sleep(1000);
                var Final_Rlease = w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnRelease")));
                Extensions.ScrollToElement(idriver, Final_Rlease);
                Final_Rlease.Click();
                //watch.Stop();
                //var time = watch.ElapsedMilliseconds;
                //Console.WriteLine($"Time taken {time}");
            }
            catch
            {
                //idriver.Close();
            }
        }

    }
}
