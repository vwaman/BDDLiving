using BDDLiving.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDLiving.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {

        [Given(@"that i am on google home page")]
        public void GivenThatIAmOnGoogleHomePage()
        {
            Assert.AreEqual(true, Objects.objGHomePage.IsGoogleHomePageDisplayed());
        }


        [When(@"i enter the search text (.*) in search box")]
        public void WhenIEnterTheSearchTextInSearchBox(string stext)
        {
            Objects.objGHomePage.EnterSearchText(stext);
        }

        [When(@"press enter")]
        public void WhenPressEnter()
        {
            Objects.objGHomePage.PressEnter();
        }


        [Then(@"search results should be displayed as per entered text (.*)")]
        public void ThenSearchResultsShouldBeDisplayedAsPerEnteredText(string stext)
        {
            Assert.AreEqual(true, Objects.objResultsPage.IsResultsBarDisplayed());

            string results = Objects.objResultsPage.GetResultsFromPage();

            if (results.Contains(stext))
            {
                Console.WriteLine("Results displayed correctly");
            }
        }
    }
}
