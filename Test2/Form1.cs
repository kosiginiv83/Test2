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
        public IWebDriver Browser;

		public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Открыть Chrome
        {
            Browser = new ChromeDriver();
			Browser.Navigate().GoToUrl("http://blog.csssr.ru/qa-engineer/");
			IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
			jse.ExecuteScript("$('body').css({ transform:'scale(0.2)', transformOrigin:'0 0' })");
			jse.ExecuteScript(@"$('a:not(section.graphs a)').click(function(){return false}).
							text('Заблокировано').css('background-color', 'yellow');");
		}

        private void button2_Click(object sender, EventArgs e) // Прокликивание ссылок
        {
			IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
			int i = 0, x = 0;
			while (i < 10)
			{
				while (x < 3) { jse.ExecuteScript("$('.graphs-details > a').click();"); x++; }
				x = 0;
				while (x < 3) { jse.ExecuteScript("$('.graphs-errors > a').click();"); x++; }
				x = 0;
				while (x < 3) { jse.ExecuteScript("$('.graphs-support > a').click();"); x++; }
				x = 0;
				while (x < 3) { jse.ExecuteScript("$('.graphs-files > a').click();"); x++; }
				x = 0;
				i++;
			}
		}

		private void button3_Click(object sender, EventArgs e) // Выход
        {
			Browser.Quit();
			Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e) // div.popup-background
		{
			IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
			jse.ExecuteScript(@"var elem = $('div.popup-background');
				elem.show().css({'background-color':'red'});");
		}

		private void button5_Click(object sender, EventArgs e) // div.egg
		{
			IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
			jse.ExecuteScript(@"var elem = $('div.egg');
				elem.show().css({'background-color':'red', 'border-width':'20px', 
				'border-color':'green', transform:'scale(3)', transformOrigin:'0 0'});");
		}

		private void button6_Click(object sender, EventArgs e) // неадекватные размеры
		{

		}

		private void button7_Click(object sender, EventArgs e) // Сброс CSS 
		{
			IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
			Browser.Navigate().Refresh();
			jse.ExecuteScript("$('body').css({ transform:'scale(0.2)', transformOrigin:'0 0' })");
		}
	}
}

/*
IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
jse.ExecuteScript(@"var elem = $('*:hidden:not(div.popup-background)'); elem.show().
				css({'background-color':'red', 'border-width':'20px', 'border-color':'green'});");*/

/*jse.ExecuteScript("$('a:not(section.graphs a)').click(function(){return false});"); //Работает
jse.ExecuteScript("$('a:not(section.graphs a)').text('Заблокировано');"); //Работает
jse.ExecuteScript("$('a:not(section.graphs a)').css('background-color', 'red');");*/ //Работает

//element = Browser.FindElement(By.TagName("body")).SendKeys(Keys.Chord(OpenQA.Selenium.Keys.Ctrl, OpenQA.Selenium.Keys.Plus));
//Browser.findElement(By.tagName("body")).sendKeys(Keys.chord(Keys.CONTROL, "+"));
//jse.ExecuteScript("$('a:not(section.graphs a)').click(function(){return false});"); //Работает (отключает ссылки) 
//jse.ExecuteScript("$('a:not(section.graphs a)').each(function(i) {$(this).css('color', 'green')});"); //Работает
// $('section.graphs a').css('color', 'green'); //Работает
//jse.ExecuteScript("$('a').each(function(i) {$(this).css('color', 'green')});"); //Работает
// $("a[href*='news.yandex.ru']").css('color', 'green');


//$('body').css({ zoom: 0.25, transform: 'scale(1)', transformOrigin: '0 0' })
//$('body').css({ transform: 'scale(0.25)'})


//$('*:hidden:not(div.popup-background, section.info > div)').show().css('background-color', 'red'); //Работает
//jse.ExecuteScript("$('*:hidden:not(div.popup-background)').show().css({'border-width':'20px', 'border-color':'green'});"); //Работает
//$('section.info > div').show().css('background-color', 'red'); //Работает
//jse.ExecuteScript("$('*').each(function(i) {$(this).css('color', 'green')});"); //Работает
//jse.ExecuteScript("$('div.egg').show();"); //Работает
//jse.ExecuteScript("$('div.popup-background').removeClass('is-hidden').addClass('is-visible');"); //Работает
//$('div.popup-background').hide(); //Работает

//Browser.Navigate().GoToUrl("https://google.com");
//Browser.Navigate().GoToUrl("https://www.yandex.ru");

/*
IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
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

/*
 for (x = 1; x <= 3204; x++)
	{
		for (y = 1; y <= 1940; y++)
		{
			string str = "(document.elementFromPoint(" + x + ", " + y + "))";
			//MessageBox.Show(str);
			string str2 = "$" + str + ".click();";
			//MessageBox.Show(str2);
			jse.ExecuteScript(str2);
			//MessageBox.Show(str2);
			if (x == 500 & y == 1500) MessageBox.Show("x=500, y=1500");
			else if (x == 2500 & y == 1900) MessageBox.Show("x=2500, y=1900");
			else if (x == 3204 & y == 1940) { MessageBox.Show("All"); Browser.Quit(); Application.Exit(); }
		}
 * /

	/*
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
			//MessageBox.Show(str2);
			if (x == 500 & y == 1500) MessageBox.Show("x=500, y=1500");
			else if (x == 2500 & y == 1900) MessageBox.Show("x=2500, y=1900");
			else if (x == 3204 & y == 1940) { MessageBox.Show("All"); Browser.Quit(); Application.Exit(); }
		}
	}
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





//Browser = new OpenQA.Selenium.Firefox.FirefoxDriver();
//IWebElement[] el = new IWebElement[3];
//WebElement element = (WebElement) js.executeScript("return jQuery.find('#hplogo');");
//jse.ExecuteScript(textBox1.Text);

//MessageBox.Show(s.ToString());

//#kbd > div:nth-child(1) > div.vk-t-btns > div > div
//SearchInput.SendKeys("selenium" + OpenQA.Selenium.Keys.Enter);

//WebDriverWait ww = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
//IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#result p")));
