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
       

        [TestMethod]
        public void TC01_PTB2_VoNghiem_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b,c va PTB2
            float a = 3;
            float b = 2;
            float c = 5;
            PT pt = new PT(a, b, c);

            //Gan VN vao expected
            List<String> expectedList_29_Nguyen_47_Tien = new List<string>() {"VN"};
            //Goi ham PTB2 de tinh actual
            List<String> actualList_29_Nguyen_47_Tien = pt.PTB2_29_Nguyen_47_Tien();
            //So sanh 2 list
            CollectionAssert.AreEqual(expectedList_29_Nguyen_47_Tien, actualList_29_Nguyen_47_Tien);
        }
        [TestMethod]
        public void TC02_PTB2_NghiemKep_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b,c va PTB2
            float a = 1;
            float b = -4;
            float c = 4;
            PT pt = new PT(a, b, c);

            //Gan 2 vao expected
            List<String> expectedList_29_Nguyen_47_Tien = new List<string>();
            expectedList_29_Nguyen_47_Tien.Add("2");
            //Goi ham PTB2 de tinh actual
            List<String> actualList_29_Nguyen_47_Tien = pt.PTB2_29_Nguyen_47_Tien();
            //So sanh 2 list
            CollectionAssert.AreEqual(expectedList_29_Nguyen_47_Tien, actualList_29_Nguyen_47_Tien);
        }
        [TestMethod]
        public void TC03_PTB2_Co2NghiemPhanbiet_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b,c va PTB2
            float a = 1;
            float b = -49;
            float c = -50;
            PT pt = new PT(a, b, c);

            //Gan [-1,50] vao expected
            List<String> expectedList_29_Nguyen_47_Tien = new List<string>();
            expectedList_29_Nguyen_47_Tien.Add("-1");
            expectedList_29_Nguyen_47_Tien.Add("50");
            //Goi ham PTB2 de tinh actual
            List<String> actualList_29_Nguyen_47_Tien = pt.PTB2_29_Nguyen_47_Tien();
            //So sanh 2 list
            CollectionAssert.AreEqual(expectedList_29_Nguyen_47_Tien, actualList_29_Nguyen_47_Tien);
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataPTB2.csv", "TestDataPTB2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void PTB2_CsvTest_29_Nguyen_47_Tien()
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
            List<String> expectedList_29_Nguyen_47_Tien = expectedGet.Split(';').ToList();

            //Khoi tao datatest
            PT pt = new PT(a, b, c);

            //Tinh datatest va lay ket qua actual
            List<String> actualList_29_Nguyen_47_Tien = pt.PTB2_29_Nguyen_47_Tien();

            //So sanh ket qua thuc te voi ket qua mong muon
            CollectionAssert.AreEqual(expectedList_29_Nguyen_47_Tien, actualList_29_Nguyen_47_Tien);
        }
    }
}
