using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class AgriculturePage
    {
        IWebDriver driver;
        private const string MainLabelText = "//*[@id=\"content\"]/div/div[1]/h1";


        [FindsBy(How = How.XPath, Using = MainLabelText)]
        public IWebElement MainLabelTextField { get; set; }


        private AgriculturePage()
        {
        }

        public AgriculturePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
    }
}
