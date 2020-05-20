using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsRight
{
    class Register
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "mercurywelcome.php")]
        public IWebElement RegisterElement { get; set; }
    }
}
