using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class Contact : PageObject
    {
        public IWebElement ContactElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}
