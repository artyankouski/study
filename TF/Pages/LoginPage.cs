using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

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
    }
}
