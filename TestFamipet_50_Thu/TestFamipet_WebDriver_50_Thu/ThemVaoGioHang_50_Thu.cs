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
    public class ThemVaoGioHang_50_Thu
    {
        private IWebDriver driver = new ChromeDriver();
        public void VaoTrangWeb_50_Thu()
        {
            driver.Navigate().GoToUrl("https://famipet.vn/");
        }
        [TestMethod]
        public void KTThemVaoGioHang_50_Thu()
        {
            //Truy cập vào trang web
            VaoTrangWeb_50_Thu();
            //Chờ 2s
            Thread.Sleep(2000);
            //Tìm kiếm với từ khóa thức ăn
            driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div/div/div[3]/div/" +
                "div/form/input")).SendKeys("thức ăn");
            //Click icon tìm kiếm
            driver.FindElement(By.ClassName("btn")).Click();

            //Chờ 2s
            Thread.Sleep(2000);
            //Chọn vào một món đồ
            driver.FindElement(By.XPath("/html/body/section[2]/div/div/div[3]/div/div/div[5]/d" +
                "iv/div/div[2]/div[3]/form/div/button")).Click();
            //Chờ 2s
            Thread.Sleep(2000);
            //Mở giỏ hàng để kiểm tra
            driver.FindElement(By.CssSelector("#popup-cart-desktop > div.wrap_popup > div.ti" +
                "tle-quantity-popup > span")).Click();
        }
    }
}
