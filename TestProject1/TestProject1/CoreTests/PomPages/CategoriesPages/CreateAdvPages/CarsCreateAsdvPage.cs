using OpenQA.Selenium;
using ThreeNineTests.CoreTests.CoreTools;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.PomPages.CategoriesPages.CreateAdvPages
{
    public class CarsCreateAsdvPage : BasicCreateAdvPage
    {
        public CoreSelect carMakeSelect => FindSelectByLang("Marcă", "Марка");
        public CoreSelect carModelSelect => FindSelectByLang("Model", "Модель");
        public CoreSelect carGenerationSelect => FindSelectByLang("Generație", "Поколение");
        public CoreSelect carRegestrationSelect => FindSelectByLang("Înmatriculare", "Регистрация");
        public CoreSelect carConditionSelect => FindSelectByLang("Stare", "Состояние");
        public CoreSelect carAvailabilitySelect => FindSelectByLang("Disponibilitate", "Наличие");
        public CoreSelect carOriginSelect => FindSelectByLang("Țara de origine", "Происхождение автомобиля");
        public CoreSelect applicationAuthorSelect => FindSelectByLang("Autorul anunțului", "Автор объявления");
        public WebElement fabricationYearInput => FindXpath("//dl[contains(.,'An de fabricație') or contains(.,'Год выпуска')]//input");
        public CoreSelect bundleSelect => FindSelectByLang("Volan", "Руль");
        public CoreSelect seatsNumberSelect => FindSelectByLang("Număr de locuri", "Количество мест");
        public CoreSelect bodyTypeSelect => FindSelectByLang("Tip caroserie", "Тип кузова");
        public WebElement mileageInput => FindXpath("//dl[contains(.,'Rulaj') or contains(.,'Пробег')]//input");
        public WebElement engineCapacityInput => FindXpath("//dl[contains(.,'Capacitate cilindrică') or contains(.,'Объём двигателя')]//input[@class]");
        public CoreSelect fuelTypeSelect => FindSelectByLang("Tip combustibil", "Тип топлива");
        public CoreSelect transmitionTypeSelect => FindSelectByLang("Cutie de viteze", "Кпп");
        public CoreSelect driveTypeSelect => FindSelectByLang("Tip tracțiune", "Привод");


        public CarsCreateAsdvPage(CoreChromeDriver driver, IWebElement? categoryButton) : base(driver)
        {
            if (categoryButton != null) categoryButton.Click();
        }
    }
}
