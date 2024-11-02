using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.Actions;
using ThreeNineTests.CoreTests.Actions.CategoryActions;
namespace ThreeNineTests.UiTests
{
    internal class BaseFunctionalityTests:CoreTest
    {

        [Test]
        public void Login() {
            var driver = Open999();
            var user = GetUser(featureTogle : true);
   
            Assert.IsNotNull(LogRegActions.Login(driver, user));
        }

        [Test]
        public void SendMessage()
        {
            var driver = Open999();
            var user = GetUser(featureTogle: true);

            var homePage = LogRegActions.Login(driver, user);

            var applicationPage = HomePageActions.OpenRecomendedItem(driver, homePage);

            Assert.IsTrue(ApplicationActions.SendMessage(driver, applicationPage));

            Assert.IsTrue(ApplicationActions.OpenAppPageFromChat(driver, applicationPage));
        }

        [Test]
        public void CreateAndSearchApplication()
        {
            var driver = Open999();
            var user = GetUser(featureTogle: true);
            var carData = GetCarData();

            var homePage = LogRegActions.Login(driver, user);

            var categoriesPage = HomePageActions.OpenCategoriesMenu(driver, homePage);

            var carsPage = CategoryActions.OpenCategory(categoriesPage.Transport.Cars);
            TransportCategoryActions.CarsAddApplication(carsPage, carData);





            //Assert.IsTrue(ApplicationActions.OpenAppPageFromChat(driver, applicationPage));
        }
    }
}

