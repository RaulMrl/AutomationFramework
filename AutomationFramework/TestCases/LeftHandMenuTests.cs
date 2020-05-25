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
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.HomeElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("Registered users can sign-in"));
        }


        [Test]
        public void FlightsLink()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.FlightsElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("find a flight"));
        }


        [Test]
        public void HotelsLink()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.HotelsElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("find a hotel"));
        }


        [Test]
        public void CarRentalsLink()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.CarRentalsElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("rent a car"));
        }

        [Test]
        public void CruisesLink()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.CruisesElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("Cruise"));
        }

        [Test]
        public void Destinations()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.DestinationsElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("find your destinations"));
        }


        [Test]
        public void Vacations()
        {
            PageFactory.InitElements(LeftHandMenu.WebDriver, LeftHandMenu);
            LeftHandMenu.VacationsElement.Click();
            Assert.IsTrue(LeftHandMenu.WebDriver.FindElement(By.TagName("body")).Text.Contains("find your vacations"));
        }

        [TearDown]
        public void CleanUp()
        {
            LeftHandMenu.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}