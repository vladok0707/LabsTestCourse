using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class ShippingAndPaymentPage
    {
        IWebDriver driver;
        private const string WarningTextField = "//*[@id=\"content\"]/h2/font";


        [FindsBy(How = How.XPath, Using = WarningTextField)]
        public IWebElement WarningText { get; set; }


        private ShippingAndPaymentPage()
        {
        }

        public ShippingAndPaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
