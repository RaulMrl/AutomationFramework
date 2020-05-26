using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class SignOnPage : PageObject
    {
        public IWebElement UserNameElement => WebDriver.FindElement(By.Name("userName"));
        public IWebElement PasswordElement => WebDriver.FindElement(By.Name("password"));
        public IWebElement SignInElement => WebDriver.FindElement(By.Name("login"));
        public IWebElement RegistrationFormElement => WebDriver.FindElement(By.PartialLinkText("registration"));
        public IWebElement BodyElement => WebDriver.FindElement(By.TagName("body"));

        public void LogIn(string userName, string password)
        {
            UserNameElement.SendKeys(userName);
            PasswordElement.SendKeys(password);
            SignInElement.Submit();
        }

        public void RegistrationFormLinkClick()
        {
            RegistrationFormElement.Click();
        }
    }
}
