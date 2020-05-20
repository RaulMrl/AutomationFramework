using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class Register : PageObject
    {
        public IWebElement RegisterElement => WebDriver.FindElement(By.LinkText("mercurywelcome.php"));
    }
}
