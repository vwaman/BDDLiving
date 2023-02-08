using BDDLiving.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDLiving.Utils
{
    class Objects
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public Objects(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }


        public static PageObjectGoogleHomePage objGHomePage { get; set; }
        public static PageObjectSearchResultsPage objResultsPage { get; set; }


        public void ObjectInitialisation()
        {
            objGHomePage = new PageObjectGoogleHomePage(driver, wait);
            objResultsPage = new PageObjectSearchResultsPage(driver, wait);
        }
    }
}
