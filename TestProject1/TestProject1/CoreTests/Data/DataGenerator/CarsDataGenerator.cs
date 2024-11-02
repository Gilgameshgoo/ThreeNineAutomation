namespace ThreeNineTests.CoreTests.Data.DataGenerator
{
    public class CarsDataGenerator
    {
        public string category = "Transport";
        public string subCategory = "Autoturisme";
        public string regionSelect = "//ComandAny//";
        public string price = "5500";
        public string currencySelect = "€";
        public bool applicationTypeSell= true;
        public string applicationTitle = "Vand Merceds Vito 2008";
        public string applicationDescription = "Vand Merceds Vito 2008, Stare Perfecta, Fac Cadou pentru Anul Nou ,Sunati Foaarte Urgent 060591011 - Denis";
        public string? applicationTags;
        public bool noPhoneNumberSwitch = true;
        public string photoInput = "Vito.jpeg";
        public string carMakeSelect = "Mercedes";
        public string carModelSelect = "Vito";
        public string carRegestrationSelect = "Republica Moldova";
        public string carConditionSelect = "Nou";
        public string carAvailabilitySelect = "Disponibil";
        public string carOriginSelect = "SUA";
        public string applicationAuthorSelect = "//ComandAny//";
        public string fabricationYearInput = "2008";
        public string bundleSelect = "//ComandAny//";
        public string seatsNumberSelect = "//ComandAny//";
        public string bodyTypeSelect = "//ComandAny//";
        public string mileage = "300000";
        public string engineCapacityInput = "2000"; 
        public string fuelTypeSelect = "//ComandAny//";
        public string transmitionTypeSelect = "//ComandAny//"; 
        public string driveTypeSelect = "//ComandAny//";


        public CarsDataGenerator(string uploadFilesPath) {
            photoInput = uploadFilesPath + photoInput;
        }
    }
}
