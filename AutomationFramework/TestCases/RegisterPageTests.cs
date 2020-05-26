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
    class RegisterPageTests
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
            RegisterPage.Register("FirstNameTest",
                                  "LastNameTest",
                                  "1234567891",
                                  "test.test@test.com",
                                  "AddressTestLine1",
                                  "AddressTestLine2",
                                  "CityTest",
                                  "StateTest",
                                  "123456",
                                  "UNITED STATES",
                                  "UserNameTest",
                                  "pass",
                                  "pass");
            Assert.IsTrue(RegisterPage.BodyElement.Text.Contains("Thank you for registering"));
        }

        [Test]
        public void LogInWithInvalidData()
        {
            RegisterPage.Register("invalid",
                                  "invalid",
                                  "1",
                                  "asd",
                                  "invalid",
                                  "invalid",
                                  "invalid",
                                  "invalid",
                                  "1",
                                  "UNITED STATES",
                                  "invalid",
                                  "i",
                                  "i");
            Assert.IsTrue(RegisterPage.BodyElement.Text.Contains("Invalid"));
        }


        [Test]
        public void LogInWithNoData()
        {
            RegisterPage.Register("","","","","","","","","","","","","");
            Assert.IsTrue(RegisterPage.BodyElement.Text.Contains("Invalid"));
        }

        [TearDown]
        public void CleanUp()
        {
            RegisterPage.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}