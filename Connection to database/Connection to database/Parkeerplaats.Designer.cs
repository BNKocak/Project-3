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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblMethode = new System.Windows.Forms.Label();
            this.MethodeLbl = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.LblService = new System.Windows.Forms.Label();
            this.LblOption = new System.Windows.Forms.Label();
            this.OptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
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
            "Bouwjaar"});
            this.StreetBox.Location = new System.Drawing.Point(1356, 51);
            this.StreetBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(180, 28);
            this.StreetBox.TabIndex = 9;
            this.StreetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(130, 332);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "Amount of Streets";
            series27.ChartArea = "ChartArea1";
            series27.Legend = "Legend1";
            series27.Name = "Amount of Pay Methods";
            series28.ChartArea = "ChartArea1";
            series28.Legend = "Legend1";
            series28.Name = "Amount of Services";
            series29.ChartArea = "ChartArea1";
            series29.Legend = "Legend1";
            series29.Name = "Amount of Parking Spaces";
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Connection_to_database.Properties.Resources.dasdsa;
            this.pictureBox1.Location = new System.Drawing.Point(1428, 332);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 649);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            chartArea12.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart2.Legends.Add(legend12);
            this.chart2.Location = new System.Drawing.Point(130, 292);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart2.Name = "chart2";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series30.Legend = "Legend1";
            series30.Name = "Lift";
            this.chart2.Series.Add(series30);
            this.chart2.Size = new System.Drawing.Size(1246, 649);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // LblMethode
            // 
            this.LblMethode.AutoSize = true;
            this.LblMethode.Location = new System.Drawing.Point(304, 200);
            this.LblMethode.Name = "LblMethode";
            this.LblMethode.Size = new System.Drawing.Size(72, 20);
            this.LblMethode.TabIndex = 39;
            this.LblMethode.Text = "Methode";
            this.LblMethode.Visible = false;
            // 
            // MethodeLbl
            // 
            this.MethodeLbl.AutoSize = true;
            this.MethodeLbl.Location = new System.Drawing.Point(687, 200);
            this.MethodeLbl.Name = "MethodeLbl";
            this.MethodeLbl.Size = new System.Drawing.Size(72, 20);
            this.MethodeLbl.TabIndex = 40;
            this.MethodeLbl.Text = "Methode";
            this.MethodeLbl.Visible = false;
            this.MethodeLbl.Click += new System.EventHandler(this.MethodeLbl_Click);
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(700, 200);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(43, 20);
            this.LblYear.TabIndex = 45;
            this.LblYear.Text = "Year";
            this.LblYear.Visible = false;
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(335, 200);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(43, 20);
            this.YearLbl.TabIndex = 46;
            this.YearLbl.Text = "Year";
            this.YearLbl.Visible = false;
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Location = new System.Drawing.Point(304, 200);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(61, 20);
            this.ServiceLbl.TabIndex = 47;
            this.ServiceLbl.Text = "Service";
            this.ServiceLbl.Visible = false;
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(687, 200);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(61, 20);
            this.LblService.TabIndex = 48;
            this.LblService.Text = "Service";
            this.LblService.Visible = false;
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(309, 201);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(56, 20);
            this.LblOption.TabIndex = 49;
            this.LblOption.Text = "Option";
            this.LblOption.Visible = false;
            // 
            // OptionLbl
            // 
            this.OptionLbl.AutoSize = true;
            this.OptionLbl.Location = new System.Drawing.Point(687, 200);
            this.OptionLbl.Name = "OptionLbl";
            this.OptionLbl.Size = new System.Drawing.Size(56, 20);
            this.OptionLbl.TabIndex = 50;
            this.OptionLbl.Text = "Option";
            this.OptionLbl.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 988);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.MethodeLbl);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.ParkinglotTxt);
            this.Controls.Add(this.Parkinglot);
            this.Controls.Add(this.Streetname);
            this.Controls.Add(this.Streetnames);
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
            this.Controls.Add(this.OptionLbl);
            this.Controls.Add(this.LblService);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblMethode);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.ServiceLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Parkeerplaats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label LblMethode;
        private System.Windows.Forms.Label MethodeLbl;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.Label OptionLbl;
    }
}