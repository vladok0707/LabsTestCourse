using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.PageObject
{
    public class SpecialPage : BasePage
    {
        private const string SpecialTextField = "product-label-special";
       

        [FindsBy(How = How.ClassName, Using = SpecialTextField)]
        public IWebElement SpecialText { get; set; }

       
        private SpecialPage()
        {
        }

        public SpecialPage(IWebDriver driver)
        {
            Driver = driver;
            InitPage(driver, this);
        }

      
    }
}
