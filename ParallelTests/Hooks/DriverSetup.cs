using System;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ParallelTests.Hooks
{
    [Binding]
    public class DriverSetup
    {
        private IObjectContainer objectContainer;
        public IWebDriver Driver;
        public DriverSetup(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            objectContainer.RegisterInstanceAs(Driver);
        }
    }
}