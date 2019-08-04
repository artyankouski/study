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
    class MainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Lists')]")]
        public IWebElement toolsBtn;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Companies')]")]
        public IWebElement companiesOption;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'EDIT')]")]
        public IWebElement editBtn;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'BULK EDIT ENTRIES')]")]
        public IWebElement bulkEditEntrBtn;
    }
}
