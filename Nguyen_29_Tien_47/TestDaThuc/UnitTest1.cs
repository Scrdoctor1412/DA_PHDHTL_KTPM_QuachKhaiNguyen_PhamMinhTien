using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Tien_47_Nunit;

namespace TestDaThuc
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { set; get; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataDequy.csv", "TestDataDequy#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void testCSV()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            //Lấy giá trị đầu tiên từ hàng dữ liệu hiện tại và chuyển đổi nó thành kiểu double
            int n = int.Parse(TestContext.DataRow[1].ToString());
            //Lấy giá trị thứ hai từ hàng dữ liệu hiện tại và chuyển đổi nó thành kiểu int
            string arrString = TestContext.DataRow[2].ToString().Trim().Trim('\'', '{', '}');
            //Lấy giá trị thứ ba từ hàng dữ liệu hiện tại và chuyển đổi nó thành chuỗi,
            //bỏ các ký tự dấu nháy đơn, dấu ngoặc nhọn, và khoảng trắng ở hai đầu chuỗi.
            List<int> arr = arrString.Split(' ').Select(int.Parse).ToList();
            //Chia chuỗi arrString thành các phần tử con dựa trên dấu cách
            //sau đó chuyển đổi từng phần tử con thành số nguyên và lưu vào danh sách List<int>.
            double result = double.Parse(TestContext.DataRow[3].ToString());
            //Lấy giá trị thứ tư từ hàng dữ liệu hiện tại và chuyển đổi nó thành kiểu double
            poly c = new poly(n, arr);
            double actual = c.Cal(x);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void testBai3()
        {

            List<int> list = new List<int> { 1, -3, 2 };//tạo 1 danh sách đại diện cho hệ số của đa thức
            poly c = new poly(2, list); //tạo 1 đối tượng c với bậc của đa thức = 2
            double expexted = 21;
            double actual = c.Cal(4); //gọi phương thức Cal với đối số là 4
            Assert.AreEqual(expexted, actual);

        }
        public void TestInput()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 0, 2 }; // x^2 + 1
            int x = 3;
            double expected = 19; // 1 + 0*3 + 2*3^2 = 1 + 0 + 18 = 19
            poly p = new poly(n, a);
            double result = p.Cal(x);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid Data")]
        public void TestNAm()
        {
            int n = -1;
            List<int> a = new List<int> { 1 };
            poly p = new poly(n, a);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid Data")]
        // TestNotEnoughCoefficients: Kiểm tra khi số lượng hệ số không đủ.
        public void TestNotEnoughCoefficients()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 0 };
            poly p = new poly(n, a);
        }




        [TestMethod]
        // TestZero: Kiểm tra với đa thức bậc 0 có hệ số 0.
        public void TestZero()
        {
            int n = 0;
            List<int> heso = new List<int> { 0 }; // 0
            int x = 3;
            double expected = 0; // 0 * 3^0 = 0
            poly p = new poly(n, heso);
            double result = p.Cal(x);
            Assert.AreEqual(expected, result);
        }







        [TestMethod]
        // TestC: Kiểm tra với đa thức hằng số.
        public void TestConstant()
        {
            int n = 0;
            List<int> heso = new List<int> { 5 }; // 5
            int x = 3;
            double expected = 5; // 5 * 3^0 = 5
            poly p = new poly(n, heso);
            double result = p.Cal(x);
            Assert.AreEqual(expected, result);
        }
    }
}
