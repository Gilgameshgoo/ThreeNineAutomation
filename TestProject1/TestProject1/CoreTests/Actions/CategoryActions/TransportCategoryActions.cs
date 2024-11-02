using AutomationCore.CoreTools;
using ThreeNineTests.CoreTests.Data.DataGenerator;
using ThreeNineTests.CoreTests.PomPages.ApplicationCategories;

namespace ThreeNineTests.CoreTests.Actions.CategoryActions
{
    public static class TransportCategoryActions
    {
        public static void CarsAddApplication(CarsAddApplicationPage carsPage, CarsDataGenerator carData)
        {   
            if(carData.category!=null)
            Assert.IsTrue(carsPage.category.SelectedOption.Text.Contains(carData.category));

            if (carData.subCategory != null)
            Assert.IsTrue(carsPage.subCategory.SelectedOption.Text.Contains(carData.subCategory));

            carsPage.MatchAllSelectElementsByItsName(carsPage, carData);

        }
    }
}
