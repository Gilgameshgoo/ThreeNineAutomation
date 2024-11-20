using AutomationCore.CoreTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ThreeNineTests.CoreTests.CoreTools.Elements
{
    public class CoreSelect : SelectElement
    {
        IWebDriver driver;
        public CoreSelect(IWebElement element) : base(element)
        {

        }
        public string SelectByText(string text)
        {
            if (text == "//ComandAny//")
            {
                var optionToBeSelected = ParseAnyOptionWithValue();
                base.SelectByText(optionToBeSelected.Text);
                var k = optionToBeSelected.Text;
                return optionToBeSelected.Text;
            }
            else { base.SelectByText(text); }

            return SelectedOption.Text;
        }

        public string SafeSelectByText(string text, int wait)
        {
            if (text == "//ComandAny//")
            {
                Wait.UntilTrue(() =>
                {

                    var ji = this.SelectByText(text);
                    var f = SelectedOption.Text;
                    return SelectedOption.Text.Equals(ji);
                }, TimeSpan.FromSeconds(wait));
            }
            else
            {
                Wait.UntilTrue(() =>
                {
                    this.SelectByText(text);
                    return SelectedOption.Text.Equals(text);
                }, TimeSpan.FromSeconds(wait));
            }

            return SelectedOption.Text;
        }

        private IWebElement ParseAnyOptionWithValue()
        {

            IWebElement optionToBeSelected;

            while (true)
            {
                optionToBeSelected = Options[new Random().Next(Options.Count())];
                if (optionToBeSelected.GetAttribute("value") != "") { return optionToBeSelected; }
            }
        }
    }
}
