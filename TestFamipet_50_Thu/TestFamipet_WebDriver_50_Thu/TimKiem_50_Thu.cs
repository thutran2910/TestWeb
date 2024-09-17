using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFamipet_WebDriver_50_Thu
{
    [TestClass]
    public class TimKiem_50_Thu
    {
        private IWebDriver driver = new ChromeDriver();
        public void VaoTrangWeb_50_Thu()
        {
            driver.Navigate().GoToUrl("https://famipet.vn/");
        }

        //Testcase 1: Tìm kiếm thành công có kết quả trả về
        [TestMethod]
        public void TC1_TimKiemThanhCong_50_Thu()
        {
            //Gọi hàm để vào trang web
            VaoTrangWeb_50_Thu();
            //chờ 2s
            Thread.Sleep(200);
            //Điền vào ô tìm kiếm giá trị là "đồ chơi"
            driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div/div/div[3]/" +
                                "div/div/form/input")).SendKeys("đồ chơi");
            // Click nút tìm kiếm
            driver.FindElement(By.ClassName("btn")).Click();
        }

        //Testcase 2: Tìm kiếm thất bại do không tồn tại món hàng muốn tìm
        [TestMethod]
        public void TC2_TimKiemThatBai_50_Thu()
        {
            //Gọi hàm để vào trang web
            VaoTrangWeb_50_Thu();
            //chờ 2s
            Thread.Sleep(200);
            //Điền vào ô tìm kiếm một giá trị ngẫu nhiên là "gamai"
            driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div/div/div[3]/" +
                                "div/div/form/input")).SendKeys("gamai");
            // Click nút tìm kiếm
            driver.FindElement(By.ClassName("btn")).Click();
        }
    }

}