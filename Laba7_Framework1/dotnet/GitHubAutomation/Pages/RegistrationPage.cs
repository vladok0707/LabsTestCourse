using Framework.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class RegistrationPage
    {
        IWebDriver driver;
        private const string RegistrationPersonButtonField = "//a[@class='button btn-primary button_oc btn']";
        private const string ErrorEmailField = "//div[@class='col-sm-10']//div[@data-rule='regexp']";

        [FindsBy(How = How.XPath, Using = ErrorEmailField)]
        public IWebElement ErrorEmail { get; set; }

        [FindsBy(How = How.XPath, Using = RegistrationPersonButtonField)]
        public IWebElement RegistrationPersonButton { get; set; }

        [FindsBy(How = How.Id, Using = "register_firstname")]
        public IWebElement PersoFirstnNameInput { get; set; }

        private RegistrationPage()
        {
        }

        public RegistrationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public RegistrationPage ClickOnRegistationPersonButton(Registration person)
        {
            PersoFirstnNameInput.Clear();
            PersoFirstnNameInput.SendKeys(person.Name);
            RegistrationPersonButton.Click();
            return new RegistrationPage(driver);
        }
    }
}
