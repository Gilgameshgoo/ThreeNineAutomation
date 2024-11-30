using AutomationCore.CoreTools;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Serilog;
using Serilog.Core;
using ThreeNineTests.CoreTests.Data.DataGenerator;
using ThreeNineTests.CoreTests.Data.DataMappers;
using ThreeNineTests.CoreTests.PomPages;
namespace ThreeNineTests.CoreTests.CoreTools


{
    public class CoreTest
    {
        protected string url = String.Empty;
        protected CoreChromeDriver driver;
        private IConfigurationRoot config;
        private List<UserJsonMap> users;
        private static string solFilesDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName.Replace("\\","/");
        private static string uploadFilesDirectory = solFilesDirectory + "/CoreTests/Data/Files/";
        private string configFilesDirectory = solFilesDirectory + "/CoreTests/Config/ConfigData";
        string env;
        protected CarsDataGenerator GeneratedCarData = new CarsDataGenerator(uploadFilesDirectory);
        protected MonitorDataGenerator GeneratedMonitorData = new MonitorDataGenerator(uploadFilesDirectory);
        protected Logger logger = new LoggerConfiguration().WriteTo.Console().WriteTo.File("log.txt").CreateLogger();

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

        protected CoreChromeDriver Open999()
        {
            ChromeOptions options = new ChromeOptions();
            options.BrowserVersion = "126.0";

            options.AddAdditionalOption("selenoid:options", new Dictionary<string, object>
            {   
                ["name"] = $"Running test: {TestContext.CurrentContext.Test.Name}",

                ["sessionTimeout"] = "3m",

                ["env"] = new List<string>() {
                "TZ=UTC"},
         
                ["labels"] = new Dictionary<string, object>
                {
                    ["manual"] = "true"
                },
                ["enableVNC"] = true
            });
            driver = new CoreChromeDriver(new Uri("http://193.180.209.207:4444/wd/hub"), options);

            logger.Information("Launching 999");

            driver.Navigate().GoToUrl(url);
            Wait.UntilTrue(() => new StartPage(driver).mainLogo.Displayed, TimeSpan.FromSeconds(10));

            return driver;
        }

        protected UserJsonMap GetUser(bool featureTogle)
        {
            users = config.GetRequiredSection("Users").Get<List<UserJsonMap>>() ?? throw new ArgumentNullException(nameof(users), "Users cannot be null.");
            return users.Where(p => p.FeatrueToggle == featureTogle).ToList()[0];

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
