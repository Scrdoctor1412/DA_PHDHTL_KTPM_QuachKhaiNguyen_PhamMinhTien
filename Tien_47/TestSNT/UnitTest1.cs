using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tien_47_Nunit;

namespace TestSNT
{
    [TestClass]
    public class UnitTest1
    {
    public TestContext TestContext { get; set; }
    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\soNT.csv", "soNT#csv", DataAccessMethod.Sequential)]
    [TestMethod]
    // [ExpectedException(typeof(ArgumentException), "Invalid Data")]
    public void testSNTCSV()
    {
        int n = int.Parse(TestContext.DataRow[0].ToString()); //Chuyển dữ liệu của cột đầu tiên mà nó đọc được thành kiểu dữ liệu int.

        soNguyenTo snt = new soNguyenTo(); //khởi tạo đối tượng snt
        bool expected = bool.Parse(TestContext.DataRow[1].ToString()); //Chuyển dữ liệu của cột thứ hai mà nó đọc được thành kiểu dữ liệu bool.

        bool actual = snt.soNT(n);//gọi phương thức soNT của đối tượng snt
        Assert.AreEqual(expected, actual); //hàm so sánh kết quả mong đợi với kết quả thực tế.

    }
    [TestMethod]
    public void testSNT()
    {
        int n = 5;
        soNguyenTo snt = new soNguyenTo(); //khởi tạo đối tượng snt
        bool actual = snt.soNT(n); //gọi phương thức soNT của đối tượng snt
        Assert.IsTrue(actual); //hàm kiểm tra true
    }
    [TestMethod]
    public void testSNTF()
    {
        int n = -4;
        soNguyenTo snt = new soNguyenTo();
        bool actual = snt.soNT(n);
        Assert.IsFalse(actual);
    }

}
}
