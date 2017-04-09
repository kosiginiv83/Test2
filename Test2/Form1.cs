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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Web;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace Test2
{
    public partial class Form1 : Form
    {
        public IWebDriver Browser; public int x; public int y;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Открыть
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();

            Browser.Navigate().GoToUrl("http://blog.csssr.ru/qa-engineer/");
            //Browser.Navigate().GoToUrl("https://google.com");
            //Browser.Navigate().GoToUrl("https://www.yandex.ru");
        
            //Browser.Manage().Window.Maximize();
        }

        private void button2_Click(object sender, EventArgs e) //Поехали
        {
            IWebElement element;
            element = Browser.FindElement(By.Id("gs_ok0")); element.Click();
            //System.Threading.Thread.Sleep(3000);
            WebDriverWait ww = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
            IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible(By.Id("kbd"))); //Для Google
            element = Browser.FindElement(By.Id("K65")); element.Click(); //Для Google
            element = Browser.FindElement(By.Id("K70")); element.Click(); //Для Google
            element = Browser.FindElement(By.Id("K82")); element.Click(); //Для Google
            element = Browser.FindElement(By.Id("lst-ib")); //Для Google
            element.SendKeys(OpenQA.Selenium.Keys.Enter);
            element = Browser.FindElement(By.CssSelector("#kbd > div:nth-child(1) > div.vk-t-btns > div > div")); element.Click(); //Для Google
            MessageBox.Show("Выполнено");
            Browser.Quit();
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e) //Выход
        {

            /*IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            int i = 0, x = 0;
            while (i < 10)
            {
                while (x < 3) { jse.ExecuteScript("$('.graphs-details > a').click();"); x++; } x = 0;
                while (x < 3) { jse.ExecuteScript("$('.graphs-errors > a').click();"); x++; } x = 0;
                while (x < 3) { jse.ExecuteScript("$('.graphs-support > a').click();"); x++; }  x = 0;
                while (x < 3) { jse.ExecuteScript("$('.graphs-files > a').click();"); x++; } x = 0;
                i++;
            }
            */

            IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            jse.ExecuteScript("$('html')");
            for (x = 1; x <= 3204; x++)
            {
                for (y = 1; y <= 1940; y++)
                {
                    string str = "(document.elementFromPoint(" + x + ", " + y + "))";
                    //MessageBox.Show(str);
                    string str2 = "$" + str + ".click();";
                    //MessageBox.Show(str2);
                    jse.ExecuteScript(str2);
                    MessageBox.Show(str2);
                    if (x == 500 & y == 1500) MessageBox.Show("x=500, y=1500");
                    else if (x == 2500 & y == 1900) MessageBox.Show("x=2500, y=1900");
                    else if (x == 3204 & y == 1940) { MessageBox.Show("All"); Browser.Quit(); Application.Exit(); }
                    }
                }


            /*
            Actions builder = new Actions(Browser);
                    builder.MoveToElement(jse, x, y).Click();
                    //builder.Click();
            */

            /*
            IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)Browser;
            jse.ExecuteScript("$(document.elementFromPoint(x, y)).click();");
            */

            /*
            IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            jse.ExecuteScript("$('.input__box i').click();");
            */
            /*
            IWebElement element;
            element = Browser.FindElement(By.CssSelector(".input__box i")); element.Click(); //Для Yandex
            */

            /*
            IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            //jse.ExecuteScript("alert('Тест JavaScript')");
            //System.Threading.Thread.Sleep(1000);
            jse.ExecuteScript("$('.home-logo__default').hide('slow')"); //Для Yandex
            System.Threading.Thread.Sleep(500);
            jse.ExecuteScript("$('.home-logo__default').show('slow')"); //Для Yandex
            System.Threading.Thread.Sleep(500);
            */

            //Browser.Quit();
            //Application.Exit();

        }
    }
}


//Browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
//IWebElement[] el = new IWebElement[3];
//WebElement element = (WebElement) js.executeScript("return jQuery.find('#hplogo');");
//jse.ExecuteScript(textBox1.Text);

//MessageBox.Show(s.ToString());

//#kbd > div:nth-child(1) > div.vk-t-btns > div > div
//SearchInput.SendKeys("selenium" + OpenQA.Selenium.Keys.Enter);

//WebDriverWait ww = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
//IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#result p")));


//IWebElement[] el = new IWebElement[3];
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

/*for (int i=0; i==10; i++) {
    for (int z=0; z<3; z++) {
        el[z].Click();
        //System.Threading.Thread.Sleep(500);
    }
}*/


//element = Browser.FindElement(By.PartialLinkText("НАХОДИТЬ"));
//element = Browser.FindElement(By.PartialLinkText("vk.com"));
//element = Browser.FindElement(By.CssSelector("body > div.wrap > footer > nav > div:nth-child(2) > a"));

/*
element = Browser.FindElement(By.XPath("html/body/div[1]/section[1]/section/div[1]/a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.XPath("html/body/div[1]/section[1]/section/div[2]/a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.XPath("html/body/div[1]/section[1]/section/div[3]/a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.XPath("html/body/div[1]/section[1]/section/div[4]/a")); element.Click(); System.Threading.Thread.Sleep(1000);
*/
/*
element = Browser.FindElement(By.CssSelector("div.graphs-details.graph-active a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.CssSelector("div.graphs-errors.graph-active a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.CssSelector("div.graphs-support.graph-active a")); element.Click(); System.Threading.Thread.Sleep(1000);
element = Browser.FindElement(By.CssSelector("div.graphs-files.graph-active a")); element.Click(); System.Threading.Thread.Sleep(1000);
*/

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
