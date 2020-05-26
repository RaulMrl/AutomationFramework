﻿using System;
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
    class RegisterTests
    {
        public RegisterPage RegisterPage;

        [SetUp]
        public void Initialize()
        {
            RegisterPage = new RegisterPage();
            RegisterPage.WebDriver = new ChromeDriver();
            RegisterPage.WebDriver.Url = "http://newtours.demoaut.com/mercuryregister.php";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void LogInWithValidData()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.UserName.SendKeys("UserNameTest");
            HomeScreen.Password.SendKeys("pass");
            HomeScreen.SignIn.Submit();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("Welcome UserNameTest"));
        }

        [Test]
        public void LogInWithInvalidData()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.UserName.SendKeys("invalid");
            HomeScreen.Password.SendKeys("invalid");
            HomeScreen.SignIn.Submit();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("User Name"));
        }


        [Test]
        public void LogInWithNoData()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.UserName.SendKeys("");
            HomeScreen.Password.SendKeys("");
            HomeScreen.SignIn.Submit();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("User Name"));
        }


        [Test]
        public void YourDestinationLink()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.YourDestination.Click();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("Destination"));
        }

        
        [Test]
        public void RegisterHereLink()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.RegisterHere.Click();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("account"));
        }


        [Test]
        public void BusinessTravelLink()
        {
            PageFactory.InitElements(HomeScreen.WebDriver, HomeScreen);
            HomeScreen.BusinessTravel.Click();
            Assert.IsTrue(HomeScreen.WebDriver.FindElement(By.TagName("body")).Text.Contains("Business"));
        }


        [TearDown]
        public void CleanUp()
        {
            HomeScreen.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}