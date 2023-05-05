using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PanthalHome.GenericLibraries.Utilities;
using PanthalHome.ObjectRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PanthalHome.Tests
{
    [TestClass]
    [TestCategory("scripts")]
    public  class LoginPageTest :BaseClass
    {
        IWebDriver driver;
        LoginPage loginpageelements;
        IWebDriverUtility webDriverUtilities;

       // [TestMethod]
       // [TestCategory("LoginPage")]
        
      //  public void Logintest()
       // {
          //  webDriverUtilities.ImplicitlyWaitingForSeconds(driver, 10);
          //  Console.WriteLine("waiting condition");
           // String url = ExcelUtilities.ReadSingleExceldata("Login", 0, 1);
           // driver.Navigate().GoToUrl(url);
           // String un = ExcelUtilities.ReadSingleExceldata("Login", 1, 1);
          //  String pw = ExcelUtilities.ReadSingleExceldata("Login", 1, 2);

          //  loginpageelements.Login(un, pw);
       // }
      //  public void TestInitializeMethod()
       // {
          //  driver = new ChromeDriver();
          //  webDriverUtilities = new IWebDriverUtility();
          //  loginpageelements=new LoginPage(driver); 
            


       // }
        
        [TestMethod]
        [TestCategory("Regression")]
        public void Script1()
        {
            String un = exUtil.Get_value_by_pasing_key("Login", "username");
            String psw = exUtil.Get_value_by_pasing_key("Login", "password");
            Console.WriteLine(un +" "+psw);

            LoginPage lp = new LoginPage(driver);
            lp.LoginApp(un, psw);

        }





    }
}
