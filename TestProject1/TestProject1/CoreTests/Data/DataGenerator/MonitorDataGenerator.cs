namespace ThreeNineTests.CoreTests.Data.DataGenerator
{
    public class MonitorDataGenerator
    {
        public string category = "Calculatoare și birotică";
        public string subCategory = "Monitoare";
        public string regionSelect = "//ComandAny//";
        public string priceInput = "580";
        public string currencySelect = "€";
        public bool applicationTypeSell = true;
        public string applicationTitleInput = "Vand Monitor Xiaomi MI Curved 34inch";
        public string applicationDescriptionInput = "Vand Monitor Xiaomi MI Curved 34inch, Stare Bun ";
        public string? applicationTags;
        public bool noPhoneNumberSwitch = true;
        public string photo = "Monitor.jpg";
        public string manufmanufacturerSelect = "//ComandAny//";
        public string screenDiagonalSelect = "//ComandAny//";
        public string resolutionSelect = "//ComandAny//";

        public MonitorDataGenerator(string uploadFilesPath)
        {
            photo = uploadFilesPath + photo;
        }
    }
}
