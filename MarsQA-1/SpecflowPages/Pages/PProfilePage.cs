﻿using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class PProfilePage
    {
        
        public IWebElement ProfTab => Driver.driver.FindElement(By.LinkText("Profile"));
        public IWebElement Namedrpdwn => Driver.driver.FindElement(By.CssSelector("div[class='title'] i[class='dropdown icon']"));
        public IWebElement Lastname => Driver.driver.FindElement(By.Name("lastName"));
        public IWebElement FirstName => Driver.driver.FindElement(By.Name("firstName"));
        public IWebElement SavName => Driver.driver.FindElement(By.CssSelector("button[class='ui teal button']"));
        public IWebElement Availtimeicon => Driver.driver.FindElement(By.XPath("//span[normalize-space()='Part Time']//i[@class='right floated outline small write icon']"));
        public IWebElement Availhouricon => Driver.driver.FindElement(By.XPath("//span[normalize-space()='Less than 30hours a week']//i[@class='right floated outline small write icon']"));
        public IWebElement AvailTargicon => Driver.driver.FindElement(By.XPath("//span[normalize-space()='Less than $500 per month']//i[@class='right floated outline small write icon']"));
        public IWebElement AvailTargetClose => Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//div[4]//div[1]//span[1]//i[1]"));
        public IWebElement AvailDesicon => Driver.driver.FindElement(By.CssSelector("h3[class='ui dividing header'] i[class='outline write icon']"));
        public IWebElement Descriptiontxt => Driver.driver.FindElement(By.Name("value"));
        public IWebElement BtnDesSave => Driver.driver.FindElement(By.CssSelector("button[type='button']"));
        public void ClickProTab()
        {
            ProfTab.Click();
        }
        public void NameUpdate(string firstName, string lastName)
        {
            Namedrpdwn.Click();
            FirstName.SendKeys(firstName);
            Lastname.SendKeys(lastName);
            SavName.Click();
            Thread.Sleep(5000);
        }
        public void AvailabiTimeLnk()
        {
            Thread.Sleep(3000);
            Availtimeicon.Click();
            var Worktype = Driver.driver.FindElement(By.Name("availabiltyType"));
            var selectElementh = new SelectElement(Worktype);
            selectElementh.SelectByValue("0");
            Thread.Sleep(5000);
        }
        public void AvailabiHourLnk()
        {
            Availhouricon.Click();
            var Workhour = Driver.driver.FindElement(By.Name("availabiltyHour"));
            var selectElementh = new SelectElement(Workhour);
            selectElementh.SelectByValue("0");
            Thread.Sleep(5000);
        }
        public void AvailabiTargetLnk()
        {
            AvailTargicon.Click();
            var Target = Driver.driver.FindElement(By.Name("availabiltyTarget"));
            var selectElementt = new SelectElement(Target);
            selectElementt.SelectByValue("0");
            Thread.Sleep(5000);
        }
        public void AvailabiDesLnk()
        {
            AvailDesicon.Click();
            Thread.Sleep(1000);
            Descriptiontxt.SendKeys(Keys.Control + "a");
            Descriptiontxt.SendKeys(Keys.Delete);
            Descriptiontxt.SendKeys("Please add some txt here");
            BtnDesSave.Click();
        }
    }
}
    

