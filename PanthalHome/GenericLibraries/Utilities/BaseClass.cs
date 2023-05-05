using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanthalHome.GenericLibraries.Utilities
{
    [TestClass]
    [TestCategory("BaseClass")]
    public  class BaseClass
    {
        public IWebDriver driver;

        public ExcelUtilities exUtil;
        public IWebDriverUtility wUtil;

        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            exUtil = new ExcelUtilities();
            wUtil = new IWebDriverUtility();

            wUtil.MaximizeWindow(driver);

            driver.Url = exUtil.Get_value_by_pasing_key("Login", "url");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

