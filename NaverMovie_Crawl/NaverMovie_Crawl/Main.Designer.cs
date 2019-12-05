namespace boardTest
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGV_BoxOffice = new System.Windows.Forms.DataGridView();
            this.boxOffice_MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxOffice_MovieLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxOffice_MovieOpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxOffice_Daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxOffice_Stack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_NowMovie = new System.Windows.Forms.DataGridView();
            this.nowMovie_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_Gerne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_ShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_OpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_Star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowMovie_Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_CommingSoon = new System.Windows.Forms.DataGridView();
            this.commingSoon_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commingSoon_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commingSoon_ShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commingSoon_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commingSoon_OpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commingSoon_Expec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BoxOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NowMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CommingSoon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "네이버 영화 크롤링";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 304);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGV_BoxOffice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "박스오피스 흥행순위";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGV_NowMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "현재 상영영화";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dGV_CommingSoon);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "개봉 예정영화";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dGV_BoxOffice
            // 
            this.dGV_BoxOffice.AllowUserToAddRows = false;
            this.dGV_BoxOffice.AllowUserToDeleteRows = false;
            this.dGV_BoxOffice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_BoxOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_BoxOffice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boxOffice_MovieTitle,
            this.boxOffice_MovieLevel,
            this.boxOffice_MovieOpenDate,
            this.boxOffice_Daily,
            this.boxOffice_Stack});
            this.dGV_BoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_BoxOffice.Location = new System.Drawing.Point(3, 3);
            this.dGV_BoxOffice.Name = "dGV_BoxOffice";
            this.dGV_BoxOffice.ReadOnly = true;
            this.dGV_BoxOffice.RowTemplate.Height = 23;
            this.dGV_BoxOffice.Size = new System.Drawing.Size(682, 272);
            this.dGV_BoxOffice.TabIndex = 1;
            this.dGV_BoxOffice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_BoxOffice_CellDoubleClick);
            this.dGV_BoxOffice.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dGV_BoxOffice_RowPostPaint);
            // 
            // boxOffice_MovieTitle
            // 
            this.boxOffice_MovieTitle.HeaderText = "영화제목";
            this.boxOffice_MovieTitle.Name = "boxOffice_MovieTitle";
            // 
            // boxOffice_MovieLevel
            // 
            this.boxOffice_MovieLevel.HeaderText = "관람등급";
            this.boxOffice_MovieLevel.Name = "boxOffice_MovieLevel";
            // 
            // boxOffice_MovieOpenDate
            // 
            this.boxOffice_MovieOpenDate.HeaderText = "개봉날짜";
            this.boxOffice_MovieOpenDate.Name = "boxOffice_MovieOpenDate";
            // 
            // boxOffice_Daily
            // 
            this.boxOffice_Daily.HeaderText = "일간관람객";
            this.boxOffice_Daily.Name = "boxOffice_Daily";
            // 
            // boxOffice_Stack
            // 
            this.boxOffice_Stack.HeaderText = "누적관람객";
            this.boxOffice_Stack.Name = "boxOffice_Stack";
            // 
            // dGV_NowMovie
            // 
            this.dGV_NowMovie.AllowUserToAddRows = false;
            this.dGV_NowMovie.AllowUserToDeleteRows = false;
            this.dGV_NowMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_NowMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_NowMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nowMovie_Title,
            this.nowMovie_Gerne,
            this.nowMovie_ShowTime,
            this.nowMovie_Level,
            this.nowMovie_OpenDate,
            this.nowMovie_Star,
            this.nowMovie_Ticket});
            this.dGV_NowMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_NowMovie.Location = new System.Drawing.Point(3, 3);
            this.dGV_NowMovie.Name = "dGV_NowMovie";
            this.dGV_NowMovie.ReadOnly = true;
            this.dGV_NowMovie.RowTemplate.Height = 23;
            this.dGV_NowMovie.Size = new System.Drawing.Size(682, 272);
            this.dGV_NowMovie.TabIndex = 2;
            this.dGV_NowMovie.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dGV_NowMovie_RowPostPaint);
            // 
            // nowMovie_Title
            // 
            this.nowMovie_Title.HeaderText = "영화제목";
            this.nowMovie_Title.Name = "nowMovie_Title";
            // 
            // nowMovie_Gerne
            // 
            this.nowMovie_Gerne.HeaderText = "장르";
            this.nowMovie_Gerne.Name = "nowMovie_Gerne";
            // 
            // nowMovie_ShowTime
            // 
            this.nowMovie_ShowTime.HeaderText = "상영시간";
            this.nowMovie_ShowTime.Name = "nowMovie_ShowTime";
            // 
            // nowMovie_Level
            // 
            this.nowMovie_Level.HeaderText = "관람등급";
            this.nowMovie_Level.Name = "nowMovie_Level";
            // 
            // nowMovie_OpenDate
            // 
            this.nowMovie_OpenDate.HeaderText = "개봉날짜";
            this.nowMovie_OpenDate.Name = "nowMovie_OpenDate";
            // 
            // nowMovie_Star
            // 
            this.nowMovie_Star.HeaderText = "네티즌평점";
            this.nowMovie_Star.Name = "nowMovie_Star";
            // 
            // nowMovie_Ticket
            // 
            this.nowMovie_Ticket.HeaderText = "예매율";
            this.nowMovie_Ticket.Name = "nowMovie_Ticket";
            // 
            // dGV_CommingSoon
            // 
            this.dGV_CommingSoon.AllowUserToAddRows = false;
            this.dGV_CommingSoon.AllowUserToDeleteRows = false;
            this.dGV_CommingSoon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_CommingSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CommingSoon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commingSoon_Title,
            this.commingSoon_Genre,
            this.commingSoon_ShowTime,
            this.commingSoon_Level,
            this.commingSoon_OpenDate,
            this.commingSoon_Expec});
            this.dGV_CommingSoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_CommingSoon.Location = new System.Drawing.Point(3, 3);
            this.dGV_CommingSoon.Name = "dGV_CommingSoon";
            this.dGV_CommingSoon.ReadOnly = true;
            this.dGV_CommingSoon.RowTemplate.Height = 23;
            this.dGV_CommingSoon.Size = new System.Drawing.Size(682, 272);
            this.dGV_CommingSoon.TabIndex = 3;
            this.dGV_CommingSoon.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dGV_CommingSoon_RowPostPaint);
            // 
            // commingSoon_Title
            // 
            this.commingSoon_Title.HeaderText = "영화제목";
            this.commingSoon_Title.Name = "commingSoon_Title";
            // 
            // commingSoon_Genre
            // 
            this.commingSoon_Genre.HeaderText = "장르";
            this.commingSoon_Genre.Name = "commingSoon_Genre";
            // 
            // commingSoon_ShowTime
            // 
            this.commingSoon_ShowTime.HeaderText = "상영시간";
            this.commingSoon_ShowTime.Name = "commingSoon_ShowTime";
            // 
            // commingSoon_Level
            // 
            this.commingSoon_Level.HeaderText = "관람등급";
            this.commingSoon_Level.Name = "commingSoon_Level";
            // 
            // commingSoon_OpenDate
            // 
            this.commingSoon_OpenDate.HeaderText = "개봉예정날짜";
            this.commingSoon_OpenDate.Name = "commingSoon_OpenDate";
            // 
            // commingSoon_Expec
            // 
            this.commingSoon_Expec.HeaderText = "기대지수";
            this.commingSoon_Expec.Name = "commingSoon_Expec";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 393);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BoxOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NowMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CommingSoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dGV_BoxOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxOffice_MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxOffice_MovieLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxOffice_MovieOpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxOffice_Daily;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxOffice_Stack;
        private System.Windows.Forms.DataGridView dGV_NowMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_Gerne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_ShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_OpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_Star;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowMovie_Ticket;
        private System.Windows.Forms.DataGridView dGV_CommingSoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_ShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_OpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn commingSoon_Expec;
    }
}