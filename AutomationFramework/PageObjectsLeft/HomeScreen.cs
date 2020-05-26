﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class HomeScreen : PageObject
    {
        public IWebElement UserName => WebDriver.FindElement(By.Name("userName"));
        public IWebElement Password => WebDriver.FindElement(By.Name("password"));
        public IWebElement SignIn => WebDriver.FindElement(By.Name("login"));
        public IWebElement YourDestination => WebDriver.FindElement(By.PartialLinkText("your destination"));
        public IWebElement FeaturedVacationDestinations => WebDriver.FindElement(By.PartialLinkText("featured vacation destinations"));
        public IWebElement RegisterHere => WebDriver.FindElement(By.PartialLinkText("Register here"));
        public IWebElement BusinessTravel => WebDriver.FindElement(By.PartialLinkText("Business Travel"));
        public IWebElement BodyElement => WebDriver.FindElement(By.TagName("body"));

        public void LogIn(string userName, string password)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(password);
            SignIn.Submit();
        }

        public void YourDestinationLinkClick()
        {
            YourDestination.Click();
        }

        public void RegisterHereLinkClick()
        {
            RegisterHere.Click();
        }

        public void BusinessTravelLinkClick()
        {
            BusinessTravel.Click();
        }
    }
}
