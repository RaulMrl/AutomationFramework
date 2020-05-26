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
    class TopMenuTests
    {
        public TopMenu TopMenu;

        [SetUp]
        public void Initialize()
        {
            TopMenu = new TopMenu();
            TopMenu.WebDriver = new ChromeDriver();
            TopMenu.WebDriver.Url = "http://newtours.demoaut.com/";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void SignOnLink()
        {
            TopMenu.SignOnLinkClick();
            Assert.IsTrue(TopMenu.BodyElement.Text.Contains("User Name"));
        }


        [Test]
        public void RegisterLink()
        {
            TopMenu.RegisterLinkClick();
            Assert.IsTrue(TopMenu.BodyElement.Text.Contains("First Name"));
        }


        [Test]
        public void SupportLink()
        {
            TopMenu.SupportLinkClick();
            Assert.IsTrue(TopMenu.BodyElement.Text.Contains("Support"));
        }


        [Test]
        public void ContactLink()
        {
            TopMenu.ContactLinkClick();
            Assert.IsTrue(TopMenu.BodyElement.Text.Contains("Contact"));
        }


        [TearDown]
        public void CleanUp()
        {
            TopMenu.WebDriver.Quit();
            Console.WriteLine("Closed the browser");
        }
    }
}