using OpenQA.Selenium;
using ParallelTests.Pages;
using TechTalk.SpecFlow;

namespace ParallelTests.StepDefinitions
{
    [Binding]
    public class SurveyEngineSteps
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public SurveyEngineSteps(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }


        [Given(@"I go to survey id (.*)")]
        public void GoToSurveyId(string id)
        {
            _driver.Url = $"https://mresearchsurveyengine-qa-de.modernsurvey.com/SelectLanguage.aspx?eaid={id}";
            _scenarioContext["id"] = id;
        }

        [When(@"I select survey language (.*)")]
        public void SelectSurveyLanguage(string language)
        {
            var page = new SurveyLanguagePage(_driver);
            page.SelectLanguage(language);
        }

    }
}