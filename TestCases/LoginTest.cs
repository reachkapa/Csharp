using DataDrivenHybridFramework.PageObjectLibrary;
using DataDrivenHybridFramework.TestSetup;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.TestCases
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class LoginTest:Base

    {
        [Test]
        [TestCaseSource("GetTestData")]
        //[TestCase ("stheri.jekew@gmail.com", "dkfakjsdklkas")]
        public void VerifyLoginWithInvalidCredentials(string email, string password)
        {
            //idriver.FindElement(By.Id("email")).SendKeys("Sreeni.Kapa@gmail.com");
            //idriver.FindElement(By.Id("pass")).SendKeys("sjdfjkhask");
            //idriver.FindElement(By.Name("login")).Click();
            FacebookLandingPage LandingPage = new FacebookLandingPage();
            LandingPage.Login(email, password);
            Assert.AreEqual("Wrong credentials", LandingPage.GetWrongCredentialsTitle());
        }

        [Test]
        [TestCaseSource("GetTestData1")]
        //[TestCase("reachkapa@yahoo.com", "Rishik0510")]
        public void VerifyLoginWithValidCredentials(string email, string password)
        {
            FacebookLandingPage LandingPage = new FacebookLandingPage();
            LandingPage.Login(email, password);
            Assert.AreEqual("Sreenivas Kapa", LandingPage.GetUserTitle());
        }
        //return multiple returns to get test case data
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(GetDataReader().getTestData("validEmail"), GetDataReader().getTestData("invalidPassword"));
            yield return new TestCaseData("reachkapa@yahoo.com", "skldjlaksjl");
        }
        public static IEnumerable<TestCaseData> GetTestData1()
        {
            yield return new TestCaseData(GetDataReader().getTestData("validEmail"), GetDataReader().getTestData("validPassword"));

        }
    }
}

