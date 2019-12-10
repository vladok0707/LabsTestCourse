using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class MainPage
    {
        IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string accountButtonField = "//a[@class='dropdown-toggle']";
        private const string registrationButtonOnHeaderField = "//i[@class='fa fa-user-plus']";
        private const string shippingAndPayment = "//*[@id=\"top\"]/div/ul/li[2]/a";
        private const string specialMenuField = "//*[@id=\"bs-megamenu\"]/ul/li[1]/a";

        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnHeaderField)]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.XPath, Using = shippingAndPayment)]
        public IWebElement ShippingAndPaymentButton { get; set; }

        [FindsBy(How = How.XPath, Using = specialMenuField)]
        public IWebElement specialMenuButton { get; set; }

        public MainPage ClickOnAccountField()
        {
            AccountButton.Click();
            return new MainPage(driver);
        }

        public RegistrationPage ClickToRegistrationButton()
        {
            RegistrationButton.Click();
            return new RegistrationPage(driver);
        }

        public ShippingAndPaymentPage CliclToShippingAndPaymentButton()
        {
            ShippingAndPaymentButton.Click();
            return new ShippingAndPaymentPage(driver);
        }

      

       

       
    }
}
