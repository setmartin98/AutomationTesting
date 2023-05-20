using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1.Main
{
    public class CheckBox : BaseElements
    {
        public CheckBox(By locator, string name) : base(locator, name)
        {
        }
    }
}
