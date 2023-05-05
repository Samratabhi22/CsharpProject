using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanthalHome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("DataDriven")]
        [Priority(1)]
        [DataTestMethod]
        [DataRow("https://www.facebook.com/", "Facebook")]
        [DataRow("https://medium.com/", "Medium")]
        [DataRow("https://www.bbc.com/", "BBC")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            try
            {
                Assert.IsTrue(aTitle.Contains(eTitle));
            }
            catch (Exception e)
            {
                Console.WriteLine(eTitle + " title not matching");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
                Assert.IsTrue(aTitle.Contains(eTitle));
            }

        }
    }
    [TestClass]
    public class UnitTest2
    {
        public static IEnumerable<object[]> Tests
        {
            get
            {
                return new[]
                {
                    new object[] {1,1,2},
                    new object[] {1,3,3},
                    new object[] {2,2,4},
                };
            }

        }

        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(Tests))]
        public void TestMethod(int a, int b, int c)
        {
            int multiply = a * b;
            bool result = false;

            if (multiply == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "result not matching");
            // MessageBox.Show(" " + c);
        }


    }
    [TestClass]
    public class UnitTest3
    {

        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(Tests), DynamicDataSourceType.Property)]
        public void TestMethod(int a, int b, int c)
        {
            int multiply = a * b;
            bool result = false;

            if (multiply == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "result not matching");
        }




        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(numberData), DynamicDataSourceType.Method)]
        public void UsingMethodDynamicTestDataMethod(int a, int b, int c)
        {
            int multiply = a + b;
            bool result = false;

            if (multiply == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "result not matching");

        }


        public static IEnumerable<object[]> numberData()
        {

            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
        }

        public static IEnumerable<object[]> Tests()
        {

            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
        }



    }
}
