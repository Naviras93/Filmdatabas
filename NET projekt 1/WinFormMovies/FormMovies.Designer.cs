namespace WinFormMovies
{
    partial class LableTitle
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
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMovieId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.listViewMovieInfo = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearchTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSearchTitle.Location = new System.Drawing.Point(16, 54);
            this.textBoxSearchTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(340, 23);
            this.textBoxSearchTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SearchTitle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFind.Location = new System.Drawing.Point(366, 49);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(71, 35);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(11, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add/Update/Delete";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTitle.Location = new System.Drawing.Point(16, 406);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(250, 23);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Director";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDirector.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDirector.Location = new System.Drawing.Point(16, 462);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(250, 23);
            this.textBoxDirector.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "MovieID";
            // 
            // textBoxMovieId
            // 
            this.textBoxMovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMovieId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMovieId.Location = new System.Drawing.Point(16, 348);
            this.textBoxMovieId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxMovieId.Name = "textBoxMovieId";
            this.textBoxMovieId.Size = new System.Drawing.Size(70, 23);
            this.textBoxMovieId.TabIndex = 9;
            this.textBoxMovieId.TextChanged += new System.EventHandler(this.textBoxMovieId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 493);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxYear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxYear.Location = new System.Drawing.Point(16, 519);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(70, 23);
            this.textBoxYear.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(12, 550);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Length";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLength.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLength.Location = new System.Drawing.Point(16, 576);
            this.textBoxLength.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(70, 23);
            this.textBoxLength.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(379, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Genre";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGenre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxGenre.Location = new System.Drawing.Point(383, 348);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(205, 23);
            this.textBoxGenre.TabIndex = 17;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxStatus.Location = new System.Drawing.Point(384, 405);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(70, 23);
            this.textBoxStatus.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(379, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPrice.Location = new System.Drawing.Point(383, 461);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(70, 23);
            this.textBoxPrice.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(379, 435);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Price";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.Location = new System.Drawing.Point(478, 530);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 35);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add Movie";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUpdatePrice.Location = new System.Drawing.Point(480, 456);
            this.buttonUpdatePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(120, 35);
            this.buttonUpdatePrice.TabIndex = 23;
            this.buttonUpdatePrice.Text = "Update Price";
            this.buttonUpdatePrice.UseVisualStyleBackColor = false;
            this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.Location = new System.Drawing.Point(478, 587);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 35);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Remove Movie";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUpdateStatus.Location = new System.Drawing.Point(480, 401);
            this.buttonUpdateStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(120, 35);
            this.buttonUpdateStatus.TabIndex = 26;
            this.buttonUpdateStatus.Text = "Update Status";
            this.buttonUpdateStatus.UseVisualStyleBackColor = false;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // listViewMovieInfo
            // 
            this.listViewMovieInfo.AllowColumnReorder = true;
            this.listViewMovieInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Title,
            this.Director,
            this.Year,
            this.Length,
            this.Genre,
            this.Status,
            this.Price});
            this.listViewMovieInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewMovieInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewMovieInfo.FullRowSelect = true;
            this.listViewMovieInfo.Location = new System.Drawing.Point(16, 96);
            this.listViewMovieInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewMovieInfo.Name = "listViewMovieInfo";
            this.listViewMovieInfo.Size = new System.Drawing.Size(683, 191);
            this.listViewMovieInfo.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewMovieInfo.TabIndex = 28;
            this.listViewMovieInfo.UseCompatibleStateImageBehavior = false;
            this.listViewMovieInfo.View = System.Windows.Forms.View.Details;
            this.listViewMovieInfo.SelectedIndexChanged += new System.EventHandler(this.listViewMovieInfo_SelectedIndexChanged_1);
            // 
            // MovieID
            // 
            this.MovieID.Text = "MovieID";
            this.MovieID.Width = 56;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 167;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 167;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 50;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 78;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 56;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(651, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LableTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(723, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewMovieInfo);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdatePrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMovieId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LableTitle";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.LableTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMovieId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.ListView listViewMovieInfo;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.Button button1;
    }
}

