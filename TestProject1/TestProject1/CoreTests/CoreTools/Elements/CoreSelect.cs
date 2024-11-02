using AutomationCore.CoreTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ThreeNineTests.CoreTests.CoreTools.Elements
{
    public class CoreSelect: SelectElement
    {
        IWebDriver driver;
        public CoreSelect(IWebElement element):base(element) {
            
        }
        public string SelectByText(string text)
        {
            if (text == "//ComandAny//")
            {
                var optionToBeSelected = Options[new Random().Next(Options.Count())];
                base.SelectByText(optionToBeSelected.Text);
                return optionToBeSelected.Text;
            }
            else { base.SelectByText(text); }

            return SelectedOption.Text;
        }

        public string SafeSelectByText(string text, int wait)
        {
           if (text == "//ComandAny//") 
           {
                Wait.UntilTrue(() => {
                SelectByText(text);
                return SelectedOption.Selected;
                }, TimeSpan.FromSeconds(wait));
           }
           else
           {
               Wait.UntilTrue(() => {
               SelectByText(text);
               return SelectedOption.Text.Equals(text);
               }, TimeSpan.FromSeconds(wait));
           }

            return SelectedOption.Text;
        }
    }
}
