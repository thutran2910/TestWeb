using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFamipet_50_Thu
{
    [TestClass]
    public class DangNhap_50_Thu
    {
        //Khai báo biến driver để điều hướng truy cập vào trang web
        private IWebDriver driver = new ChromeDriver();
        public void VaoTrangWeb_50_Thu()
        {
            driver.Navigate().GoToUrl("https://famipet.vn/");
        }

        public void DangNhap(string email_50_Thu,string password_50_Thu)
        {
            //Truy cập vào trang web
            VaoTrangWeb_50_Thu();
            //Chờ 2s để load trang
            Thread.Sleep(2000);
            //Click nút đăng nhập
            driver.FindElement(By.LinkText("Đăng nhập")).Click();

            //Điền giá trị vào trường email và password tại trang web
            driver.FindElement(By.Id("customer_email")).SendKeys(email_50_Thu);
            driver.FindElement(By.Name("password")).SendKeys(password_50_Thu);

            //Click nút đăng nhập
            driver.FindElement(By.CssSelector("#customer_login > div.form-signup.clearfix > div > input")).Click();
            
        }
        //Khai báo TestContext để lấy dữ liệu từ file data
        public TestContext TestContext { get; set; }

        //Khai báo DataSource, dẫn đường dẫn đến file dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\Data_50_Thu\DNThanhCong_50_Thu.csv",
                    "DNThanhCong_50_Thu#csv", DataAccessMethod.Sequential)]


        //TestCase1: Đăng nhập thành công
        [TestMethod]
        public void TC1_DNThanhCong_50_Thu()
        {
            //Khai báo 2 biến email và password để nhận giá trị từ file dữ liệu
            string email_50_Thu = TestContext.DataRow[0].ToString();
            string password_50_Thu = TestContext.DataRow[1].ToString();

            //Gọi hàm Đăng nhập trên để bỏ giá trị từ file dữ liệu vào trang web
            DangNhap(email_50_Thu, password_50_Thu);

            //Khai báo biến username để lấy tên người dùng khi đăng nhập thành công
            string username_50_Thu = driver.FindElement(By.CssSelector("#a > div.form-signup.name-account.m992 > p > strong > a")).Text;
            //Kiểm tra xem tên người dùng có đúng như tên đã đăng kí không
            Assert.IsTrue(username_50_Thu.Contains("Trần Thư"));
        }

        //Khai báo DataSource, dẫn đường dẫn đến file dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\Data_50_Thu\DNSaiPassword_50_Thu.csv",
                    "DNSaiPassword_50_Thu#csv", DataAccessMethod.Sequential)]


        //TestCase2: Đăng nhập thất bại vì sai password
        [TestMethod]
        public void TC2_DNSaiPassword_50_Thu()
        {
            //Khai báo 2 biến email và password để nhận giá trị từ file dữ liệu
            string email_50_Thu = TestContext.DataRow[0].ToString();
            string password_50_Thu = TestContext.DataRow[1].ToString();

            //Gọi hàm Đăng nhập trên để bỏ giá trị từ file dữ liệu vào trang web
            DangNhap(email_50_Thu, password_50_Thu);

            //Khai báo biến actError để lấy thông báo lỗi khi sai Password
            string actError_50_Thu = driver.FindElement(By.CssSelector("#customer_login > div:nth-child(3)")).Text;
            //Kiểm tra xem câu thông báo lỗi có phải câu thông tin đăng nhập không chính xác không
            Assert.IsTrue(actError_50_Thu.Contains("Thông tin đăng nhập không chính xác"));

        }

        //Khai báo DataSource, dẫn đường dẫn đến file dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\Data_50_Thu\DNSaiEmail_50_Thu.csv",
                    "DNSaiEmail_50_Thu#csv", DataAccessMethod.Sequential)]
        

        //TestCase3 Đăng nhập thất bại vì sai email
        [TestMethod]
        public void TC3_DNSaiEmail_50_Thu()
        {
            //Khai báo 2 biến email và password để nhận giá trị từ file dữ liệu
            string email_50_Thu = TestContext.DataRow[0].ToString();
            string password_50_Thu = TestContext.DataRow[1].ToString();

            //Gọi hàm Đăng nhập trên để bỏ giá trị từ file dữ liệu vào trang web
            DangNhap(email_50_Thu, password_50_Thu);

            //Khai báo biến actError để lấy thông báo lỗi khi sai Password
            string actError_50_Thu = driver.FindElement(By.CssSelector("#customer_login > div:nth-child(3)")).Text;
            //Kiểm tra xem câu thông báo lỗi có phải câu thông tin đăng nhập không chính xác không
            Assert.IsTrue(actError_50_Thu.Contains("Thông tin đăng nhập không chính xác"));

        }

        //Khai báo DataSource, dẫn đường dẫn đến file dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\Data_50_Thu\DNSaiEmailPassword_50_Thu.csv",
                    "DNSaiEmailPassword_50_Thu#csv", DataAccessMethod.Sequential)]


        //TestCase4 Đăng nhập thất bại vì sai email và password
        [TestMethod]
        public void TC4_DNSaiEmailPassword_50_Thu()
        {
            //Khai báo 2 biến email và password để nhận giá trị từ file dữ liệu
            string email_50_Thu = TestContext.DataRow[0].ToString();
            string password_50_Thu = TestContext.DataRow[1].ToString();

            //Gọi hàm Đăng nhập trên để bỏ giá trị từ file dữ liệu vào trang web
            DangNhap(email_50_Thu, password_50_Thu);

            //Khai báo biến actError để lấy thông báo lỗi khi sai Password
            string actError_50_Thu = driver.FindElement(By.CssSelector("#customer_login > div:nth-child(3)")).Text;
            //Kiểm tra xem câu thông báo lỗi có phải câu thông tin đăng nhập không chính xác không
            Assert.IsTrue(actError_50_Thu.Contains("Thông tin đăng nhập không chính xác"));

        }
    }
}
