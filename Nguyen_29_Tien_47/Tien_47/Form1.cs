using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Tien_47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tắt màn hình đen
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(chrome);
            string url = "https://www.google.com/";
            txtUrl.Text = url;
            driver.Navigate().GoToUrl(url);



            //chức năng mua hàng
            //tìm, click  vao trang web
            Thread.Sleep(2000);
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("https://practice.automationtesting.in/");
            Thread.Sleep(2000);
            searchBox.Submit();
            Thread.Sleep(5000);
            IWebElement click = driver.FindElement(By.ClassName("q0vns"));
            click.Click();

            // click vào shop
            Thread.Sleep(5000);
            IWebElement clickLink = driver.FindElement(By.Id("menu-item-40"));
            clickLink.Click();

            // click add to carr
            Thread.Sleep(5000);
            IWebElement clickAddToCart = driver.FindElement(By.ClassName("add_to_cart_button"));
            clickAddToCart.Click();

            //click vào cart
            Thread.Sleep(3000);
            IWebElement clickCart = driver.FindElement(By.ClassName("cartcontents"));
            clickCart.Click();

            //điền quantity len thành 3
            Thread.Sleep(3000);
            IWebElement clickQuantity = driver.FindElement(By.ClassName("input-text"));
            clickQuantity.Clear();
            clickQuantity.SendKeys("3");

            //update basket
            Thread.Sleep(1000);
            IWebElement clickUpdate = driver.FindElement(By.Name("update_cart"));
            clickUpdate.Click();

            //checkout
            Thread.Sleep(7000);
            IWebElement clickCheckout = driver.FindElement(By.ClassName("wc-forward"));
            clickCheckout.Click();

            //điền thông tin
            /*Thread.Sleep(2000);
            IWebElement clickLogin = driver.FindElement(By.ClassName("showlogin"));
            clickLogin.Click();
            Thread.Sleep(2000);
            IWebElement inputName = driver.FindElement(By.Id("username"));
            inputName.SendKeys("pham");
            Thread.Sleep(2000);
            IWebElement inputPw = driver.FindElement(By.Id("password"));
            inputPw.SendKeys("phamminhtien");
            Thread.Sleep(2000);
            IWebElement clickLG = driver.FindElement(By.Name("login"));
            Thread.Sleep(2000);
            clickLG.Click();*/
            Thread.Sleep(2000);
            IWebElement inputFName = driver.FindElement(By.Id("billing_first_name"));
            inputFName.SendKeys("PHAM");
            Thread.Sleep(2000);
            IWebElement inputLName = driver.FindElement(By.Id("billing_last_name"));
            inputLName.SendKeys("MINH TIEN");
            Thread.Sleep(2000);
            IWebElement inputCompany = driver.FindElement(By.Id("billing_company"));
            inputCompany.SendKeys("NOT YET");
            Thread.Sleep(2000);
            IWebElement inputEmail = driver.FindElement(By.Id("billing_email"));
            inputEmail.SendKeys("tienn@gmail.com");
            Thread.Sleep(2000);
            IWebElement inputPhone = driver.FindElement(By.Id("billing_phone"));
            inputPhone.SendKeys("0123456789");
            Thread.Sleep(2000);
            IWebElement inputAddress = driver.FindElement(By.Id("billing_address_1"));
            inputAddress.SendKeys("11 XÔ VIẾT NGHỆ TĨNH");
            Thread.Sleep(2000);
            IWebElement inputcity = driver.FindElement(By.Id("billing_city"));
            inputcity.SendKeys("TP.HCM");
            Thread.Sleep(2000);
            IWebElement inputZip = driver.FindElement(By.Id("billing_postcode"));
            inputZip.SendKeys("70000");
            /*Thread.Sleep(2000);
            IWebElement clickAccout = driver.FindElement(By.Name("createaccount"));
            clickAccout.Click();
            Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.Name("account_password"));
            inputPassword.SendKeys("phamminhtien");*/
            Thread.Sleep(5000);
            IWebElement clickPlaceOder = driver.FindElement(By.Id("place_order"));
            clickPlaceOder.Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tắt màn hình đen
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            //chức năng tìm kiếm
            IWebDriver driver = new ChromeDriver(chrome);
            string urL = "https://www.google.com/";
            txtsearch.Text = urL;
            driver.Navigate().GoToUrl(urL);
            //chức năng mua hàng
            Thread.Sleep(2000);
            IWebElement search = driver.FindElement(By.Name("q"));
            search.SendKeys("https://practice.automationtesting.in/");
            Thread.Sleep(2000);
            search.Submit();
            Thread.Sleep(5000);
            IWebElement click = driver.FindElement(By.ClassName("q0vns"));
            click.Click();
            // click vào shop
            Thread.Sleep(2000);
            IWebElement clickLink = driver.FindElement(By.Id("menu-item-40"));
            clickLink.Click();

            //click vào filter by price
            IWebElement sliderHandle1 = driver.FindElement(By.CssSelector(".ui-slider-handle:nth-of-type(1)"));
            sliderHandle1.Click(); //nhấn vào thanh sliderHandle1
            Actions builder = new Actions(driver);
            //Đối tượng bulder cho phép thực hiện thao tác  kéo và thả
            builder.DragAndDropToOffset(sliderHandle1, 150, 0).Perform();
            //Tạo một hành động kéo và thả lệch 150px theo trục x và 0 theo trục y

            Thread.Sleep(2000);
            IWebElement clickFilter = driver.FindElement(By.CssSelector("button[type='submit']"));
            clickFilter.Click();
        }
    }
}
