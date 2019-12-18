using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class SpecialPage
    {
        IWebDriver driver;

        private const string SpecialTextField = "product-label-special";


        [FindsBy(How = How.ClassName, Using = SpecialTextField)]
        public IWebElement SpecialText { get; set; }

        public SpecialPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        
    }
}
