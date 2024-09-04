
using Microsoft.Extensions.Configuration;
using ThreeNineTests.CoreTests.ConfigUser;
using AutomationCore.CoreTools;


using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
namespace ThreeNineTests.CoreTests.CoreTools


{
    public class CoreTest
    {
        protected string url = String.Empty;
        private IConfigurationRoot config;
        private List<UserJsonMap> users;
        private static string solFilesDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private string configFilesDirectory = solFilesDirectory  + "\\CoreTests\\ConfigData";
        string env;
       
        public CoreTest()
        {
            GetEnv();
            config = new ConfigurationBuilder()
            .AddJsonFile(configFilesDirectory + $"/{env}Config.json")
            .AddEnvironmentVariables()
            .Build();
            

            url = config.GetValue<string>("Url") ?? throw new ArgumentNullException(nameof(url), "Url cannot be null.");
            GetUser(true);
        }
        protected IWebDriver Open999()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            Wait.UntilTrue(()=> (driver.ExecuteJavaScript<string>("return document.readyState;") == "complete"),TimeSpan.FromSeconds(10));

            return driver;
        }

        protected UserJsonMap GetUser(bool featureTogle) { 
            users = config.GetRequiredSection("Users").Get<List<UserJsonMap>>() ?? throw new ArgumentNullException(nameof(users), "Users cannot be null.");
            return users.Where(p=> p.FeatrueToggle == featureTogle).ToList()[0];
       
        }
        private void GetEnv()
        {
             #if UAT
             env = "UAT";
             #elif QA
             env = "QA";
             #endif          
        }
    }
}
