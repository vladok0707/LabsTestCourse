using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class RassrochkaPage
    {
        IWebDriver driver;
        private const string InfoText = "//*[@id=\"content\"]/h1";


        [FindsBy(How = How.XPath, Using = InfoText)]
        public IWebElement InfoTextField { get; set; }


        private RassrochkaPage()
        {
        }

        public RassrochkaPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
