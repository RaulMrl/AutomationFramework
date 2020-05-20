using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.PageObjectsLeft;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.PageObjects
{
    class Home : PageObject
    {
        public IWebElement HomeElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}
