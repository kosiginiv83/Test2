// -------------------------------!!! Program.cs !!!---------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


// -------------------------------!!! Form1.Designer.cs !!!--------------------
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Browser and Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close Browser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search (google)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Search (yandex)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Open Browser";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(76, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 37);
            this.button7.TabIndex = 7;
            this.button7.Text = "Open yandex";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(140, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "Open google";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(11, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(187, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Element search (yandex)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(383, 175);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 20);
            this.button10.TabIndex = 10;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(11, 48);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Element search and click (yandex) 2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(11, 77);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(187, 23);
            this.button12.TabIndex = 12;
            this.button12.Text = "Element search and click (yandex) 3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(15, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 75);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(15, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 108);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(114, 14);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 20);
            this.button13.TabIndex = 16;
            this.button13.Text = "Repick elements";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 195);
            this.textBox2.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Location = new System.Drawing.Point(233, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 243);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(14, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(91, 20);
            this.button14.TabIndex = 18;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 477);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 130);
            this.textBox3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(11, 43);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 21;
            this.button15.Text = "Purchase JS";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 19);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(58, 34);
            this.button16.TabIndex = 9;
            this.button16.Text = "Add inset";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(15, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 65);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Don\'t Use";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(92, 43);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 23);
            this.button17.TabIndex = 9;
            this.button17.Text = "Waiting";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 664);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button17;
    }
}


