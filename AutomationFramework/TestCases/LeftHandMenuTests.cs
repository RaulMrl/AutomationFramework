using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using AutomationFramework.PageObjectsLeft;
using AutomationFramework.Common;

namespace AutomationFramework.TestCases
{    
    class LeftHandMenuTests
    {
        public LeftHandMenu LeftHandMenu;

        [SetUp]
        public void Initialize()
        {
            LeftHandMenu = new LeftHandMenu();
            LeftHandMenu.WebDriver = new ChromeDriver();
            LeftHandMenu.WebDriver.Url = "http://newtours.demoaut.com/";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void HomeLink()
        {
            LeftHandMenu.HomeLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("Registered users can sign-in"));
        }


        [Test]
        public void FlightsLink()
        {
            LeftHandMenu.FlightsLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("find a flight"));
        }


        [Test]
        public void HotelsLink()
        {
            LeftHandMenu.HotelsLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("find a hotel"));
        }


        [Test]
        public void CarRentalsLink()
        {
            LeftHandMenu.CarRentalsLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("rent a car"));
        }

        [Test]
        public void CruisesLink()
        {
            LeftHandMenu.CruisesLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("Cruise"));
        }

        [Test]
        public void DestinationsLink()
        {
            LeftHandMenu.DestinationsLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("find your destinations"));
        }


        [Test]
        public void VacationsLink()
        {
            LeftHandMenu.VacationsLinkClick();
            Assert.IsTrue(LeftHandMenu.BodyElement.Text.Contains("find your vacations"));
        }

        [TearDown]
        public void CleanUp()
        {
            LeftHandMenu.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}