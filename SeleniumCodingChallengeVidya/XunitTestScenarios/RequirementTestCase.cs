using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumCodingChallengeVidya.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using SeleniumCodingChallengeVidya.Lib;


namespace SeleniumCodingChallengeVidya.XunitTestScenarios
{
    public class RequirementTestCase : IClassFixture<TestFixture>
    {


        private IWebDriver _driver;
        private readonly FormyPage _formPage;

        public RequirementTestCase(TestFixture fixture)
        {
            _driver = fixture.Driver;
            _formPage = new FormyPage(_driver);
        }

        [Fact]
        public void FillOutFormTest()
        {

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/form");

              _formPage.FillOutForm("John", "Doe", "Software Engineer", "5–9","04/24/2023");

            // After clicking Submit, assert the following message is show on the screen: “The form was successfully submitted!”
            Assert.Equal("The form was successfully submitted!", _driver.FindElement(By.XPath("//*[@class=\"alert alert-success\"]")).Text);
            _driver.Close();
            _driver.Quit();
        }

    }


}
