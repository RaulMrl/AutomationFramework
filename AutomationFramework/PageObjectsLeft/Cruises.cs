using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using AutomationFramework.PageObjectsLeft;

namespace AutomationFramework.PageObjects
{
    class Cruises : PageObject
    {
        public IWebElement CruisesElement => WebDriver.FindElement(By.LinkText("mercurycruise.php"));
    }
}
