using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace PanthalHome.GenericLibraries.Utilities
{
    public class IWebDriverUtility
    {
        public void ImplicitlyWaitingForSeconds(IWebDriver driver, int seconds)

        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
        public void ExplicitlyWaitingTillTitleContains(IWebDriver driver, int seconds, string titleContains)
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            webDriverWait.Until(ExpectedConditions.TitleContains(titleContains));


        }
        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
    }
}
