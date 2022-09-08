using DataDrivenHybridFramework.PageObjectLibrary;
using DataDrivenHybridFramework.TestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.TestCases
{
    [Parallelizable(ParallelScope.Self)]
    class SignUpTest :Base
    {
        [Test]
        [TestCaseSource("GetTestData")]
        //[TestCase ("stheri.jekew@gmail.com", "dkfakjsdklkas")]
        public void VerifySignUp(string fname, string lname)
        {
            //idriver.FindElement(By.Id("email")).SendKeys("Sreeni.Kapa@gmail.com");
            //idriver.FindElement(By.Id("pass")).SendKeys("sjdfjkhask");
            //idriver.FindElement(By.Name("login")).Click();
            FacebookLandingPage LandingPage = new FacebookLandingPage();
            LandingPage.SignUp(fname, lname);
            Thread.Sleep(5000);
            //Assert.AreEqual("Wrong credentials", LandingPage.GetWrongCredentialsTitle());
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(GetDataReader().getTestData("firstName"), GetDataReader().getTestData("lastName"));

        }
    }
}
