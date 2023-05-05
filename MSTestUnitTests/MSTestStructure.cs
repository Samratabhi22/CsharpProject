using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestUnitTests
{
    [TestClass]
    [TestCategory("Practice")]
    internal class MSTestStructure
    {
        IWebDriver driver;

        /*  [ClassInitialize]
          public void open_browser()
          {
              driver = new ChromeDriver();
              driver.Manage().Window.Maximize();
              Console.WriteLine("****browser opened****");
          }
          [ClassCleanup]
          public void close_browser()
          {
              driver.Dispose();
              Console.WriteLine("****browser lost the connection****");
          }

          [TestInitialize] 
          public void Init()
          {
              driver = new ChromeDriver();
              driver.Manage().Window.Maximize();
              driver.Url = "https://in.indeed.com/";
              Console.WriteLine("***application opened***");
          }
          [TestCleanup]
          public void Cleanup()
          {
              driver.Quit();
              Console.WriteLine("***apllication closed***");
          }
        */
        [Priority(-1)]
        [TestMethod]
        public void TestMethod1()
        {
            System.Console.WriteLine("***Method 1***");
        }
        [Priority(2)]
        [TestMethod]
        public void TestMethod2()
        {
            System.Console.WriteLine("***Method 2***");
        }
        [Priority(1)]
        [TestMethod]
        public void TestMethod3()
        {
            System.Console.WriteLine("***Method 3***");
        }
    }
}
