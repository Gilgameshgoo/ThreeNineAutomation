using Microsoft.VisualBasic;
using NUnit.Framework.Diagnostics;
using System.Diagnostics;
using ThreeNineTests.CoreTests.Actions;
using ThreeNineTests.CoreTests.CoreTools;
namespace ThreeNineTests.UiTests
{
    //[Parallelizable(ParallelScope.Children)]
    public class BaseFunctionalityTests : CoreTest
    {
        [SetUp]
        public void Setup()
        {
            logger.Information("======================================");
        }
        [Test]
        public void Login()
        {
            logger.Information("Statred Login"); 
            var driver = Open999();
            var user = GetUser(featureTogle: true);

            LogRegActions.Login(driver, user);
        }

        [Test]
        public void SendMessage()
        {
            logger.Information("Statred SendMessageTest");
            var driver = Open999();

            var user = GetUser(featureTogle: true);

            logger.Information("User Login");
            var homePage = LogRegActions.Login(driver, user);

            logger.Information("Open Recomended Item");
            var applicationPage = HomePageActions.OpenRecomendedItem(driver, homePage);

            logger.Information("Sending Message");
            Assert.That(ApplicationActions.SendMessage(driver, applicationPage));

            logger.Information("Openning Adv Page From Chat");
            Assert.That(ApplicationActions.OpenAdvPageFromChat(driver, applicationPage));
        }

        [Test]
        public void AddAdvToFavoriteTest()
        {
            logger.Information("Statred AddAdvToFavoriteTest");
            var driver = Open999();

            var user = GetUser(featureTogle: true);

            logger.Information("User Login");
            var homePage = LogRegActions.Login(driver, user);

            logger.Information("Open First Recomnded Item");
            var applicationPage = HomePageActions.OpenRecomendedItem(driver, homePage);

            logger.Information("Add Item to Favorite List and Check It");
            Assert.That(ApplicationActions.AddToFavoriteAndCheckFavoriteList(applicationPage, driver));
        }

       [TearDown]
       public void TearDown()
       {
           logger.Information("Tests Finished");
           driver.Quit();
       }
    }
}

