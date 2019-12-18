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

        [Test]
        public void ClickRedirectVkIconFooter()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                string redirectUrl = new MainPage(Driver).ClickVkFooterIcon();
                Assert.AreEqual("https://vk.com/doms.market", redirectUrl);

            });
        }

        [Test]
        public void CheckInfoOnRassrochkaPage()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                RassrochkaPage rPage = new MainPage(Driver).ClikToRassrochkaButton();
                Assert.AreEqual("Рассрочка 0%", rPage.InfoTextField.Text);

            });
        }

        [Test]
        public void CheckAddressInfoOnCallbackPage()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                CallbackPage cPage = new MainPage(Driver).ClikToCallbackButton();
                Assert.AreEqual("DOMs.by - Товары для дома и сада", cPage.AboutTextField.Text);

            });
        }

        [Test]
        public void CheckClickOnEmptyBag()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                MainPage mPage = new MainPage(Driver).ClickToEmptyCard();
                Assert.AreEqual("Ваша корзина пуста!", mPage.infoAboutEmptyBagField.Text);

            });
        }

        [Test]
        public void CheckMainLabelOnStocksNews()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                NewsPage nPage = new MainPage(Driver).ClickToNews();
                StocksPage sPage = nPage.ClickToStocks();
                Assert.AreEqual("Акции", sPage.MainLabelTextField.Text);

            });
        }

        [Test]
        public void CheckMainLabelOnAgricultureNews()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                NewsPage nPage = new MainPage(Driver).ClickToNews();
                AgriculturePage sPage = nPage.ClickToAgriculture();
                Assert.AreEqual("Земледелие", sPage.MainLabelTextField.Text);

            });
        }

        [Test]
        public void CheckMainLabelOnBlogNews()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://doms.by/");
                NewsPage nPage = new MainPage(Driver).ClickToNews();
                BlogPage sPage = nPage.ClickToBlog();
                Assert.AreEqual("Блог", sPage.MainLabelTextField.Text);

            });
        }

    }
}
