using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDLiving.Utils
{
    class Driver
    {
        public static BrowserInit browser { get; set; }

        public static void Initialise()
        {
            browser = new BrowserInit();
            browser.driver.Manage().Window.Maximize();
        }

        public static void Navigate(String homeURL)
        {
            browser.driver.Navigate().GoToUrl(homeURL);
        }

        public static void Close()
        {
            if (browser.driver != null)
                browser.driver.Quit();
        }
    }
}
