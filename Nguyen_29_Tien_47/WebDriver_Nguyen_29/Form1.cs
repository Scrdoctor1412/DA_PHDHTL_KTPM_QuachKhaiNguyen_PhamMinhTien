using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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

namespace WebDriver_Nguyen_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TC01_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Random email 
            Random rnd = new Random();
            String randEmail = rnd.Next(1000) + "@gmail.com";

            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan register va dien vao email {random}@gmail.com
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("reg_email"));
            email.SendKeys(randEmail);
            Thread.Sleep(1000);

            //Tim textbox password o phan register va dien vao password A123456!%^&A
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("reg_password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut register 
            IWebElement resgBtn = driver_KhaiNguyen_29.FindElement(By.Name("register"));
            resgBtn.Click();
        }

        //Test case 2 chuc nang dang ky voi Email khong dung
        private void TC02_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan register va dien vao email khong dung dinh dang 
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("reg_email"));
            email.SendKeys("abc@g");
            Thread.Sleep(1000);

            //Tim textbox password o phan register va dien vao password A123456!%^&A
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("reg_password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut register va bat su kien click
            IWebElement resgBtn = driver_KhaiNguyen_29.FindElement(By.Name("register"));
            resgBtn.Click();
        }

        //Test case 3 chuc nang dang ky nhung bo trong Email
        private void TC03_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan register va bo trong  email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("reg_email"));
            email.SendKeys("");
            Thread.Sleep(1000);

            //Tim textbox password o phan register va dien vao password A123456!%^&A
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("reg_password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut register 
            IWebElement resgBtn = driver_KhaiNguyen_29.FindElement(By.Name("register"));
            resgBtn.Click();
        }

        //Test case 4 chuc nang dang ky nhung bo trong password
        private void TC04_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan register va dien vao email {random}@gmail.com
            Random rnd = new Random();
            String randEmail = rnd.Next(1000) + "@gmail.com";   //tao email random 
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("reg_email"));
            email.SendKeys(randEmail);
            Thread.Sleep(1000);

            //Tim textbox password o phan register va khong dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("reg_password"));
            password.SendKeys("");
            Thread.Sleep(1000);

            //Tim nut register 
            IWebElement resgBtn = driver_KhaiNguyen_29.FindElement(By.Name("register"));
            resgBtn.Click();
        }

        //Test case 5 chuc nang dang ky nhung bo trong email va password
        private void TC05_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan register va bo trong email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("reg_email"));
            email.SendKeys("");
            Thread.Sleep(1000);

            //Tim textbox password o phan register va bo trong password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("reg_password"));
            password.SendKeys("");
            Thread.Sleep(1000);

            //Tim nut register 
            IWebElement resgBtn = driver_KhaiNguyen_29.FindElement(By.Name("register"));
            resgBtn.Click();
        }

        private void TC01_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();
        }

        private void TC02_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim link orders bang XPath va bat su kien click
            IWebElement orders = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[2]/a"));
            orders.Click();
        }

        private void TC03_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim link orders bang XPath va bat su kien click
            IWebElement orders = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[2]/a"));
            orders.Click();

            //Tim nut view cua 1 order bang XPath
            IWebElement view = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/div/table/tbody/tr/td[5]/a"));
            view.Click();
        }

        private void TC04_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim link Addresses bang XPath va bat su kien click
            IWebElement addresses = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[4]/a"));
            addresses.Click();
        }

        private void TC05_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim link Addresses bang XPath va bat su kien click
            IWebElement addresses = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[4]/a"));
            addresses.Click();

            //Tim nut edit bang XPath va bat su kien click
            IWebElement edit = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/div/div/div[2]/header/a"));
            edit.Click();
        }

        private void TC06_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim link Account Details bang XPath va bat su kien click
            IWebElement account_details = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[5]/a"));
            account_details.Click();
        }

        private void TC07_MA_KhaiNguyen_29_Click(object sender, EventArgs e)
        {
            //Tat man hinh den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //dieu huong trinh duyet
            IWebDriver driver_KhaiNguyen_29 = new ChromeDriver(chrome);

            //gan url va dieu huong den url
            driver_KhaiNguyen_29.Url = "http://practice.automationtesting.in/";
            driver_KhaiNguyen_29.Navigate();

            //Tim menu MyAccount bang Xpath va bat su kien click
            IWebElement myAccount = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"menu-item-50\"]/a"));
            myAccount.Click();
            Thread.Sleep(1000);

            //Tim textbox email o phan login va dien vao email
            IWebElement email = driver_KhaiNguyen_29.FindElement(By.Id("username"));
            email.SendKeys("671@gmail.com");
            Thread.Sleep(1000);

            //Tim textbox password o phan login va dien vao password
            IWebElement password = driver_KhaiNguyen_29.FindElement(By.Id("password"));
            password.SendKeys("A123456!%^&A");
            Thread.Sleep(1000);

            //Tim nut login 
            IWebElement loginBtn = driver_KhaiNguyen_29.FindElement(By.Name("login"));
            loginBtn.Click();

            //Tim Logout bang XPath va bat su kien click
            IWebElement logout = driver_KhaiNguyen_29.FindElement(By.XPath("//*[@id=\"page-36\"]/div/div[1]/nav/ul/li[6]/a"));
            logout.Click();
        }
    }
}
