using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCodingChallengeVidya.Lib;

namespace SeleniumCodingChallengeVidya.PageObjects
{ 

   public class FormyPage : BasePage
    {
        public FormyPage(IWebDriver driver) : base(driver) { }

        public IWebElement FirstNameField => Driver.FindElement(By.Id("first-name"));
        public IWebElement LastNameField => Driver.FindElement(By.Id("last-name"));
        public IWebElement JobTitleField => Driver.FindElement(By.Id("job-title"));
        public IWebElement HighestLevelOfEducation => Driver.FindElement(By.Id("radio-button-2"));
        public IWebElement SexSelection => Driver.FindElement(By.Id("checkbox-2"));
        public IWebElement YearsOfExperience => Driver.FindElement(By.Id("select-menu"));
        public IWebElement Date => Driver.FindElement(By.Id("datepicker"));
        public IWebElement SubmitButton => Driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary"));

        public void FillOutForm(string firstName, string lastName, string jobTitle, string Experience, string DateField)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
            JobTitleField.SendKeys(jobTitle);
            HighestLevelOfEducation.Click();
            SexSelection.Click();
            YearsOfExperience.Click();
            Driver.FindElement(By.CssSelector("option[value='3']")).Click();
            DateTime dateTime = DateTime.UtcNow.Date;//gets current date
            //. Assert the date picker defaults to the current date
            Assert.NotEqual(dateTime.ToString("mm/dd/yyyy"), Date.Text);
            Date.SendKeys(DateField);
            SubmitButton.Click();

        }
    }


}
