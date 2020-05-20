using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    class Flights
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercuryreservation.php")]
        public IWebElement FlightsElement { get; set; }
    }
}
