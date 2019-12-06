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
using System.Diagnostics;

namespace NaverMovie_Crawl
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
            var sw = new Stopwatch();
            sw.Start();

            loading.Show();
            
            //크롬브라우저 숨기기, 정보바 숨기기, 이미지 로딩x
            var options = new ChromeOptions();
            options.AddArgument("headless");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);


            //크롬드라이버 숨기기
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            //박스오피스흥행순위
            using (var boxoffice = new ChromeDriver(service, options))
            {
                Application.DoEvents();
                boxoffice.Navigate().GoToUrl("http://www.naver.com");

                var retrieve = boxoffice.FindElement(By.Id("query"));
                retrieve.SendKeys("박스오피스 흥행순위");
                boxoffice.FindElement(By.Id("search_btn")).Click();

                for (var num = 1; num < 9; num++)
                {
                    Application.DoEvents();
                    var t = "li[" + num + "]";
                    var name = boxoffice.FindElement(
                        By.XPath("//*[@id=\"main_pack\"]/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/ul/" + t));

                    string test = name.Text;
                    Console.WriteLine(test);

                    var inList = name.Text.Split('\n');

                    dGV_BoxOffice.Rows.Add();
                    dGV_BoxOffice[boxOffice_MovieTitle.Index, num - 1].Value = inList[2];
                    dGV_BoxOffice[boxOffice_MovieLevel.Index, num - 1].Value = inList[0];
                    dGV_BoxOffice[boxOffice_MovieOpenDate.Index, num - 1].Value = inList[4];
                    dGV_BoxOffice[boxOffice_Daily.Index, num - 1].Value = inList[6];
                    dGV_BoxOffice[boxOffice_Stack.Index, num - 1].Value = inList[8];

                    Console.WriteLine("================");
                }
            }

            //현재상영영화
            using (var nowmovie = new ChromeDriver(service, options))
            {
                nowmovie.Navigate().GoToUrl("https://movie.naver.com/movie/running/current.nhn#");
                //nowmovie.Manage().Window.Maximize();  //크롬브라우저 최대화

                var movieCnt = nowmovie.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[3]/ul"))
                    .FindElements(By.TagName("li")).Count;
                for (var num = 1; num <= movieCnt; num++)
                {

                    var t = "li[" + num + "]";
                    var name = nowmovie.FindElement(
                        By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[3]/ul/" + t));

                    string test = name.Text;
                    //Console.WriteLine(test);

                    var inList = name.Text.Split('\r');
                    var list = new List<string>();
                    for (var i = 0; i < inList.Length; i++)
                    {
                        list.Add(inList[i].Replace("\n",""));
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
                    var movieGenre = "";
                    if (textSplit2.Length == 2)
                    {
                        genre = 1;
                        movieGenre = "미정";
                    }
                    else
                    {
                        movieGenre = textSplit2[0];
                    }
                    var movieOpenDate = textSplit2[genre].Replace("개봉", "");
                    var movieTime = textSplit2[genre-1];

                    dGV_NowMovie.Rows.Add();
                    dGV_NowMovie[nowMovie_Title.Index, num - 1].Value = movieTitle;
                    dGV_NowMovie[nowMovie_Gerne.Index, num - 1].Value = movieGenre;
                    dGV_NowMovie[nowMovie_ShowTime.Index, num - 1].Value = movieTime;
                    dGV_NowMovie[nowMovie_Level.Index, num - 1].Value = movieLevel;
                    dGV_NowMovie[nowMovie_OpenDate.Index, num - 1].Value = movieOpenDate;
                    dGV_NowMovie[nowMovie_Star.Index, num - 1].Value = list[2];
                    dGV_NowMovie[nowMovie_Ticket.Index, num - 1].Value = list[6]+"%";

                    Console.WriteLine("================");
                }
                //loading.Hide();
            }

            //개봉예정영화
            using (var commingsoon = new ChromeDriver(service, options))
            {
                commingsoon.Navigate().GoToUrl("https://movie.naver.com/movie/running/premovie.nhn");
                //nowmovie.Manage().Window.Maximize();

                var movieCnt = commingsoon.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[1]"))
                    .FindElements(By.ClassName("lst_wrap")).Count;

                var divCnt = 3;
                var movieRank = 1;
                //var gridCnt = 0;

                for (var num = 1; num <= movieCnt; num++)
                {
                    
                    var dayMovieCnt = commingsoon.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[" + divCnt + "]"))
                        .FindElements(By.TagName("li")).Count;

                    for (var loop = 1; loop <= dayMovieCnt; loop++)
                    {
                        var liCnt = "li[" + loop + "]";
                        var name = commingsoon.FindElement(
                            By.XPath("//*[@id=\"content\"]/div[1]/div[1]/div[" + divCnt + "]/ul/" + liCnt));

                        var inList = name.Text.Split('\r');
                        var list = new List<string>();
                        for (var i = 0; i < inList.Length; i++)
                        {
                            list.Add(inList[i].Replace("\n", ""));
                            Console.WriteLine(list[i]);
                        }

                        //이미 개봉했던 영화일경우
                        if (list[5].Contains("기자"))
                        {
                            for(var i = 5; i<= 7; i++)
                            {
                                list.RemoveAt(5);
                            }
                        }
                        if (list[1].Equals("네티즌"))
                        {
                            for (var i = 1; i <= 4; i++)
                            {
                                list.RemoveAt(1);
                            }
                            list.Insert(1, "기대지수");
                            list.Insert(2, "보고싶어요");
                            list.Insert(3, "0");
                            list.Insert(4, "글쎄요");
                            list.Insert(5, "0");
                        }
                      
                        //관람등급이 없는경우 제목도 봐야함
                        var textSplit = list[0].Split(' ');
                        var movieLevel = "";
                        var movieTitle = "";
                        if (!list[0].Contains("관람"))
                        {
                            movieLevel = "미정";
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

                        //예매율이 없는경우
                        if (!list[1].Contains("예매율"))
                        {
                            list.Insert(1, "예매율");
                            list.Insert(2, "0");
                            list.Insert(3, "%");
                            list.Insert(4, "|");
                        }

                        //장르가 없는경우
                        var textSplit2 = list[11].Split('|');
                        var genre = 2;
                        var movieGenre = "";
                        var movieTime = "";
                        if (textSplit2.Length == 2)
                        {
                            genre = 1;
                            movieGenre = "미정";
                        }
                        else if (textSplit2.Length == 1)
                        {
                            genre = 0;
                            movieGenre = "미정";
                            movieTime = "미정";
                        }
                        else
                        {
                            movieGenre = textSplit2[0];
                        }

                        var movieOpenDate = textSplit2[genre].Replace("개봉", "");
                        if (!movieTime.Equals("미정")) movieTime = textSplit2[genre - 1];

                        dGV_CommingSoon.Rows.Add();
                        dGV_CommingSoon[commingSoon_Title.Index, movieRank-1].Value = movieTitle;
                        dGV_CommingSoon[commingSoon_Genre.Index, movieRank-1].Value = movieGenre;
                        dGV_CommingSoon[commingSoon_ShowTime.Index, movieRank-1].Value = movieTime;
                        dGV_CommingSoon[commingSoon_Level.Index, movieRank-1].Value = movieLevel;
                        dGV_CommingSoon[commingSoon_OpenDate.Index, movieRank-1].Value = movieOpenDate;
                        dGV_CommingSoon[commingSoon_Expec.Index, movieRank-1].Value = list[7] + "/" + list[9];

                        movieRank++;
                        Console.WriteLine("================");
                    }
                    divCnt++;
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

            sw.Stop();
            var time = sw.ElapsedMilliseconds / 1000;
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            Console.WriteLine(time);
        }

        //설명 링크 https://vesselsdiary.tistory.com/81
        private void dGV_BoxOffice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dGV_BoxOffice.RowHeadersDefaultCellStyle.ForeColor))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 11, e.RowBounds.Location.Y + 4, sf);
            }
        }

        private void dGV_NowMovie_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dGV_NowMovie.RowHeadersDefaultCellStyle.ForeColor))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 11, e.RowBounds.Location.Y + 4, sf);
            }
        }

        private void dGV_CommingSoon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dGV_CommingSoon.RowHeadersDefaultCellStyle.ForeColor))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 11, e.RowBounds.Location.Y + 4, sf);
            }
        }

        private void dGV_BoxOffice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = dGV_BoxOffice.SelectedRows[0];
            //MessageBox.Show(dGV_BoxOffice.selected);
        } 
    }
}
