using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class EnterBug : PageBase
    {
        private IWebDriver driver;
        #region WenElement

        [FindsBy(How = How.LinkText, Using = "Testng")]
        private IWebElement Testng;



        #endregion

        public EnterBug(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Navigation

        public BugDetail NavigateToDetail()
        {
            Testng.Click();
            return new BugDetail(driver);
        }


        #endregion
    }
}
