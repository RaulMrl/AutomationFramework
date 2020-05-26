using AutomationFramework.PageObjectsLeft;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    class LeftHandMenu : PageObject
    {
        public IWebElement HomeElement => WebDriver.FindElement(By.PartialLinkText("Home"));
        public IWebElement FlightsElement => WebDriver.FindElement(By.PartialLinkText("Flights"));
        public IWebElement HotelsElement => WebDriver.FindElement(By.PartialLinkText("Hotels"));
        public IWebElement CarRentalsElement => WebDriver.FindElement(By.PartialLinkText("Car Rentals"));
        public IWebElement CruisesElement => WebDriver.FindElement(By.PartialLinkText("Cruises"));
        public IWebElement DestinationsElement => WebDriver.FindElement(By.PartialLinkText("Destinations"));
        public IWebElement VacationsElement => WebDriver.FindElement(By.PartialLinkText("Vacations"));
        public IWebElement BodyElement => WebDriver.FindElement(By.TagName("body"));


        public void HomeLinkClick()
        {
            HomeElement.Click();
        }

        public void FlightsLinkClick()
        {
            FlightsElement.Click();
        }

        public void HotelsLinkClick()
        {
            HotelsElement.Click();
        }

        public void CarRentalsLinkClick()
        {
            CarRentalsElement.Click();
        }

        public void CruisesLinkClick()
        {
            CruisesElement.Click();
        }

        public void DestinationsLinkClick()
        {
            DestinationsElement.Click();
        }

        public void VacationsLinkClick()
        {
            VacationsElement.Click();
        }
    }
}