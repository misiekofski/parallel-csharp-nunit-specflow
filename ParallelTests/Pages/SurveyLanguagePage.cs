using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace ParallelTests.Pages
{
    public class SurveyLanguagePage
    {
        private IWebDriver _driver;

        public SurveyLanguagePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IList<IWebElement> languageRows => _driver.FindElements(By.CssSelector("span.languageName"));


        public void SelectLanguage(string language)
        {
            var row = languageRows.FirstOrDefault(e => e.GetAttribute("innerHTML").Contains(language));
            row.FindElement(By.XPath("../..//input[contains(@class, 'button')]")).Click();
        }
    }
}