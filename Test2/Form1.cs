﻿using System;
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

            
            //IWebElement[] el = new IWebElement[4];
            //IWebElement element;
            /*el[3] = Browser.FindElement(By.CssSelector("div.graphs-errors a"));
            el[2] = Browser.FindElement(By.CssSelector("div.graphs-support a"));
            el[1] = Browser.FindElement(By.CssSelector("div.graphs-details a"));
            el[0] = Browser.FindElement(By.CssSelector("div.graphs-files a"));*/

            /*el[0] = Browser.FindElement(By.ClassName("graphs-details"));
            el[1] = Browser.FindElement(By.ClassName("graphs-errors"));
            el[2] = Browser.FindElement(By.ClassName("graphs-support"));
            el[3] = Browser.FindElement(By.ClassName("graphs-files"));*/

            /*element = Browser.FindElement(By.PartialLinkText("СОПРОВ"));
            element = Browser.FindElement(By.PartialLinkText("ВНИК"));
            element = Browser.FindElement(By.PartialLinkText("НАХ"));
            element = Browser.FindElement(By.PartialLinkText("ФАЙЛ"));*/

            /*for (int i=0; i==100; i++) {
                for (int z=0; z<4; z++) {
                    el[z].Click();
                    //System.Threading.Thread.Sleep(500);
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e) //Выход
        {
            //Application.Exit();
            IWebElement element;
            //element = Browser.FindElement(By.PartialLinkText("НАХОДИТЬ"));
            //element = Browser.FindElement(By.PartialLinkText("vk.com"));



            //selector1// body > div.wrap > section.requirements > section > div.graphs - details.graph - active > a
            //selector2// body > div.wrap > section.requirements > section > div.graphs - errors.graph - active > a
            //selector3// body > div.wrap > section.requirements > section > div.graphs - support.graph - active > a
            //selector4// body > div.wrap > section.requirements > section > div.graphs - files.graph - active > a
            //xpath1// / html / body / div[1] / section[1] / section / div[1] / a
            //xpath2// / html / body / div[1] / section[1] / section / div[2] / a
            //xpath3// / html / body / div[1] / section[1] / section / div[3] / a
            //xpath4// / html / body / div[1] / section[1] / section / div[4] / a
            /*
            body > div.wrap > section.requirements > section > div.graphs - details > a
            body > div.wrap > section.requirements > section > div.graphs - errors > a
            body > div.wrap > section.requirements > section > div.graphs - support > a
            body > div.wrap > section.requirements > section > div.graphs - files > a
            */
            
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
