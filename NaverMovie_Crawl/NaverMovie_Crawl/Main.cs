using System;
using System.Collections;
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

namespace boardTest
{
    public partial class Main : Form
    {
        Loading loading = new Loading();
        public Main()
        {
            InitializeComponent();   
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loading.Show();
            var options = new ChromeOptions();
            options.AddArgument("headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            //박스오피스흥행순위
            using (var boxoffice = new ChromeDriver(service, options))
            {
                boxoffice.Navigate().GoToUrl("http://www.naver.com");
                

                var retrieve = boxoffice.FindElement(By.Id("query"));
                retrieve.SendKeys("박스오피스 흥행순위");
                boxoffice.FindElement(By.Id("search_btn")).Click();

                for (var num = 1; num < 9; num++)
                {
                    var t = "li[" + num + "]";
                    var name = boxoffice.FindElement(
                        By.XPath("//*[@id=\"main_pack\"]/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/ul/" + t));

                    string test = name.Text;
                    Console.WriteLine(test);

                    var inList = name.Text.Split('\n');

                    lv_boxoffice.BeginUpdate();
                    ListViewItem item;

                    item = new ListViewItem(inList[1]);
                    item.SubItems.Add(inList[2]);
                    item.SubItems.Add(inList[0]);
                    item.SubItems.Add(inList[4]);
                    item.SubItems.Add(inList[6]);
                    item.SubItems.Add(inList[8]);

                    lv_boxoffice.Items.Add(item);

                    lv_boxoffice.EndUpdate();
                    Console.WriteLine("================");
                }
            }

            //현재상영영화
            using (var nowmovie = new ChromeDriver(service, options))
            {
                nowmovie.Navigate().GoToUrl("https://movie.naver.com/movie/running/current.nhn#");
                nowmovie.Manage().Window.Maximize();

                var movieCnt = nowmovie.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[3]/ul"))
                    .FindElements(By.TagName("li")).Count;
                for (var num = 1; num <= movieCnt; num++)
                {

                    var t = "li[" + num + "]";
                    var name = nowmovie.FindElement(
                        By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[3]/ul/" + t));

                    string test = name.Text;
                    //Console.WriteLine(test);

                    var inList = name.Text.Split('\n');
                    var list = new List<string>();
                    for (var i = 0; i < inList.Length; i++)
                    {
                        list.Add(inList[i]);
                        Console.WriteLine(list[i]);
                    }

                    //예매율이 없는경우
                    if (!inList[5].Contains("예매율"))
                    {
                        list.Insert(4, "|");
                        list.Insert(5, "예매율");
                        list.Insert(6, "0");
                        list.Insert(7, "%");
                    }

                    //관람등급이 없는경우 제목도 봐야함
                    var textSplit = list[0].Split(' ');
                    var textSplit2 = list[9].Split('|');
                    var movieLevel = "";
                    var movieTitle = "";
                    if (!inList[0].Contains("관람"))
                    {
                        list.Insert(1, "미정");
                        movieLevel = list[1];
                        movieTitle = list[0];
                    }
                    else
                    {
                        movieLevel = textSplit[0] + textSplit[1];
                        for (var i = 2; i < textSplit.Length; i++)
                        {
                            movieTitle += textSplit[i];
                        }
                    }

                    //장르가 없는경우
                    var genre = 2;
                    if (textSplit2.Length == 2)
                    {
                        genre = 1;
                    } 
                    var movieOpenDate = textSplit2[genre].Replace("개봉", "");
                    var movieTime = textSplit2[genre-1];

                    lv_nowmovie.BeginUpdate();
                    ListViewItem item;

                    item = new ListViewItem(num.ToString());
                    item.SubItems.Add(movieTitle);
                    item.SubItems.Add(movieLevel);
                    item.SubItems.Add(movieOpenDate);
                    item.SubItems.Add(list[2]);
                    item.SubItems.Add(list[6] + "%");
                    item.SubItems.Add(movieTime);

                    lv_nowmovie.Items.Add(item);

                    lv_nowmovie.EndUpdate();
                    Console.WriteLine("================");
                }
                loading.Hide();
            }
        
            
            #region 크롬브라우저 보이는 코드
            //                        IWebDriver driver = new ChromeDriver();
            //                 
            //                        driver.Navigate().GoToUrl("http://www.naver.com");
            //                        driver.Manage().Window.Maximize();
            //            
            //                        //검색창 input id = query
            //                        //IWebElement retrieve = driver.FindElement(By.Id("query"));
            //                        var retrieve = driver.FindElement(By.Id("query"));
            //                        retrieve.SendKeys("박스오피스 흥행순위");
            //                        driver.FindElement(By.Id("search_btn")).Click();
            //                        Thread.Sleep(5000);
            //            
            //                        for (var num = 1; num < 9; num++)
            //                        {
            //                            var t = "li[" + num + "]";
            //                            var movie = driver.FindElement(By.ClassName("contents03"));
            //                            var name = movie.FindElement(
            //                                By.XPath("//*[@id=\"main_pack\"]/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/ul/" + t));
            //            
            //                            string test = name.Text;
            //                            Console.WriteLine(test);
            //                            Console.WriteLine("================");
            //                        } 
            //
            //
            //
            //            driver.Close();
            #endregion
        }
    }
}
