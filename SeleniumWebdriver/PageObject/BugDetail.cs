using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class BugDetail : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        [FindsBy(How = How.Id, Using = "bug_severity")]
        private IWebElement SeverityDropDown;

        #endregion

        public BugDetail(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Action

        public void SelectFromSeverity(string value)
        {
            ComboBoxHelper.SelectElement(SeverityDropDown, value);
        }

        #endregion
    }
}
