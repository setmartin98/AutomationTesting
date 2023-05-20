using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1.Main
{
    public class TextBox : BaseElements
    {
        
        public TextBox(By locator, string name) : base(locator, name)
        {
        }
        public void type(string text)
        {
            waits.WaitFor(uniqueLocator).SendKeys(text);
        }
        public void clear() 
        {
            driver.FindElement(uniqueLocator).Clear();
        }
    }
}
