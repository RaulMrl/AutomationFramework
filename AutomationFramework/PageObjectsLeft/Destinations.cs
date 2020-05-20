using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    class Destinations
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercuryunderconst.php")]
        public IWebElement DestinationsElement { get; set; }
    }
}
