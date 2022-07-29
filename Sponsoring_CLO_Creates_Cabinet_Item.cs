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
    class Sponsoring_CLO_Create_Cabinet_Item
    {
        //static void Main(string[] args)
        //{

        //    //launch Chrome browser
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    IWebDriver idriver = new ChromeDriver();

        //    try
        //    {
        //        var watch = Stopwatch.StartNew();
        //        WebDriverWait w = new WebDriverWait(idriver, TimeSpan.FromSeconds(30));
        //        idriver.Manage().Window.Maximize();
        //        //Navigate to https://portal.cloud9.cabnet
        //        idriver.Navigate().GoToUrl("https://portal.cloud9.cabnet");
        //        // Enter user id 
        //        idriver.FindElement(By.Id("userNameInput")).SendKeys(@"cloud9\pclo1.finance");
        //        // Enter password
        //        idriver.FindElement(By.Id("passwordInput")).SendKeys(@"Welcome01!");
        //        // Click on submit
        //        idriver.FindElement(By.Id("submitButton")).Click();
        //        //Click on Hamburger menu
        //        w.Until(ExpectedConditions.ElementExists(By.Name("aHamburger"))).Click();
        //        //Click on Cabinet Items
        //        w.Until(ExpectedConditions.ElementExists(By.Name("aCabinetItems"))).Click();
        //        //Click on Create a new Cabinet item
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='create a new cabinet item']"))).Click();
        //        //Select Product Type
        //        idriver.FindElement(By.Name("cabinetProductTypeId")).Click();
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//li[@aria-label='Cabinet Submission']"))).Click();
        //        //Select the Sponsoring Minister
        //        idriver.FindElement(By.Name("sponsoringMinisterId")).Click();
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Katy Gallagher']"))).Click();
        //        //Select the Sponsoring Ministerial Title
        //        idriver.FindElement(By.Name("sponsoringMinisterialTitleId")).Click();
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//li[@aria-label='Minister for Finance']"))).Click();
        //        //Enter Protected Title
        //        idriver.FindElement(By.Id("name")).SendKeys(" Protected Title for Cabinet Item of type " + idriver.FindElement(By.Name("cabinetProductTypeId")).Text + " for " + idriver.FindElement(By.Name("sponsoringMinisterialTitleId")).Text + " '" + idriver.FindElement(By.Name("sponsoringMinisterId")).Text + "' created on " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        //        //Select meeting type
        //        var meetingType = idriver.FindElement(By.XPath("//app-dropdown-chip[@name='meetingTypeId']"));
        //        //Scroll the page
        //        Extensions.ScrollToElement(idriver, meetingType);
        //        meetingType.Click();
        //        //Set Meeting Type
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//li[@aria-label='Cabinet']"))).Click();
        //        //Expected Consideration Date
        //        idriver.FindElement(By.Name("expectedConsiderationTimePeriodType")).Click();
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//li[@aria-label='Date']"))).Click();
        //        //select Random Meeting date
        //        idriver.FindElement(By.XPath("//p-dropdown[@name='expectedConsiderationId']")).Click();
        //        ReadOnlyCollection<IWebElement> expectedConsiderationDates = w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//span[@class='ng-star-inserted']")));
        //        //w.Until(ExpectedConditions.ElementExists(By.XPath("//li[@aria-label = '20/07/2022']"))).Click();
        //        //ReadOnlyCollection<IWebElement> expectedConsiderationDates = idriver.FindElements(By.XPath("//span[@class='ng-star-inserted']"));
        //        //Try to get a random Date
        //        Extensions ext = new Extensions();
        //        int index = ext.GetRandom(expectedConsiderationDates.Count);
        //        //Console.WriteLine("Random consideration date: " + index);
        //        expectedConsiderationDates.ElementAt(index).Click();
        //        //Input the purpose
        //        var purpose = idriver.FindElement(By.Id("txtPurpose"));
        //        Extensions.ScrollToElement(idriver, purpose);
        //        idriver.FindElement(By.Id("txtPurpose")).SendKeys("Purpose for - Cabinet Item of type " + idriver.FindElement(By.Name("cabinetProductTypeId")).Text + " for " + idriver.FindElement(By.Name("sponsoringMinisterialTitleId")).Text + " '" + idriver.FindElement(By.Name("sponsoringMinisterId")).Text + "' created on " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        //        //Select Contact Officer(s)
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnSelectContactMain"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='users']"))).SendKeys("pcontact1.finance");
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[text() = ' pcontact1.Finance@cloud9.cabnet ']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='SET']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']"))).Click();
        //        //Create Cabinet Item
        //        IWebElement createCabinetItem = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Create Cabinet Item']")));
        //        Extensions.ScrollToElement(idriver, createCabinetItem);
        //        createCabinetItem.Click();
        //        ////***************************************************************************////
        //        ///////////////////Cabinet Item Summary Page//////////////////////////////////////
        //        var cnRefNum = w.Until(ExpectedConditions.ElementExists(By.Id("cnReferenceNumber"))).Text;
        //        Console.WriteLine("CN Reference Number->" + cnRefNum);
        //        //Close Alert Window
        //        idriver.FindElement(By.XPath("//button[@icon='pi pi-times text-xl']")).Click();
        //        //Create a New Product
        //        var createNewProduct = idriver.FindElement(By.XPath("//span[text()='Create a New Product']"));
        //        Extensions.ScrollToElement(idriver, createNewProduct);
        //        createNewProduct.Click();
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("(//span[text()='Create Product'])[2]"))).Click();
        //        //Manage Release page
        //        var manageLockForRelease = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Manage Lock for release']")));
        //        Extensions.ScrollToElement(idriver, manageLockForRelease);
        //        manageLockForRelease.Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select All']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select all to validate']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnValidate"))).Click();
        //        w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='- VALIDATED']")));
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='LOCK FOR RELEASE']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnClose"))).Click();
        //        //Release Check List
        //        w.Until(ExpectedConditions.ElementExists(By.XPath("//label [text()='Sponsoring Department  - Department of Finance Approved - [Required] ']"))).Click();
        //        var btnSave = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']")));
        //        Extensions.ScrollToElement(idriver, btnSave);
        //        btnSave.Click();
        //        //Manage Release
        //        var btnManageRelease = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnManageRelease']")));
        //        Extensions.ScrollToElement(idriver, btnManageRelease);
        //        btnManageRelease.Click();
        //        //Pre-ED Release Page
        //        var datePicker = w.Until(ExpectedConditions.ElementExists(By.XPath("//button[@tabindex = '0']")));
        //        Extensions.ScrollToElement(idriver, datePicker);
        //        datePicker.Click();
        //        w.Until(ExpectedConditions.ElementExists(By.Id("calendar_control"))).SendKeys(DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"));
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnRelease"))).Click();
        //        //ED Release
        //        //Manage Lock for Release
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnLockForRelease']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select All']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Select all to validate']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnValidate"))).Click();
        //        w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='- VALIDATED']")));
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='LOCK FOR RELEASE']"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnClose"))).Click();
        //        //Check box selection
        //        //Thread.Sleep(2000);
        //        ////w.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(@class,'pi pi-lock')][1]")));
        //        //w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[contains(text(),'Sponsoring Department  ')]")));
        //        //IWebElement Ed_sponsorCheckbox = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Department  ')]")));
        //        //Extensions.ScrollToElement(idriver, Ed_sponsorCheckbox);
        //        //Ed_sponsorCheckbox.Click();
        //        //IWebElement Ed_sponsorApproval = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Minister  ')]")));
        //        //Extensions.ScrollToElement(idriver, Ed_sponsorApproval);
        //        //Ed_sponsorApproval.Click();
        //        //var Ed_btnSave = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']")));
        //        //Extensions.ScrollToElement(idriver, Ed_btnSave);
        //        //Ed_btnSave.Click();
        //        //Manage Release
        //        var Ed_btnManageRelease = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnManageRelease']")));
        //        Extensions.ScrollToElement(idriver, Ed_btnManageRelease);
        //        Ed_btnManageRelease.Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Department')]"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Minister')]"))).Click();
        //        w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']"))).Click();
        //        Thread.Sleep(1000);
        //        var Ed_Rlease = w.Until(ExpectedConditions.ElementToBeClickable(By.Id("btnRelease")));
        //        Extensions.ScrollToElement(idriver, Ed_Rlease);
        //        Ed_Rlease.Click();
        //        //Co-Ord Release
        //        Thread.Sleep(2000);
        //        //w.Until(ExpectedConditions.ElementExists(By.XPath("//span[contains(@class,'pi pi-lock')][1]")));
        //        w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//label[contains(text(),'Sponsoring Department  ')]")));
        //        IWebElement Co_sponsorCheckbox = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Department  ')]")));
        //        Extensions.ScrollToElement(idriver, Co_sponsorCheckbox);
        //        Co_sponsorCheckbox.Click();
        //        IWebElement Co_sponsorApproval = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//label[contains(text(),'Sponsoring Minister  ')]")));
        //        Extensions.ScrollToElement(idriver, Co_sponsorApproval);
        //        Co_sponsorApproval.Click();
        //        var Co_btnSave = w.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Save']")));
        //        Extensions.ScrollToElement(idriver, Co_btnSave);
        //        Co_btnSave.Click();
        //        var pmRefNum = w.Until(ExpectedConditions.ElementIsVisible(By.Id("pmReferenceNumber"))).Text;
        //        Console.WriteLine(pmRefNum);
        //        //Signout
        //        w.Until(ExpectedConditions.ElementExists(By.Name("aHamburger"))).Click();
        //        w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a [text() = 'Sign Out']"))).Click();
        //        w.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='yes, sign out']"))).Click();
        //        idriver.Close();
        //        CabOps_Processing_Cabinet_Item.CabOps(pmRefNum);
        //        watch.Stop();
        //        var time = watch.ElapsedMilliseconds;
        //        Console.WriteLine($"Time taken {time}");
        //    }
        //    catch
        //    {
        //        //idriver.Close();
        //    }
        //}

    }
}
