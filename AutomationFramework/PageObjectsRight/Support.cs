using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.PageObjectsRight
{
    class Support
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercurywelcome.php")]
        public IWebElement SupportElement { get; set; }
    }
}
