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

        [TearDown]
        public void CleanUp()
        {
            HomeScreen.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}