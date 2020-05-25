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
    }
}