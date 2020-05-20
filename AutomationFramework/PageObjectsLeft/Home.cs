using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.PageObjects
{
    class Home
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercurywelcome.php")]
        public IWebElement HomeElement { get; set; }
    }
}
