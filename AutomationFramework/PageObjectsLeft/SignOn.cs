using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class SignOn : PageObject
    {
        public IWebElement SingOnElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}
