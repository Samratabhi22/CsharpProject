using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PanthalHome.GenericLibraries.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PanthalHome.ObjectRepo
{
    public class LoginPage
    {
        private IWebDriver driver;
        public ExcelUtilities exUtil;

        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement usernameInput;

        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement loginButton;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginApp(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            loginButton.Click();
            String actTitle = driver.Title;
            String expTitle = exUtil.Get_value_by_pasing_key("Login", "expectedTitle"); 
            Assert.AreEqual(actTitle, expTitle);    


        }
    }
}
