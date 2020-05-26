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
    class HomeScreenTests
    {
        public HomeScreen HomeScreen;

        [SetUp]
        public void Initialize()
        {
            HomeScreen = new HomeScreen();
            HomeScreen.WebDriver = new ChromeDriver();
            HomeScreen.WebDriver.Url = "http://newtours.demoaut.com/";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void LogInWithValidData()
        {
            HomeScreen.LogIn("UserNameTest", "pass");
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("Welcome UserNameTest"));
        }

        [Test]
        public void LogInWithInvalidData()
        {
            HomeScreen.LogIn("invalid", "invalid");
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("User Name"));
        }


        [Test]
        public void LogInWithNoData()
        {
            HomeScreen.LogIn("", "");
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("User Name"));
        }


        [Test]
        public void YourDestinationLink()
        {
            HomeScreen.YourDestinationLinkClick();
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("Select Destination"));
        }

        
        [Test]
        public void RegisterHereLink()
        {
            HomeScreen.RegisterHereLinkClick();
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("account"));
        }


        [Test]
        public void BusinessTravelLink()
        {
            HomeScreen.BusinessTravelLinkClick();
            Assert.IsTrue(HomeScreen.BodyElement.Text.Contains("Business"));
        }


        [TearDown]
        public void CleanUp()
        {
            HomeScreen.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}