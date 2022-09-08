using DataDrivenHybridFramework.TestSetup;
using DataDrivenHybridFramework.TestUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenHybridFramework.PageObjectLibrary
{
    public class FacebookLandingPage :Base
    {
        By Email = By.Id("email");
        By Password = By.Id("pass");
        By LoginButton = By.Name("login");
        By ForgottenPassword = By.XPath("//a[text()='Forgotten password?']");
        By CreateNewAccount = By.XPath("//a[text()='Create New Account']");
        By LoginSuccessText = By.XPath("//span[text() = 'Sreenivas Kapa']");
        By WrongCredentials = By.XPath("//div[text()='Wrong credentials']");
        By TempBlocked = By.XPath(@"(//h2[text()='You’re Temporarily Blocked'])[1]");
        By FirstName = By.Name("firstname");
        By LastName = By.Name("lastname");


        public void Login(string email,string pass)
        {
            BrowserActions.Type(Email, email);
            BrowserActions.Type(Password, pass);
            BrowserActions.Click(LoginButton);

        }

        public string GetUserTitle()
        {
            return BrowserActions.GetText(LoginSuccessText);
                
        }

        public string GetWrongCredentialsTitle()
        {
            return BrowserActions.GetText(WrongCredentials);

        }

        public string GetTempBlockedTitle()
        {
            return BrowserActions.GetText(TempBlocked);

        }

        public void SignUp(string firstname, string lastname)
        {
            BrowserActions.Click(CreateNewAccount);
            BrowserActions.Type(FirstName, firstname);
            BrowserActions.Type(LastName, lastname);
        }
    }
}
