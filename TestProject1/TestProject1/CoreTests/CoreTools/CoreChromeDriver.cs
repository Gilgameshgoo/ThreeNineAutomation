using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ThreeNineTests.CoreTests.CoreTools.Elements;

namespace ThreeNineTests.CoreTests.CoreTools
{
    public class CoreChromeDriver: ChromeDriver
    {
        public IWebElement FindElementInFrame(By by, IWebElement frame)
        {
            SwitchTo().Frame(frame);
            var element = FindElement(by);
            return element;
        }

        public CoreWebelement FindElement(By by)
        {
            var element = base.FindElement(by);

            //return new CoreWebelement(this, element.GetAttribute("id"));

            var f =element.GetDomAttribute("ID");
            var fg = element.GetDomProperty("ID");
           
               
            return (CoreWebelement) element;
        }

        public bool SwitchToWindowByTitle(string title)
        {
            foreach (string handle in WindowHandles)
            {
                // Switch to the window
                SwitchTo().Window(handle);

                // Get the title of the current window
                string currentTitle = Title;

                if(currentTitle == title) {return true;}
                
            }
            throw new NoSuchWindowException();  
        }

        public int GetNumberofWindowsByTitle(string title)
        {
            int windowsCount = 0;
            foreach (string handle in WindowHandles)
            {
                // Switch to the window
                SwitchTo().Window(handle);

                // Get the title of the current window
                string currentTitle = Title;

                if (currentTitle == title) { windowsCount++; }

            }
            return windowsCount;
        }
    }
}
