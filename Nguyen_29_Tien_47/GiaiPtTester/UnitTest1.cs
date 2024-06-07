using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Nguyen_29;
using System;

namespace GiaiPtTester
{
    [TestClass]
    public class UnitTest1
    {
        //Khai bao ham doc file csv
        

        [TestMethod]
        public void TC01_PTB1_VoSoNghiem_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b va PTB1
            float a = 0;
            float b = 0;
            PT pt = new PT(a, b);

            //Gan expected
            String expected_29_Nguyen_47_Tien = "VSN";

            //Goi gam tinh PTB1 va gan vao a,b
            String actual_29_Nguyen_47_Tien = pt.PTB1_29_Nguyen_47_Tien();
            Assert.AreEqual(expected_29_Nguyen_47_Tien, actual_29_Nguyen_47_Tien);
        }

        [TestMethod]
        public void TC02_PTB1_VoNghiem_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b va PTB1
            float a = 0;
            float b = 2;
            PT pt = new PT(a, b);

            //Gan expected
            String expected_29_Nguyen_47_Tien = "VN";

            //Goi gam tinh PTB1 va gan vao a,b
            String actual_29_Nguyen_47_Tien = pt.PTB1_29_Nguyen_47_Tien();
            Assert.AreEqual(expected_29_Nguyen_47_Tien, actual_29_Nguyen_47_Tien);
        }
        [TestMethod]
        public void TC03_PTB1_CoNghiem_29_Nguyen_47_Tien()
        {
            //Khoi tao a,b va PTB1
            float a = -5;
            float b = -5;
            PT pt = new PT(a, b);

            //Gan expected
            String expected_29_Nguyen_47_Tien = "-1";

            //Goi gam tinh PTB1 va gan vao a,b
            String actual_29_Nguyen_47_Tien = pt.PTB1_29_Nguyen_47_Tien();
            Assert.AreEqual(expected_29_Nguyen_47_Tien, actual_29_Nguyen_47_Tien);
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataPTB1.csv", "TestDataPTB1#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void PTB1_CsvTest_29_Nguyen_47_Tien()
        {
            //Lay cac gia tri a,b tu file TestDataPTB1.csv
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());

            //Lay ket qua mong muon tu file csv
            String expected_29_Nguyen_47_Tien = TestContext.DataRow[2].ToString();

            //Khoi tao datatest, PTB1 chi can a,b nen khong can truyen c vao constructor
            PT pt = new PT(a, b);

            //Tinh datatest va lay ket qua thuc te
            String actual_29_Nguyen_47_Tien = pt.PTB1_29_Nguyen_47_Tien();
            Console.WriteLine("Expected: " + expected_29_Nguyen_47_Tien);
            Console.WriteLine("Actual: " + actual_29_Nguyen_47_Tien);

            //So sanh ket qua thuc te voi ket qua mong muon
            Assert.AreEqual(expected_29_Nguyen_47_Tien, actual_29_Nguyen_47_Tien);
        }
    
    }
}
