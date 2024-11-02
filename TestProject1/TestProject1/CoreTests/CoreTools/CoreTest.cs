
using Microsoft.Extensions.Configuration;
using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.PomPages;
using ThreeNineTests.CoreTests.Data.DataMappers;
using ThreeNineTests.CoreTests.Data.DataGenerator;
namespace ThreeNineTests.CoreTests.CoreTools


{
    public class CoreTest
    {
        protected string url = String.Empty;
        private IConfigurationRoot config;
        private List<UserJsonMap> users;
        private static string solFilesDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static string uploadFilesDirectory = solFilesDirectory + "\\CoreTests\\Data\\Files";
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
        protected CoreChromeDriver Open999()
        {
            CoreChromeDriver driver = new CoreChromeDriver();
            driver.Navigate().GoToUrl(url);
            Wait.UntilTrue(() => new StartPage(driver).mainLogo.Displayed,TimeSpan.FromSeconds(10));

            return driver;
        }

        protected UserJsonMap GetUser(bool featureTogle) { 
            users = config.GetRequiredSection("Users").Get<List<UserJsonMap>>() ?? throw new ArgumentNullException(nameof(users), "Users cannot be null.");
            return users.Where(p=> p.FeatrueToggle == featureTogle).ToList()[0];
       
        }
        protected CarsDataGenerator GetCarData()
        {
            return new CarsDataGenerator(uploadFilesDirectory);
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
