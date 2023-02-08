using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDLiving.Utils
{
    [Binding]
    class Start : Driver
    {
        Objects ob = null;

        [BeforeScenario]
        public void setup()
        {
            // Initiating Browser
            Initialise();


            // Initializing all the Page Objects
            ob = new Objects(Driver.browser.driver, browser.wait);
            ob.ObjectInitialisation();


            string appURL = "https://www.google.com/";

            Driver.Navigate(appURL);
        }


        [AfterScenario]
        public void tearDown()
        {
            Driver.Close();
        }

    }
}
