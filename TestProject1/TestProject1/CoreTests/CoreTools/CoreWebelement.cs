using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNineTests.CoreTests.CoreTools
{
    public class CoreWebelement: WebElement
    {
        WebElement? parentFrame;

        public CoreWebelement(WebDriver parentDriver, string id, WebElement? parentFrame = null):base(parentDriver, id) {
            this.parentFrame = parentFrame;

 }


    }
}
