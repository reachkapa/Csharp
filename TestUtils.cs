using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    class TestUtils
    {

        public static void SelectFromDropdown(IWebDriver idriver, string elementName)
        {
            WebDriverWait wait = new WebDriverWait(idriver, TimeSpan.FromSeconds(30));
            idriver.FindElement(By.Name(elementName)).Click();
            IReadOnlyCollection<IWebElement> itemTypes = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//li [contains(@class,'p-ripple p-element p-dropdown-item')]")));
            int Itemtype = Extensions.GetRandom(itemTypes.Count);
            itemTypes.ElementAt(Itemtype).Click();
        }

        public static void TandCs(IWebDriver idriver)
        {
            WebDriverWait wait = new WebDriverWait(idriver, TimeSpan.FromSeconds(30));
            var tAndCs = idriver.FindElements(By.XPath("//div [@class = 'p-checkbox-box']")).ToList();
            if (tAndCs.Count > 0)
            {
                foreach (IWebElement tcCheckbox in tAndCs)
                {
                    Extensions.ScrollToElement(idriver, tcCheckbox);
                    tcCheckbox.Click();
                }

                var tcAccept = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span [text() = 'Accept']")));
                Extensions.ScrollToElement(idriver, tcAccept);
                tcAccept.Click();
            }
        }
    }
}
