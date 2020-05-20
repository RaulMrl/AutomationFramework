using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.PageObjects
{
    class Cruises
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercurycruise.php")]
        public IWebElement CruisesElement { get; set; }
    }
}
