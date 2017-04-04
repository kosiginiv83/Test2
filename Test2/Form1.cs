using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test2
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Открыть
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
            Browser.Navigate().GoToUrl("http://blog.csssr.ru/qa-engineer/");
            

            //Browser.Navigate().GoToUrl("https://google.com");
            //Browser.Manage().Window.Maximize();
        }

        private void button2_Click(object sender, EventArgs e) //Поехали
        {
            IWebElement[] el = new IWebElement[4];
            /*el[3] = Browser.FindElement(By.CssSelector("div.graphs-errors a"));
            el[2] = Browser.FindElement(By.CssSelector("div.graphs-support a"));
            el[1] = Browser.FindElement(By.CssSelector("div.graphs-details a"));
            el[0] = Browser.FindElement(By.CssSelector("div.graphs-files a"));*/

            /*el[0] = Browser.FindElement(By.ClassName("graphs-details"));
            el[1] = Browser.FindElement(By.ClassName("graphs-errors"));
            el[2] = Browser.FindElement(By.ClassName("graphs-support"));
            el[3] = Browser.FindElement(By.ClassName("graphs-files"));*/

            el[0] = Browser.FindElement(By.PartialLinkText("СОПРОВ")); el[0].Click();
            el[1] = Browser.FindElement(By.PartialLinkText("ВНИК")); el[1].Click();
            el[2] = Browser.FindElement(By.PartialLinkText("НАХ")); el[2].Click();
            el[3] = Browser.FindElement(By.PartialLinkText("ФАЙЛ")); el[3].Click();

            for (int i=0; i==100; i++) {
                for (int z=0; z<4; z++) {
                    el[z].Click();
                    //System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //Выход
        {
            //Application.Exit();
            IWebElement element;
            //element = Browser.FindElement(By.PartialLinkText("НАХОДИТЬ"));
            //element = Browser.FindElement(By.PartialLinkText("vk.com"));


            element = Browser.FindElement(By.PartialLinkText("СОПРОВ")); element.Click();
            
            
            /*element = Browser.FindElement(By.CssSelector("div.graphs-errors a"));
            element.Click();
            System.Threading.Thread.Sleep(1000);
            element = Browser.FindElement(By.CssSelector("div.graphs-support a"));
            element.Click();
            System.Threading.Thread.Sleep(1000);
            element = Browser.FindElement(By.CssSelector("div.graphs-details a"));
            element.Click();
            System.Threading.Thread.Sleep(1000);
            element = Browser.FindElement(By.CssSelector("div.graphs-files a"));
            element.Click();
            System.Threading.Thread.Sleep(1000);*/
        }
    }
}
