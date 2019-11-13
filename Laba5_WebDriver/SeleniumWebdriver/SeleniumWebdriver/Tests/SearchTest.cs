using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebdriver.Tests
{
    [TestFixture]
    public class SearchTest : TestBase
    {
        string ErrorEmail = "Некорректный адрес электронной почты!";

        [Test]
        public void CheckErrorWhenRegisterFieldsEmpty()
        {
            IWebElement link = _webDriver.FindElement(By.XPath("//a[@class='dropdown-toggle']"));
            link.Click();
            link = _webDriver.FindElement(By.XPath("//i[@class='fa fa-user-plus']"));
            link.Click();
            link = _webDriver.FindElement(By.XPath("//a[@class='button btn-primary button_oc btn']"));
            link.Click();
            Thread.Sleep(1000);
            IWebElement emailErrorElement = _webDriver.FindElement(By.XPath("//div[@class='col-sm-10']//div[@data-rule='regexp']"));
            Assert.AreEqual(ErrorEmail, emailErrorElement.Text);
        } 

        string urlVkDomsBy= "https://vk.com/doms.market";
        [Test]
        public void pressVkIconInFooter()
        {
            IWebElement link = _webDriver.FindElement(By.XPath("//i[@class='fa fa-vk']"));
            link.Click();
            string urlVk = _webDriver.Url;
            Assert.AreEqual(urlVkDomsBy, urlVk);
        }
    }
}
