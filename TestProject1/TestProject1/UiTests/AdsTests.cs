using ThreeNineTests.CoreTests.Actions;
using ThreeNineTests.CoreTests.Actions.CategoryActions;
using ThreeNineTests.CoreTests.CoreTools;
namespace ThreeNineTests.UiTests
{
    public class AdsTests : CoreTest
    {
        [Test]
        public void CreateAdv_SellingPcHardWare_Monitor()
        {
            logger.Information("Started CreateAdv_SellingPcHardWare_Monitor");
            
            var driver = Open999();

            var user = GetUser(featureTogle: true);

            logger.Information("Login");
            var homePage = LogRegActions.Login(driver, user);

            logger.Information("Open Categories Menu");
            var categoriesPage = HomePageActions.OpenCategoriesMenu(driver, homePage);

            logger.Information("Open Category");
            var monitorPage = HomePageActions.OpenCategory(categoriesPage.ComputersAndOffice.Monitor);

            logger.Information("Monitor Create AdvPage");
            var createdAdvs = ComputersAndOfficeCategoryActions.MonitorCreateAdvPage(monitorPage, GeneratedMonitorData, driver);

            logger.Information("Monitor Check AdvPage");
            Assert.That(ComputersAndOfficeCategoryActions.MonitorCheckAdvPage(createdAdvs, GeneratedMonitorData));
        }

        [Test]
        public void CreateAdv_SellingTransport_PassengerVehicle()
        {
           
            logger.Information("Started CreateAdv_SellingTransport_PassengerVehicle");
            var driver = Open999();

            var user = GetUser(featureTogle: true);

            logger.Information("Login");
            var homePage = LogRegActions.Login(driver, user);

            logger.Information("Open Categories Menu");
            var categoriesPage = HomePageActions.OpenCategoriesMenu(driver, homePage);

            logger.Information("Open Category");
            var carsPage = HomePageActions.OpenCategory(categoriesPage.Transport.Cars);

            logger.Information("Vehicle Create AdvPage");
            Assert.That(TransportCategoryActions.CarsAddApplication(carsPage, GeneratedCarData));
        }

        [TearDown]
        public void TearDown()
        {
            logger.Information("Test Finished");
            if (driver != null) {driver.Quit();}
                       
        }
    }
}

