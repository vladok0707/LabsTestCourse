using System;
using System.IO;
using Framework.Driver;

using Framework.Services;
using GitHubAutomation.Tests;
using GitHubAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Framework.Tests
{
    class ShopTests : TestConfig
    {
        [Test]
        public void ErrorWhenRegistrationWithEmptyField()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                RegistrationPage rPage = new MainPage(Driver)
                         .ClickOnAccountField().ClickToRegistrationButton();
                rPage.ClickOnRegistationPersonButton(RegistrationCreator.WithAllProperties());
                Assert.AreEqual("Некорректный адрес электронной почты!", rPage.ErrorEmail.Text);

            });
          
        }

        [Test]
        public void CheckWarningTextOnShippingAndPaymentPage()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                ShippingAndPaymentPage sPage = new MainPage(Driver).CliclToShippingAndPaymentButton();
                Assert.AreEqual("Все цены на сайте указаны в белорусских рублях!", sPage.WarningText.Text);

            });
        }

        [Test]
        public void CheckSpecialProduct()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                SpecialPage sPage = new MainPage(Driver).ClickMenuSpecialButton();
                Assert.AreEqual("СКИДКА", sPage.SpecialText.Text);

            });
        }

    }
}
