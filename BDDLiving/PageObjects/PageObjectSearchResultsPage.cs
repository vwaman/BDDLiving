using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDLiving.PageObjects
{
    class PageObjectSearchResultsPage
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public PageObjectSearchResultsPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        By resBar = By.Id("extabar");
        By results = By.Id("rcnt");


        public Boolean IsResultsBarDisplayed()
        {
            return driver.FindElement(resBar).Displayed;
        }

        public string GetResultsFromPage()
        {
            return driver.FindElement(results).Text;
        }

    }
}