// --------------------------!!! Обработчик событий для Form1 (Form1.cs) !!!---
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium; //Для работы Selenium
using OpenQA.Selenium.Support.UI; //Доп.команды для Selenium

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IWebDriver Browser; // Объявляем переменную
        //IWebDriver element;
        string a, b;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка "Open Browser and Search (Don`t Use)" (google)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver(); //Открываем Chrome
            //Browser.Manage().Window.Maximize(); //Разворачиваем окно на весь экран
            Browser.Navigate().GoToUrl("http://google.com"); //Переходим на сайт google.com

            IWebElement SearchInput = Browser.FindElement(By.Id("lst-ib")); //Находим строку поиска
            SearchInput.SendKeys("selenium" + OpenQA.Selenium.Keys.Enter); //Вводим в строку поиска "Selenium" и 
																			//нажимаем Enter
        }

        private void button2_Click(object sender, EventArgs e) //Кнопка "Close Browser"
        {
            Browser.Quit(); //Закрываем браузер
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка "Search" (google)
        {
            IWebElement SearchInput = Browser.FindElement(By.Id("lst-ib"));
            SearchInput.Clear();
            a = textBox1.Text;
            SearchInput.SendKeys(a + OpenQA.Selenium.Keys.Enter);
        }

        private void button4_Click(object sender, EventArgs e) //Кнопка "Exit"
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e) //Кнопка "Open Browser"
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver(); //Открывается чистое окно браузера, без 
																//какой-либо привязки к настройкам пользователя.
            //Чтобы открывалось окно браузера со всеми настройками конкретного пользователя, выполняются 
																//три строки ниже.
            //OpenQA.Selenium.Chrome.ChromeOptions co = new OpenQA.Selenium.Chrome.ChromeOptions();
            //co.AddArgument(@"user-data-dir=c:\Users\user\AppData\local\Google\Chrome\User Data\"); 
													//Ссылка на папку и имя пользователя вводятся свои.
            //Browser = new OpenQA.Selenium.Chrome.ChromeDriver(co);
        }

        private void button5_Click(object sender, EventArgs e) //Кнопка "Search" (yandex)
        {
            IWebElement element = Browser.FindElement(By.Name("text"));
            element.Clear();
            b = textBox1.Text;
            element.SendKeys(b + OpenQA.Selenium.Keys.Enter);
        }

        private void button7_Click(object sender, EventArgs e) //Кнопка "Open yandex"
        {
            Browser.Navigate().GoToUrl("http://yandex.ru");
        }

        private void button8_Click(object sender, EventArgs e) //Кнопка "Open google"
        {
            Browser.Navigate().GoToUrl("http://google.com");
        }

        private void button9_Click(object sender, EventArgs e) //Кнопка "Element search" (yandex)
        {
            IWebElement element = Browser.FindElement(By.Name("text"));
            element.SendKeys("Тест");
        }

        private void button11_Click(object sender, EventArgs e) //Кнопка "Element search and click" (yandex) 2
        {
            IWebElement element;
            element = Browser.FindElement(By.LinkText("Музыка")); //Поиск по тексту ссылки
            //element = Browser.FindElement(By.Id("music"));
            //element = Browser.FindElement(By.ClassName("home-logo__default"));
            element.Click();
        }

        private void button12_Click(object sender, EventArgs e) //Кнопка "Element search and click" (yandex) 3
        {
            IWebElement element;
            element = Browser.FindElement(By.PartialLinkText("Перевод")); //Поиск по частичному тексту ссылки
            element.Click();
        }

        private void button13_Click(object sender, EventArgs e) //Кнопка "Repick elements"
        {
            textBox2.Text = string.Empty;
            List<IWebElement> News = Browser.FindElements(By.CssSelector("#tabnews_newsc a")).ToList(); 
																	// ToList - преобразовывает в список
            // #tabnews_newsc a - Урок 3, 5:00
            for (int i=0; i < News.Count; i++)
            {
                int t = i + 1;
                textBox2.AppendText(t + ") " + News[i].Text + "\r\n");
            }

        }

        private void button14_Click(object sender, EventArgs e) //Button14
        {
            List<IWebElement> News = Browser.FindElements(By.CssSelector("#tabnews_newsc a")).ToList();

            for (int i = 0; i < News.Count; i++)
            {
                String s = News[i].Text;

                if (s.StartsWith("В"))
                {
                    textBox3.AppendText("Новость № " + (i + 1).ToString() + " начинается с текста 'В'" + "\r\n");
                }

                if (s.Contains("пре"))
                {
                    textBox3.AppendText("Новость № " + (i + 1).ToString() + " содержит текст 'пре'" + "\r\n");

                    News[i].Click(); //Эта команда работает до поры, ее нужно выводить в отдельный цикл
                    break; //Частично решает проблему, но цикл не будет выполняться полностью 
											//(выполнение допервого вхождения "пре")
                }
            }
        }

        private void button15_Click(object sender, EventArgs e) //Кнопка "Purchase JS"
        {
            IJavaScriptExecutor jse = Browser as IJavaScriptExecutor;
            //jse.ExecuteScript("alert('Тест JavaScript')"); //Выводит окно с тестом "Тест JavaScript" с кнопкой "ОК"
            jse.ExecuteScript(textBox1.Text); //Для этого вводятся только JS команды. На все остальное 
											//будет выдаваться ошибка.
            //Примеры JS (JQuery) команд для плавного исчезновения/появления логотипа Яндекса на главной странице.
            //$( ".home-logo__default" ).hide("slow");
            //$( ".home-logo__default" ).show("slow");
        }

        private void button16_Click(object sender, EventArgs e) //Кнопка "Add inset"
        {
            /*Browser.SwitchTo().Window( Browser.WindowHandles[1] ); //Переключение на др. вкладку.
            System.Windows.Forms.MessageBox.Show(Browser.Title + "\r\n" + Browser.Url); 
								//Вывести в отдельном окне название вкладки и ее адрес.

            Browser.SwitchTo().Window( Browser.WindowHandles[0] );
            System.Windows.Forms.MessageBox.Show(Browser.Title + "\r\n" + Browser.Url);

            Browser.SwitchTo().Window( Browser.WindowHandles[2] );
            System.Windows.Forms.MessageBox.Show(Browser.Title + "\r\n" + Browser.Url);*/

            /*String HabrWindow = FindWindow("habr"); //Поиск вкладки по фрагменту адреса, вызываемая функция ниже.
            Browser.SwitchTo().Window(HabrWindow);
            System.Windows.Forms.MessageBox.Show(Browser.Title + "\r\n" + Browser.Url);*/

            List<String> BeforeTabs = Browser.WindowHandles.ToList(); 
						//Запоминаем вкладки, открытые на данный момент. Для работы функции, на 
														//этой строке требуется точка останова.
            //Делаем что-то - открывается одна новая вкладка.
            //....
            List<String> AfterTabs = Browser.WindowHandles.ToList(); //Запоминаем вкладки, открытые 
																	//после какого-либо действия.
            //Вкладки до - вкладки после = новая вкладка.
            List<String> OneNewTab = AfterTabs.Except(BeforeTabs).ToList(); //Вычитаем из первого множества 
																//второе, отает - новая открытая вкладка.
            Browser.SwitchTo().Window(OneNewTab[0]);
            System.Windows.Forms.MessageBox.Show(Browser.Title + "\r\n" + Browser.Url);

        }

        private void button10_Click(object sender, EventArgs e) //Кнопка "Clear"
        {
            textBox1.Text = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e) //Кнопка "Waiting"
        {
            Browser.Navigate().GoToUrl("http://www.degraeve.com/reference/simple-ajax-example.php");

            IWebElement Button = Browser.FindElement( By.CssSelector("input[value='Go']") ); //Ищем кнопку "Go"
            Button.Click();

            //Способы организации задержки до выполнения следующей команды.
            //1
            //System.Threading.Thread.Sleep(5000); //Приостанавливает выполнение кода на 5 сек.
            //2
            //Browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); //Строка на протяжении 10 сек 
																	//пытается выполнить команду поиска элемента.
            //Вышеуказанная команда будет распространять свое действие на все поиски элементов, если ее 
									//расположить в модуль кнопки открытия браузера (? только переменная Browser).
            //3 - На протяжении 10 сек ждет выполнения условия, чтобы выполнить команду поиска элемента.
            WebDriverWait ww = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
            IWebElement txt = ww.Until(ExpectedConditions.ElementIsVisible( By.CssSelector("#result p") ));
            //*3

            //IWebElement txt = Browser.FindElement( By.CssSelector("#result p") ); 
									//Ищем элемент "p" с div id="result" //Нужна для способов задержки 1 и 2.
            textBox1.Text = txt.Text;
        }

        private string FindWindow(String Url) //Отдельная функция, для нахождения вкладки по фрагменту адреса.
        {
            String StartWindow = Browser.CurrentWindowHandle;
            String Result = "";

            for (int i = 0; i < Browser.WindowHandles.Count; i++)
            {
                if (Browser.WindowHandles[i] != StartWindow)
                {
                    Browser.SwitchTo().Window(Browser.WindowHandles[i]);
                    if (Browser.Url.Contains(Url))
                    {
                        Result = Browser.WindowHandles[i];
                        break;
                    }
                }
            }

            //Browser.SwitchTo().Window(StartWindow);
            return Result;
        }

    }
}
