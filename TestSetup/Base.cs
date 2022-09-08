using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using DataDrivenHybridFramework.TestUtils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Interfaces;

namespace DataDrivenHybridFramework.TestSetup
{
    public class Base
    {
        //public static IWebDriver idriver;
        //This is for parallel execution of test cases
        public static ThreadLocal<IWebDriver> idriver = new ThreadLocal<IWebDriver>();
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void TestSuiteSetup()
        {
            //string WorkingDirectory = Environment.CurrentDirectory;//Get path of Base.cs
            //string projectDirectory = Directory.NUnit.Framework.Interfaces(WorkingDirectory).Parent.Parent.FullName;
            string reportPath = "C:/Users/CLD16766/source/repos/ConsoleApp1/DataDrivenHybridFramework/index.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local Host");
            extent.AddSystemInfo("Envrionment", "QA");
            extent.AddSystemInfo("Username", "SreeniKapa");

        }

        public void OnetimeSetup()//mainly for configuration purpose
        {
            Console.WriteLine("One time test setup has been executed");
        }


        [SetUp]
        public void Setup()
        {
            //Get the test case name for the current context
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            string browserName = ConfigurationManager.AppSettings["browser"];
            this.InitBrowser(browserName);
            //implicit wait
            idriver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT);
            idriver.Value.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
            Console.WriteLine();
            Console.WriteLine("Setup will execute before each time a test is executed");
        }

        [TearDown]
        public void Teardown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            if(status == TestStatus.Failed)
            {
                test.Fail("Test Case Failed");
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass("Test case Passed");
            }
            //extent.Flush();
            Console.WriteLine("TearDown will execute after for each test is executed");
            if (idriver.Value != null)
            {
                idriver.Value.Close();
            }
        }
        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            extent.Flush();
            Console.WriteLine("One time teardown has been executed");
        }

        public void InitBrowser(string BrowserName)
        {
            switch (BrowserName.ToLower())
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    idriver.Value = new ChromeDriver(options);
                    idriver.Value.Manage().Window.Maximize();
                    break;
                case "edge":
                    idriver.Value = new EdgeDriver();
                  //var eo = new EdgeOptions();
                    //eo.BinaryLocation= @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                    //eo.AddArgument("headless");
                    //idriver = new EdgeDriver(eo);
                    idriver.Value.Manage().Window.Maximize();
                    break;
                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    idriver.Value = new FirefoxDriver();
                    idriver.Value.Manage().Window.Maximize();
                    break;
                default:
                    ChromeOptions options1 = new ChromeOptions();
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    idriver.Value = new ChromeDriver(options1);
                    idriver.Value.Manage().Window.Maximize();
                    break;
            }
            
        }
        public static JsonReader GetDataReader()
        {
            return new JsonReader();
        }

    }
}