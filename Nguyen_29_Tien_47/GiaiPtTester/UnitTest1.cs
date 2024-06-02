using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Nguyen_29;
using System;

namespace GiaiPtTester
{
    [TestClass]
    public class UnitTest1
    {
        //Khai bao ham doc file csv
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataPTB1.csv", "TestDataPTB1#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void QuachKhaiNguyen_29_PTB1()
        {
            //Lay cac gia tri a,b tu file TestDataPTB1.csv
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());

            //Lay ket qua mong muon tu file csv
            String expected = TestContext.DataRow[2].ToString();

            //Khoi tao datatest, PTB1 chi can a,b nen khong can truyen c vao constructor
            PT pt = new PT(a, b);

            //Tinh datatest va lay ket qua thuc te
            String actual = pt.PTB1_KhaiNguyen_29();
            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual: " + actual);

            //So sanh ket qua thuc te voi ket qua mong muon
            Assert.AreEqual(expected, actual);
        }
    
    }
}
