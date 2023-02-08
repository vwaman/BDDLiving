using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDLiving.Utils
{
    class BrowserInit
    {
        public IWebDriver driver;
        public WebDriverWait wait = null;
        internal string driverName = string.Empty;
        internal string driverPath = string.Empty;

        public BrowserInit()
        {
            try
            {
                String browseName = "chrome";
                //string rootPath = @"E:\BDDLiving";
                string rootPath = Environment.CurrentDirectory;
                if (browseName.Equals(Enum.BrowserList.chrome.ToString()))
                {
                    driverPath = rootPath + "\\Library\\";
                    driverName = "webdriver.chrome.driver";
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--disable-extensions");
                    options.AddAdditionalChromeOption("useAutomationExtension", false);

                    driver = new ChromeDriver(driverPath, options);
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Browser has not been initialised: " + e.Message + e.StackTrace);
            }
        }
    }
}

