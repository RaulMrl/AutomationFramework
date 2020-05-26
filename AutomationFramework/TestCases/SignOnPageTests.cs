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
    class SignOnPageTests
    {
        public SignOnPage SignOnPage;

        [SetUp]
        public void Initialize()
        {
            SignOnPage = new SignOnPage();
            SignOnPage.WebDriver = new ChromeDriver();
            SignOnPage.WebDriver.Url = "http://newtours.demoaut.com/mercurysignon.php";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void RegistrationFormLink()
        {
            SignOnPage.RegistrationFormLinkClick();
            Assert.IsTrue(SignOnPage.BodyElement.Text.Contains("account"));
        }

        [Test]
        public void LogInWithValidData()
        {
            SignOnPage.LogIn("UserNameTest", "pass");
            Assert.IsTrue(SignOnPage.BodyElement.Text.Contains("Welcome UserNameTest"));
        }

        [Test]
        public void LogInWithInvalidData()
        {
            SignOnPage.LogIn("invalid", "invalid");
            Assert.IsTrue(SignOnPage.BodyElement.Text.Contains("User Name"));
        }


        [Test]
        public void LogInWithNoData()
        {
            SignOnPage.LogIn("", "");
            Assert.IsTrue(SignOnPage.BodyElement.Text.Contains("User Name"));
        }
        
        [TearDown]
        public void CleanUp()
        {
            SignOnPage.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}