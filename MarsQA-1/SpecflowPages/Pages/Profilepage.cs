using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Profilepage
    {
        
        private static IWebElement profile => Driver.driver.FindElement(By.XPath("(//a[contains(@class,'item')])[10]"));
        //By profile = By.XPath("(//a[contains(@class,'item')])[10]");

    
    public static void Profile()
    {
            Driver.NavigateUrl();
            Driver.driver.FindElement(By.XPath("(//a[contains(@class,'item')])[10]")).Click();

        }
        
            
        

    }
}
