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
            this.lv_boxoffice = new System.Windows.Forms.ListView();
            this.lv_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_openDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_daily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_stack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lv_nowmovie = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_boxoffice
            // 
            this.lv_boxoffice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_num,
            this.lv_name,
            this.lv_level,
            this.lv_openDate,
            this.lv_daily,
            this.lv_stack});
            this.lv_boxoffice.GridLines = true;
            this.lv_boxoffice.HideSelection = false;
            this.lv_boxoffice.Location = new System.Drawing.Point(30, 10);
            this.lv_boxoffice.Name = "lv_boxoffice";
            this.lv_boxoffice.Size = new System.Drawing.Size(623, 250);
            this.lv_boxoffice.TabIndex = 0;
            this.lv_boxoffice.UseCompatibleStateImageBehavior = false;
            this.lv_boxoffice.View = System.Windows.Forms.View.Details;
            // 
            // lv_num
            // 
            this.lv_num.Text = "번호";
            this.lv_num.Width = 36;
            // 
            // lv_name
            // 
            this.lv_name.Text = "영화제목";
            this.lv_name.Width = 100;
            // 
            // lv_level
            // 
            this.lv_level.Text = "관람등급";
            this.lv_level.Width = 90;
            // 
            // lv_openDate
            // 
            this.lv_openDate.Text = "개봉날짜";
            this.lv_openDate.Width = 90;
            // 
            // lv_daily
            // 
            this.lv_daily.Text = "일간관람객";
            this.lv_daily.Width = 80;
            // 
            // lv_stack
            // 
            this.lv_stack.Text = "누적관람객";
            this.lv_stack.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "네이버 영화 크롤링";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 304);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv_boxoffice);
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
            this.tabPage2.Controls.Add(this.lv_nowmovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "현재 상영영화";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lv_nowmovie
            // 
            this.lv_nowmovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_nowmovie.GridLines = true;
            this.lv_nowmovie.HideSelection = false;
            this.lv_nowmovie.Location = new System.Drawing.Point(31, 22);
            this.lv_nowmovie.Name = "lv_nowmovie";
            this.lv_nowmovie.Size = new System.Drawing.Size(621, 226);
            this.lv_nowmovie.TabIndex = 1;
            this.lv_nowmovie.UseCompatibleStateImageBehavior = false;
            this.lv_nowmovie.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "영화제목";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "개봉날짜";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "네티즌평점";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "예매율";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "상영시간";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "관람등급";
            this.columnHeader7.Width = 100;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_boxoffice;
        private System.Windows.Forms.ColumnHeader lv_num;
        private System.Windows.Forms.ColumnHeader lv_name;
        private System.Windows.Forms.ColumnHeader lv_level;
        private System.Windows.Forms.ColumnHeader lv_openDate;
        private System.Windows.Forms.ColumnHeader lv_daily;
        private System.Windows.Forms.ColumnHeader lv_stack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lv_nowmovie;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}