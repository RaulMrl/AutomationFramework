using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class HomeScreen : PageObject
    {
        public IWebElement UserName => WebDriver.FindElement(By.Name("userName"));
        public IWebElement Password => WebDriver.FindElement(By.Name("password"));
        public IWebElement SignIn => WebDriver.FindElement(By.Name("login"));
        public IWebElement YourDestination => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement FeaturedVacationDestinations => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement RegisterHere => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement BusinessTravel => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}
