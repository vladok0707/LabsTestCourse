using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.PageObject;

namespace SeleniumWebdriver.Tests
{
    [TestFixture]
    public class SearchTest : TestBase
    {
       

        [Test]
        public void ErrorWhenRegistrationWithEmptyField()
        {
            string ErrorEmail = "Некорректный адрес электронной почты!";
            MainPage mainPage = new MainPage(_webDriver);
            var registationPage = mainPage.ClickOnAccountField().ClickToRegistrationButton();
            registationPage.ClickOnRegistationPersonButton();
            Assert.AreEqual(ErrorEmail, registationPage.ErrorEmail.Text);
        }

        [Test]
        public void CheckWarningTextOnShippingAndPaymentPage()
        {
            MainPage mainPage = new MainPage(_webDriver);
            var shippingAndPaymentPage = mainPage.CliclToShippingAndPaymentButton();
            string WarningText = "Внимание! Все цены на сайте указаны в белорусских рублях!";
            Assert.AreEqual(WarningText, shippingAndPaymentPage.WarningText.Text);
        }

        [Test]
        public void CheckSpecialProduct()
        {
            MainPage mainPage = new MainPage(_webDriver);
            var specialPage = mainPage.ClickMenuSpecialButton();
            string specialText = "СКИДКА";
            Assert.AreEqual(specialText, specialPage.SpecialText.Text);
        }

    }
}
