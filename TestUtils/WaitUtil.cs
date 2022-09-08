using DataDrivenHybridFramework.TestSetup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.TestUtils
{
    class WaitUtil:Base
    {
        public static WebDriverWait wait;

        public static void WaitForElementToBeVisible(By field)
        {
            //Explicit Wait
            wait = new WebDriverWait(idriver.Value, TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT));
            wait.Until(ExpectedConditions.ElementIsVisible(field));

        }

        public static void WaitForElementToBeClickable(By field)
        {
            //Explicit Wait
            wait = new WebDriverWait(idriver.Value, TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT));
            wait.Until(ExpectedConditions.ElementToBeClickable(field));

        }

        public static void WaitForElementToBePresent(By field)
        {
            //Explicit Wait
            wait = new WebDriverWait(idriver.Value, TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT));
            wait.Until(ExpectedConditions.ElementExists(field));

        }

    }
}
