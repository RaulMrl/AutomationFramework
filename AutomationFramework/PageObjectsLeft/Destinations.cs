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
    class Destinations : PageObject
    {
        public IWebElement DestinationsElement => WebDriver.FindElement(By.LinkText("mercuryunderconst.php"));
    }
}
