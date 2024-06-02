using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Nguyen_29;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiaiPtTester
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataPTB2.csv", "TestDataPTB2#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void QuachKhaiNguyen_29_PTB2()
        {
            //Lay cac gia tri a,b,c tu file TestDataPTB2.csv
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());

            //Lay expected tu file csv voi kieu du lieu mang
            String expectedGet = TestContext.DataRow[3].ToString();

            //Xu ly mang expected thanh dang chuoi co the su dung
            expectedGet = expectedGet.Replace(@"[", "");
            expectedGet = expectedGet.Replace(@"]", "");

            //Chuyen string expected thanh list
            List<String> expectedList = expectedGet.Split(';').ToList();

            //Khoi tao datatest
            PT pt = new PT(a, b, c);

            //Tinh datatest va lay ket qua actual
            List<String> actualList = pt.PTB2_KhaiNguyen_29();

            //So sanh ket qua thuc te voi ket qua mong muon
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
