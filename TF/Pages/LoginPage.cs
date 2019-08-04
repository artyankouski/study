using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;

namespace TF.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement emailInput;
        [FindsBy(How = How.XPath, Using = "//input[@data-qa-id='next_button']")]
        public IWebElement nextBtn;
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement passInput;
        [FindsBy(How = How.XPath, Using = "//input[@data-qa-id='ok_button']")]
        public IWebElement lgnBtn;
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='open dropdown']")]
        public IWebElement chsClDD;
        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Alchemy Partners')]")]
        public IWebElement client;
        [FindsBy(How =How.XPath, Using = "//input[@data-qa-id='ok_button']")]
        public IWebElement chooseSiteBtn;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Alchemy Partners')]")]
        public IWebElement companyLogo;


        public void EnterUsername(String username)
        {
            emailInput.Click();
            emailInput.SendKeys(username);
            nextBtn.Click();
        }
        public void EnterPassword(String password)
        {
            passInput.Click();
            passInput.SendKeys(password);
            lgnBtn.Click();
        }
        public void ChooseClient()
        {
            chsClDD.Click();
            Thread.Sleep(1500);
            client.Click();
            Thread.Sleep(1000);
            chooseSiteBtn.Click();
        }
        public void CheckAlchemyLogo()
        {
            String logo = companyLogo.Text.Trim();
            Assert.AreEqual("Alchemy Partners", logo);
        }
    }
}
