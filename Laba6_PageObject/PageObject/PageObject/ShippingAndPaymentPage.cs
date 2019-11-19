using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.PageObject
{
    public class ShippingAndPaymentPage : BasePage
    {
        private const string WarningTextField = "//*[@id=\"content\"]/h2/font";
       

        [FindsBy(How = How.XPath, Using = WarningTextField)]
        public IWebElement WarningText { get; set; }

       
        private ShippingAndPaymentPage()
        {
        }

        public ShippingAndPaymentPage(IWebDriver driver)
        {
            Driver = driver;
            InitPage(driver, this);
        }

      
    }
}
