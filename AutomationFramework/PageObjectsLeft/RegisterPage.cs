using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjectsLeft
{
    class RegisterPage : PageObject
    {
        public IWebElement FirstName => WebDriver.FindElement(By.Name("firstName"));
        public IWebElement LastName => WebDriver.FindElement(By.Name("lastName"));
        public IWebElement Phone => WebDriver.FindElement(By.Name("phone"));
        public IWebElement Email => WebDriver.FindElement(By.Name("userName"));
        public IWebElement Address1 => WebDriver.FindElement(By.Name("address1"));
        public IWebElement Address2 => WebDriver.FindElement(By.Name("address2"));
        public IWebElement City => WebDriver.FindElement(By.Name("city"));
        public IWebElement State => WebDriver.FindElement(By.Name("state"));
        public IWebElement PostalCode => WebDriver.FindElement(By.Name("postalCode"));
        public IWebElement Country => WebDriver.FindElement(By.Name("country"));
        public IWebElement UserName => WebDriver.FindElement(By.Name("email"));
        public IWebElement Password => WebDriver.FindElement(By.Name("password"));
        public IWebElement ConfirmPassword => WebDriver.FindElement(By.Name("confirmPassword"));
        public IWebElement SignIn => WebDriver.FindElement(By.Name("register"));
        public IWebElement BodyElement => WebDriver.FindElement(By.TagName("body"));


        public void Register(string firstName, 
                            string lastName, 
                            string phone, 
                            string email, 
                            string address1, 
                            string address2, 
                            string city, 
                            string state, 
                            string postalCode,
                            string country,
                            string userName,
                            string password,
                            string confirmPassword)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            Phone.SendKeys(phone);
            Email.SendKeys(userName);
            Address1.SendKeys(address1);
            Address2.SendKeys(address2);
            City.SendKeys(city);
            State.SendKeys(state);
            PostalCode.SendKeys(postalCode);
            if (country != String.Empty)
                new SelectElement(Country).SelectByText(country);
            UserName.SendKeys(email);
            Password.SendKeys(password);
            ConfirmPassword.SendKeys(confirmPassword);
            
            SignIn.Submit();
        }
    }
}
