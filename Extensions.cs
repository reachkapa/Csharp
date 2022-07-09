using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    class Extensions
    {
        
        public static void ScrollToElement(IWebDriver idriver,IWebElement element)
        {
            var script1 = "arguments[0].scrollIntoView();";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)idriver;
            js1.ExecuteScript(script1, element);
        }
    }
}
