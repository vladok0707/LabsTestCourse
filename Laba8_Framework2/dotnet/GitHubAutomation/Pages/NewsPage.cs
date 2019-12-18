using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class NewsPage
    {
        IWebDriver driver;
        private const string stocksField = "//*[@id=\"content\"]/div/div[2]/div[2]/div[1]/a/div[1]";
        private const string agricultureField = "//*[@id=\"content\"]/div/div[2]/div[2]/div[2]/a/div[2]";
        private const string blogField = "//*[@id=\"content\"]/div/div[2]/div[2]/div[6]/a/div[2]";

        [FindsBy(How = How.XPath, Using = stocksField)]
        public IWebElement stocksFieldButton { get; set; }

        [FindsBy(How = How.XPath, Using = agricultureField)]
        public IWebElement agricultureFieldButton { get; set; }

        [FindsBy(How = How.XPath, Using = blogField)]
        public IWebElement blogFieldButton { get; set; }

        private NewsPage()
        {
        }

        public NewsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public StocksPage ClickToStocks()
        {
            stocksFieldButton.Click();
            return new StocksPage(driver);
        }

        public BlogPage ClickToBlog()
        {
            blogFieldButton.Click();
            return new BlogPage(driver);
        }

        public AgriculturePage ClickToAgriculture()
        {
            agricultureFieldButton.Click();
            return new AgriculturePage(driver);
        }
    }
}
