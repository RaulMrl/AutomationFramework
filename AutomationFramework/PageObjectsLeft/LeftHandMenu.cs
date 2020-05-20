using AutomationFramework.PageObjectsLeft;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    class LeftHandMenu : PageObject
    {
        public IWebElement Home => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
        public IWebElement Flights => WebDriver.FindElement(By.LinkText("mercuryreservation.php"));
        public IWebElement Hotels => WebDriver.FindElement(By.LinkText("mercuryunderconst.php"));
        public IWebElement CarRentals => WebDriver.FindElement(By.LinkText("mercuryunderconst.php"));
        public IWebElement Cruises => WebDriver.FindElement(By.LinkText("mercurycruise.php"));
        public IWebElement Destinations => WebDriver.FindElement(By.LinkText("mercuryunderconst.php"));
        public IWebElement VacationsElement => WebDriver.FindElement(By.LinkText("mercuryunderconst.php"));
    }
}