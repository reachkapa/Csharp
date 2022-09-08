using DataDrivenHybridFramework.TestSetup;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.TestUtils
{
    public class BrowserActions:Base
    {
        public static void Type(By field,string value)
        {
            WaitUtil.WaitForElementToBeVisible(field);
            idriver.Value.FindElement(field).SendKeys(value);
        }

        public static void Click(By field)
        {
            WaitUtil.WaitForElementToBeClickable(field);
            idriver.Value.FindElement(field).Click();
        }

        public static string GetText(By field)
        {

            WaitUtil.WaitForElementToBeVisible(field);
            return idriver.Value.FindElement(field).Text;
        }
    }
}
