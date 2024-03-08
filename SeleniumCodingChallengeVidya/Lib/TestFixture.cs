using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Xunit;

namespace SeleniumCodingChallengeVidya.Lib{
   

    public class TestFixture : IClassFixture<TestFixture>
    {
        public IWebDriver Driver { get; }

        public TestFixture()
        {
            // Set the path to the ChromeDriver or firefox path executable if the driver is not available in bin
            //var DriverPath = "path/to/chromedriver";

            // TO Create a new instance of the Driver pls update the path DriverPath or install the driver from market place
            Driver = new ChromeDriver("chromedriver.exe");
            //Driver = new FirefoxDriver("firefox.exe");

        }

     
    }

}
