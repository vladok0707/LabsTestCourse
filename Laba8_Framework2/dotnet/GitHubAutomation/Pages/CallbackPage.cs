using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class CallbackPage
    {
        IWebDriver driver;
        private const string AboutText = "//*[@id=\"content\"]/div[3]/div[1]/div/div/div/div[1]/div[2]/strong";


        [FindsBy(How = How.XPath, Using = AboutText)]
        public IWebElement AboutTextField { get; set; }


        private CallbackPage()
        {
        }

        public CallbackPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
