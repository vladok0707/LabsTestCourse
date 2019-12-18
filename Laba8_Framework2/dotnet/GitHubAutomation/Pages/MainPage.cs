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
        private const string vkFooterIcon = "//i[@class='fa fa-vk']";
        private const string rassrochka = "//*[@id=\"top\"]/div/ul/li[3]/a";
        private const string callback = "//*[@id=\"top\"]/div/ul/li[4]/a";
        private const string bag = "//*[@id=\"cart\"]/div/h5";
        private const string newsField = "//*[@id=\"bs-megamenu\"]/ul/li[3]/a/span";
        private const string infoAboutEmptyBag = "//*[@id=\"cart\"]/ul/li/p";

        [FindsBy(How = How.XPath, Using = newsField)]
        public IWebElement newsFieldButton { get; set; }

        [FindsBy(How = How.XPath, Using = infoAboutEmptyBag)]
        public IWebElement infoAboutEmptyBagField { get; set; }

        [FindsBy(How = How.XPath, Using = bag)]
        public IWebElement bagButton { get; set; }

        [FindsBy(How = How.XPath, Using = callback)]
        public IWebElement callbackButton { get; set; }

        [FindsBy(How = How.XPath, Using = rassrochka)]
        public IWebElement rassrochkaButton { get; set; }

        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnHeaderField)]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.XPath, Using = shippingAndPayment)]
        public IWebElement ShippingAndPaymentButton { get; set; }

        [FindsBy(How = How.XPath, Using = specialMenuField)]
        public IWebElement specialMenuButton { get; set; }

        [FindsBy(How = How.XPath, Using = vkFooterIcon)]
        public IWebElement vkFooterIconButton { get; set; }

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

        public SpecialPage ClickMenuSpecialButton()
        {
            specialMenuButton.Click();
            return new SpecialPage(driver);
        }

        public string ClickVkFooterIcon()
        {
            vkFooterIconButton.Click();
            return driver.Url;
        }

        public RassrochkaPage ClikToRassrochkaButton()
        {
            rassrochkaButton.Click();
            return new RassrochkaPage(driver);
        }

        public CallbackPage ClikToCallbackButton()
        {
            callbackButton.Click();
            return new CallbackPage(driver);
        }

        public MainPage ClickToEmptyCard()
        {
            bagButton.Click();
            return new MainPage(driver);
        }

        public NewsPage ClickToNews()
        {
            newsFieldButton.Click();
            return new NewsPage(driver);
        }

    }
}
