namespace Connection_to_database
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Search = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Streetnames = new System.Windows.Forms.Button();
            this.Streetname = new System.Windows.Forms.Label();
            this.Parkinglot = new System.Windows.Forms.Button();
            this.ParkinglotTxt = new System.Windows.Forms.Label();
            this.StreetBox = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.select = new System.Windows.Forms.ComboBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Search2 = new System.Windows.Forms.Button();
            this.Keuze1 = new System.Windows.Forms.ComboBox();
            this.keuze3 = new System.Windows.Forms.ComboBox();
            this.Amount1 = new System.Windows.Forms.TextBox();
            this.Amount2 = new System.Windows.Forms.TextBox();
            this.ShowMap = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Cap = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChooseLbl = new System.Windows.Forms.Label();
            this.LblOption = new System.Windows.Forms.Label();
            this.OptionLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.ChooseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1542, 43);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 35);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1356, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Streetnames
            // 
            this.Streetnames.Location = new System.Drawing.Point(4, 5);
            this.Streetnames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Streetnames.Name = "Streetnames";
            this.Streetnames.Size = new System.Drawing.Size(180, 43);
            this.Streetnames.TabIndex = 3;
            this.Streetnames.Text = "Street Names";
            this.Streetnames.UseVisualStyleBackColor = true;
            this.Streetnames.Click += new System.EventHandler(this.button2_Click);
            // 
            // Streetname
            // 
            this.Streetname.AutoSize = true;
            this.Streetname.Location = new System.Drawing.Point(1160, 51);
            this.Streetname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Streetname.Name = "Streetname";
            this.Streetname.Size = new System.Drawing.Size(189, 20);
            this.Streetname.TabIndex = 4;
            this.Streetname.Text = "Put here the street name:";
            this.Streetname.Click += new System.EventHandler(this.Streetname_Click);
            // 
            // Parkinglot
            // 
            this.Parkinglot.Location = new System.Drawing.Point(194, 5);
            this.Parkinglot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Parkinglot.Name = "Parkinglot";
            this.Parkinglot.Size = new System.Drawing.Size(180, 43);
            this.Parkinglot.TabIndex = 5;
            this.Parkinglot.Text = "Parkinglot";
            this.Parkinglot.UseVisualStyleBackColor = true;
            this.Parkinglot.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ParkinglotTxt
            // 
            this.ParkinglotTxt.AutoSize = true;
            this.ParkinglotTxt.Location = new System.Drawing.Point(1172, 51);
            this.ParkinglotTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParkinglotTxt.Name = "ParkinglotTxt";
            this.ParkinglotTxt.Size = new System.Drawing.Size(173, 20);
            this.ParkinglotTxt.TabIndex = 7;
            this.ParkinglotTxt.Text = "Put here the parkinglot:";
            this.ParkinglotTxt.Visible = false;
            this.ParkinglotTxt.Click += new System.EventHandler(this.ParkinglotTxt_Click);
            // 
            // StreetBox
            // 
            this.StreetBox.FormattingEnabled = true;
            this.StreetBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StreetBox.Items.AddRange(new object[] {
            "Bouwjaar",
            "Bestaand",
            "Redenatie",
            "Naam"});
            this.StreetBox.Location = new System.Drawing.Point(1356, 86);
            this.StreetBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(180, 28);
            this.StreetBox.TabIndex = 9;
            this.StreetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(130, 332);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1216, 580);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(498, 225);
            this.select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(180, 28);
            this.select.TabIndex = 11;
            this.select.Visible = false;
            this.select.SelectedIndexChanged += new System.EventHandler(this.Select_SelectedIndexChanged);
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(339, 226);
            this.Value1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(148, 26);
            this.Value1.TabIndex = 12;
            this.Value1.Visible = false;
            this.Value1.TextChanged += new System.EventHandler(this.Value1_TextChanged);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(688, 226);
            this.Value2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(148, 26);
            this.Value2.TabIndex = 13;
            this.Value2.Visible = false;
            this.Value2.TextChanged += new System.EventHandler(this.Value2_TextChanged);
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(879, 226);
            this.Search2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(112, 35);
            this.Search2.TabIndex = 14;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Visible = false;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // Keuze1
            // 
            this.Keuze1.FormattingEnabled = true;
            this.Keuze1.Location = new System.Drawing.Point(308, 225);
            this.Keuze1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Keuze1.Name = "Keuze1";
            this.Keuze1.Size = new System.Drawing.Size(180, 28);
            this.Keuze1.TabIndex = 15;
            this.Keuze1.Visible = false;
            this.Keuze1.SelectedIndexChanged += new System.EventHandler(this.Keuze1_SelectedIndexChanged);
            // 
            // keuze3
            // 
            this.keuze3.FormattingEnabled = true;
            this.keuze3.Location = new System.Drawing.Point(688, 225);
            this.keuze3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keuze3.Name = "keuze3";
            this.keuze3.Size = new System.Drawing.Size(180, 28);
            this.keuze3.TabIndex = 16;
            this.keuze3.Visible = false;
            this.keuze3.SelectedIndexChanged += new System.EventHandler(this.keuze3_SelectedIndexChanged);
            // 
            // Amount1
            // 
            this.Amount1.Location = new System.Drawing.Point(321, 292);
            this.Amount1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount1.Name = "Amount1";
            this.Amount1.Size = new System.Drawing.Size(148, 26);
            this.Amount1.TabIndex = 17;
            this.Amount1.Visible = false;
            // 
            // Amount2
            // 
            this.Amount2.Location = new System.Drawing.Point(704, 292);
            this.Amount2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount2.Name = "Amount2";
            this.Amount2.Size = new System.Drawing.Size(148, 26);
            this.Amount2.TabIndex = 18;
            this.Amount2.Visible = false;
            // 
            // ShowMap
            // 
            this.ShowMap.Location = new System.Drawing.Point(1542, 292);
            this.ShowMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowMap.Name = "ShowMap";
            this.ShowMap.Size = new System.Drawing.Size(112, 35);
            this.ShowMap.TabIndex = 20;
            this.ShowMap.Text = "Show Map";
            this.ShowMap.UseVisualStyleBackColor = true;
            this.ShowMap.Click += new System.EventHandler(this.ShowMap_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1692, 222);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 35);
            this.Close.TabIndex = 22;
            this.Close.Text = "Close Map";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Cap
            // 
            this.Cap.FormattingEnabled = true;
            this.Cap.Items.AddRange(new object[] {
            "0-200",
            "200-500",
            "500-700",
            "700 >"});
            this.Cap.Location = new System.Drawing.Point(1692, 266);
            this.Cap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cap.Name = "Cap";
            this.Cap.Size = new System.Drawing.Size(180, 28);
            this.Cap.TabIndex = 24;
            this.Cap.Visible = false;
            this.Cap.SelectedIndexChanged += new System.EventHandler(this.Cap_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Connection_to_database.Properties.Resources.wqe;
            this.pictureBox6.Location = new System.Drawing.Point(4, 165);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(2042, 1082);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Connection_to_database.Properties.Resources.dsaaw;
            this.pictureBox5.Location = new System.Drawing.Point(4, 165);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1926, 1063);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Connection_to_database.Properties.Resources.weq;
            this.pictureBox4.Location = new System.Drawing.Point(4, 165);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1926, 1063);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Connection_to_database.Properties.Resources.dsa;
            this.pictureBox3.Location = new System.Drawing.Point(4, 165);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1926, 1063);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Connection_to_database.Properties.Resources.map;
            this.pictureBox2.Location = new System.Drawing.Point(4, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2091, 785);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Connection_to_database.Properties.Resources.dasdsa;
            this.pictureBox1.Location = new System.Drawing.Point(1428, 332);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 580);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ChooseLbl
            // 
            this.ChooseLbl.AutoSize = true;
            this.ChooseLbl.Location = new System.Drawing.Point(1222, 89);
            this.ChooseLbl.Name = "ChooseLbl";
            this.ChooseLbl.Size = new System.Drawing.Size(123, 20);
            this.ChooseLbl.TabIndex = 28;
            this.ChooseLbl.Text = "Choose Options";
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(304, 188);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(56, 20);
            this.LblOption.TabIndex = 29;
            this.LblOption.Text = "Option";
            this.LblOption.Visible = false;
            this.LblOption.Click += new System.EventHandler(this.label1_Click);
            // 
            // OptionLbl
            // 
            this.OptionLbl.AutoSize = true;
            this.OptionLbl.Location = new System.Drawing.Point(684, 188);
            this.OptionLbl.Name = "OptionLbl";
            this.OptionLbl.Size = new System.Drawing.Size(56, 20);
            this.OptionLbl.TabIndex = 30;
            this.OptionLbl.Text = "Option";
            this.OptionLbl.Visible = false;
            this.OptionLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(335, 188);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(43, 20);
            this.YearLbl.TabIndex = 31;
            this.YearLbl.Text = "Year";
            this.YearLbl.Visible = false;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(684, 188);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(43, 20);
            this.LblYear.TabIndex = 32;
            this.LblYear.Text = "Year";
            this.LblYear.Visible = false;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(249, 295);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(65, 20);
            this.LblAmount.TabIndex = 33;
            this.LblAmount.Text = "Amount";
            this.LblAmount.Visible = false;
            this.LblAmount.Click += new System.EventHandler(this.LblAmount_Click);
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(632, 298);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(65, 20);
            this.AmountLbl.TabIndex = 34;
            this.AmountLbl.Text = "Amount";
            this.AmountLbl.Visible = false;
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(1623, 274);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(64, 20);
            this.ChooseLabel.TabIndex = 35;
            this.ChooseLabel.Text = "Choose";
            this.ChooseLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1038);
            this.Controls.Add(this.ChooseLabel);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.OptionLbl);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.ChooseLbl);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Cap);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.ParkinglotTxt);
            this.Controls.Add(this.Parkinglot);
            this.Controls.Add(this.Streetname);
            this.Controls.Add(this.Streetnames);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowMap);
            this.Controls.Add(this.Amount2);
            this.Controls.Add(this.Amount1);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.keuze3);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Keuze1);
            this.Controls.Add(this.Value1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Parkeerplaats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Streetnames;
        private System.Windows.Forms.Label Streetname;
        private System.Windows.Forms.Button Parkinglot;
        private System.Windows.Forms.Label ParkinglotTxt;
        private System.Windows.Forms.ComboBox StreetBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.ComboBox Keuze1;
        private System.Windows.Forms.ComboBox keuze3;
        private System.Windows.Forms.TextBox Amount1;
        private System.Windows.Forms.TextBox Amount2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShowMap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox Cap;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ChooseLbl;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.Label OptionLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label ChooseLabel;
    }
}