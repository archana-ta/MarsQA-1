﻿using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys("archanapatil002@gmail.com");
            Password.SendKeys("Indeed@123");

            //Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            // Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }
        public static void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("archanapatil002@gmail.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Indeed@123");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}