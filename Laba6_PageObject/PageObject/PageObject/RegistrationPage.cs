using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.PageObject
{
    public class RegistrationPage : BasePage
    {
        private const string RegistrationPersonButtonField = "//a[@class='button btn-primary button_oc btn']";
        private const string ErrorEmailField = "//div[@class='col-sm-10']//div[@data-rule='regexp']";

        [FindsBy(How = How.XPath, Using = ErrorEmailField)]
        public IWebElement ErrorEmail { get; set; }

        [FindsBy(How = How.XPath, Using = RegistrationPersonButtonField)]
        public IWebElement RegistrationPersonButton { get; set; }

        private RegistrationPage()
        {
        }

        public RegistrationPage(IWebDriver driver)
        {
            Driver = driver;
            InitPage(driver, this);
        }

        public RegistrationPage ClickOnRegistationPersonButton()
        {
            RegistrationPersonButton.Click();
            return this;
        }
    }
}
