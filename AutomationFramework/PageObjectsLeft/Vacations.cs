using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    class Vacations
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercuryunderconst.php")]
        public IWebElement VacationsElement { get; set; }
    }
}
