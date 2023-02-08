using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDLiving.PageObjects
{
    class PageObjectGoogleHomePage
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public PageObjectGoogleHomePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By searchBox = By.Name("q");
        By hindiLink = By.CssSelector("#SIvCob > a:nth-child(1)");

        public void EnterSearchText(string stext)
        {
            driver.FindElement(searchBox).SendKeys(stext);
            Thread.Sleep(2000);
        }

        public void PressEnter()
        {
            driver.FindElement(searchBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }

        public Boolean IsGoogleHomePageDisplayed()
        {
            return driver.FindElement(searchBox).Displayed;
        }
    }
}
