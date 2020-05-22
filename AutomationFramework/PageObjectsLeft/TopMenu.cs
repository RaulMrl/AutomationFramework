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
        public IWebElement SingOnElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement RegisterElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement SupportElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement Contact => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}