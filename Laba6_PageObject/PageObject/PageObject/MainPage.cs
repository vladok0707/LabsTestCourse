using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObject.PageObject
{
    public class MainPage : BasePage
    {
        private const string accountButtonField = "//a[@class='dropdown-toggle']";
        private const string registrationButtonOnHeaderField = "//i[@class='fa fa-user-plus']";
        private const string shippingAndPayment = "//*[@id=\"top\"]/div/ul/li[2]/a";

        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnHeaderField)]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.XPath, Using = shippingAndPayment)]
        public IWebElement ShippingAndPaymentButton { get; set; }

        private MainPage()
        {
        }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            InitPage(driver, this);
        }

        public MainPage ClickOnAccountField()
        {
            AccountButton.Click();
            return new MainPage(Driver);
        }

        public RegistrationPage ClickToRegistrationButton()
        {
            RegistrationButton.Click();
            return new RegistrationPage(Driver);
        }

        public ShippingAndPaymentPage CliclToShippingAndPaymentButton()
        {
            ShippingAndPaymentButton.Click();
            return new ShippingAndPaymentPage(Driver);
        }


    }
}
