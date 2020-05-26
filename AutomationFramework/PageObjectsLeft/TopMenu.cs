using AutomationFramework.PageObjectsLeft;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    class TopMenu : PageObject
    {
        public IWebElement SingOnElement => WebDriver.FindElement(By.PartialLinkText("SIGN-ON"));
        public IWebElement RegisterElement => WebDriver.FindElement(By.PartialLinkText("REGISTER"));
        public IWebElement SupportElement => WebDriver.FindElement(By.PartialLinkText("SUPPORT"));
        public IWebElement ContactElement => WebDriver.FindElement(By.PartialLinkText("CONTACT"));
        public IWebElement BodyElement => WebDriver.FindElement(By.TagName("body"));

        public void SignOnLinkClick()
        {
            SingOnElement.Click();
        }

        public void RegisterLinkClick()
        {
            RegisterElement.Click();
        }

        public void SupportLinkClick()
        {
            SupportElement.Click();
        }

        public void ContactLinkClick()
        {
            ContactElement.Click();
        }
    }
}