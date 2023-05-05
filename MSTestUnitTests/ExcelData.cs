using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;



namespace MSTestUnitExcelTests
{
    [TestClass]
    public class ExcelData
    {
        //to access the excell path and sheet name for multiple testmethods I am using them outside the method and inside the class

        public static string fPath = "C:\\Users\\Hp\\Desktop\\CSharpExcelData.xlsx";
            //file path of excel file in loacal pc
        public static string sname = "Sheet1";//sheet name of excel where data is present

        //fetching the data from the excell and returning it to another method        

        public static IEnumerable<Object[]> dataprovide()
        {
            //create a object for the spreadsheet
            Spreadsheet sp = new Spreadsheet();

            //load the excell to that spreadsheet instance
            sp.LoadFromFile(fPath);

            //by using 'WORKBOOK' and 'WORKSHEET' property and 'BYNAME' method I am opening the particuler sheet 
            Worksheet book = sp.Workbook.Worksheets.ByName(sname);
            //to fetch the last used row num
            int lrow = book.UsedRangeRowMax;

            //to fetch the last used cel num
            int lcol = book.UsedRangeColumnMax;

            for (int i = 0; i <= lrow; i++)
            {
                for (int j = 0; j <= lcol; j++)
                {
                    string key = sp.Workbook.Worksheets.ByName(sname).Cell(i, j).ToString();
                    yield return new object[] { key };
                }


            }
        }





        public static IEnumerable<Object[]> dataprovidebykeyandvalue()
        {
            Spreadsheet sp = new Spreadsheet();
            sp.LoadFromFile(fPath);
            Worksheet book = sp.Workbook.Worksheets.ByName(sname);
            int lrow = book.UsedRangeRowMax;


            for (int i = 0; i <= lrow; i++)
            {
                string key = sp.Workbook.Worksheets.ByName(sname).Cell(i, 0).ToString();
                string value = sp.Workbook.Worksheets.ByName(sname).Cell(i, 1).ToString();
                yield return new object[] { key, value };
            }
        }

        //here am grouping this test method 
        [TestCategory("DataDrivenassignment1")]
        [TestMethod]
        //by using DynamicData anotation am fetching the method from where am reacieving the data 
        [DynamicData(nameof(dataprovide), DynamicDataSourceType.Method)]

        //using string paramater am recieving the data
        public void TestMethod1(String data)
        {
          Console.WriteLine(data);
           // MessageBox.Show(data);
        }





        [TestCategory("DataDrivenassignment2")]
        [TestMethod]
       [DynamicData(nameof(dataprovidebykeyandvalue), DynamicDataSourceType.Method)]
        public void TestMethod2(String key, string value)
        {
            Console.WriteLine(key + " " + value);
           // MessageBox.Show(key + " " + value);
        }
    }

}

