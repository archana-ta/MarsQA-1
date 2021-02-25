using MarsQA_1.Feature;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language
    {
        IWebDriver driver;

        private static IWebElement addnew => Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[1]"));
        private static IWebElement addlanguage => Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[4]"));
        private static IWebElement languagelevel => Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui dropdown')]"));
        
        private static IWebElement addbutton => Driver.driver.FindElement(By.XPath("(//input[contains(@type,'button')])[1]"));

        public static void AddlanguageSteps()
        {
            Driver.NavigateUrl();
            Login login = new Login();
            addnew.Click();
            addlanguage.SendKeys("English");
            SelectElement eselect = new SelectElement(languagelevel);
            eselect.SelectByIndex(2);
            addbutton.Click();

        }
        public static void AddLanguage()
        {
            Driver.NavigateUrl();

            //Enter add new
            Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[1]")).Click();

            //Enter language
            Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[4]")).SendKeys("English");

            //select language level
            SelectElement eselect = new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui dropdown')]")));
            eselect.SelectByIndex(2);

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("(//input[contains(@type,'button')])[1]")).Click();
        }

        
        
        
        

        
        
           
        

       

    }
}
